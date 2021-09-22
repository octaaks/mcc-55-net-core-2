using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NETCore.Base;
using NETCore.Models;
using NETCore.Repository.Data;
using NETCore.ViewModel;
using NETCore.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace NETCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : BaseController<Person, PersonRepository, string>
    {
        public IConfiguration _configuration;
        private readonly PersonRepository repository;
        public PersonsController(IConfiguration config, PersonRepository repository) : base(repository)
        {
            _configuration = config;
            this.repository = repository;
        }

        /// <summary>
        /// Get all persons data
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet("GetPerson")]  
        public ActionResult GetPerson()
        {
            var getPerson = repository.GetPersonVMs();
            if (getPerson != null)
            {
                //var get = Ok(new
                //{
                //    status = HttpStatusCode.OK,
                //    result = getPerson,
                //    message = "Success"
                //});
                //return get;

                return Ok(getPerson);
            }
            else
            {
                var get = NotFound(new
                {
                    status = HttpStatusCode.NotFound,
                    result = getPerson,
                    message = "Data Empty"
                });
                return get;
            }
        }

        /// <summary>
        /// Get person data by NIK
        /// </summary>
        /// <param name="NIK"></param>
        /// <returns></returns>
        ///

        //[Authorize]
        [AllowAnonymous]
        [HttpGet("GetPerson/{NIK}")]
        public ActionResult GetPerson(string NIK)
        {
            var getPerson = repository.GetPersonVMs(NIK);
            if (getPerson != null)
            {
                //var get = Ok(new
                //{
                //    status = HttpStatusCode.OK,
                //    result = getPerson,
                //    message = "Success"
                //});
                //return get;

                return Ok(getPerson);
            }
            else
            {
                var get = NotFound(new
                {
                    status = HttpStatusCode.NotFound,
                    result = getPerson,
                    message = "Data Empty"
                });
                return get;
            }
        }

        /// <summary>
        /// Register/Insert new person data
        /// </summary>
        /// <param name="personVM"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [EnableCors("AllowAllOrigins")]
        [HttpPost("Register")]
        public ActionResult Insert(PersonVM personVM)
        {
            try
            {
                int output = repository.Insert(personVM);
                if(output == 100)
                {
                    return BadRequest(new
                    {
                        status = HttpStatusCode.BadRequest,
                        message = "Duplicate email",
                        /*error = e*/
                    });
                }else if (output == 200)
                {
                    return BadRequest(new
                    {
                        status = HttpStatusCode.BadRequest,
                        message = "Duplicate NIK",
                        /*error = e*/
                    });
                }else if (output == 300)
                {
                    return BadRequest(new
                    {
                        status = HttpStatusCode.BadRequest,
                        message = "Duplicate Phone",
                        /*error = e*/
                    });
                }
                return Ok(new
                {
                    /*statusCode = StatusCode(200),*/
                    status = HttpStatusCode.OK,
                    message = "Success"
                });
            }
            catch
            {
                return BadRequest(new
                {
                    status = HttpStatusCode.BadRequest,
                    message = "Error duplicate data",
                    /*error = e*/
                });
            }
        }

        /// <summary>
        /// Login person's account
        /// </summary>
        /// <param name="loginVM"></param>
        /// <returns></returns>
        /// 

        [AllowAnonymous]
        [HttpPost("Login")]
        public ActionResult Login(LoginVM loginVM)
        {

            if (ModelState.IsValid)
            {
                int output = repository.Login(loginVM);
                if (output == 100)
                {
                    return NotFound(new
                    {
                        status = HttpStatusCode.NotFound,
                        message = "Email not available",
                        /*error = e*/
                    });
                }
                else if (output == 200)
                {
                    return BadRequest(new
                    {
                        status = HttpStatusCode.BadRequest,
                        message = "Wrong Password",
                        /*error = e*/
                    });
                }

                //if success
                //create claims details based on the user information

                    //var claims = new[] {
                    //    new Claim("Email", loginVM.Email),
                    //    new Claim("role", loginVM.Role)
                    //   };

                    //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    //var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    //var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                    //return Ok(new JwtSecurityTokenHandler().WriteToken(token));

                string[] roles = repository.Roles(loginVM.Email);
                var claim = new List<Claim>();
                claim.Add(new Claim("email", loginVM.Email));
                foreach (string d in roles)
                {
                    claim.Add(new Claim("roles", d));
                }
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claim, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

                //return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                //return Ok(new JWTokenVM { Token = token, Messages = "Login Sukses" });

                return Ok(new JWTokenVM
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Messages = "Login Sukses"
                });

                //return Ok(new
                //{
                //    /*statusCode = StatusCode(200),*/
                //    status = HttpStatusCode.OK,
                //    message = "Success"
                //});
            }
            else
            {
                return BadRequest(new
                {
                    status = HttpStatusCode.BadRequest
                });
            }

        }

        //[AllowAnonymous]
        //[HttpPost("Login")]
        //public ActionResult Login(LoginVM loginVm)
        //{
        //    var login = repository.Login(loginVm);

        //    if (login == 0)
        //    {
        //        return NotFound("Email Belum Terdaftar");
        //    }
        //    else if (login == 1)
        //    {
        //        return BadRequest("Password Salah");
        //    }
        //    else
        //    {
        //        string[] roles = repository.Roles(loginVm.Email);
        //        var claim = new List<Claim>();
        //        claim.Add(new Claim("email", loginVm.Email));
        //        foreach (string d in roles)
        //        {
        //            claim.Add(new Claim("roles", d));
        //        }
        //        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

        //        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //        var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claim, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

        //        return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        //        //return Ok(new
        //        //{
        //        //    status = HttpStatusCode.OK,
        //        //    message = "Login Berhasil"
        //        //});
        //    }
        //}

        //private async Task<Account> GetUser(string email, string password)
        //{
        //    return await repository.Account.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        //}
    }
}
