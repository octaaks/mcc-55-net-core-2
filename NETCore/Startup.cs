using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using NETCore.Context;
using NETCore.Repository.Data;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace NETCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*services.AddControllers();*/
            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );

            //JWT
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["Jwt:Audience"],
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

            //scope tiap repository
            services.AddScoped<PersonRepository>();
            services.AddScoped<EducationRepository>();
            services.AddScoped<AccountRepository>();
            services.AddScoped<ProfilingRepository>();
            services.AddScoped<UniversityRepository>();
            services.AddScoped<AccountRoleRepository>();
            services.AddScoped<RoleRepository>();

            services.AddDbContext<MyContext>(options =>
                options.UseLazyLoadingProxies()
                .UseSqlServer(Configuration.GetConnectionString("NETCoreContext"))
            );

            //swagger
            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc("NETCoreAPI", new
                Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "NET Core API",
                    Version = "1"
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                setupAction.IncludeXmlComments(xmlPath);
            });

            //CORS
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
                //c.AddPolicy("AllowOrigin", options => options.WithOrigins("https://localhost:44300"));
                //c.AddPolicy("AllowOrigin", options => options.WithOrigins("https://localhost:44359"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCors(options => options.AllowAnyOrigin());
            //app.UseCors(options => options.WithOrigins("https://localhost:44300"));
            //app.UseCors(options => options.WithOrigins("https://localhost:44359"));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //swagger
            app.UseSwagger();
            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint("/Swagger/NETCoreAPI/swagger.json", "NET Core API");
                setupAction.RoutePrefix = "";
            });
        }
    }
}
