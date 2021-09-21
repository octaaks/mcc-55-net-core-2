using ImplementCors.Base.Urls;
using Microsoft.AspNetCore.Http;
using NETCore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ImplementCors.Repositories.Data
{
    public class UniversityRepository : GeneralRepository<University, int>
    {
        private readonly Address address;
        private readonly string request;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly HttpClient httpClient;

        public UniversityRepository(Address address, string request = "Universities/") : base(address, request)
        {
            this.address = address;
            this.request = request;
            //_contextAccessor = new HttpContextAccessor();
            //httpClient = new HttpClient
            //{
            //    BaseAddress = new Uri(address.link)
            //};
            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", _contextAccessor.HttpContext.Session.GetString("JWToken"));
        }

        public async Task<List<University>> GetByProvinceId(int provinceId)
        {
            List<University> entities = new List<University>();

            using (var response = await httpClient.GetAsync(request + "getbyprovinceid/" + provinceId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                entities = JsonConvert.DeserializeObject<List<University>>(apiResponse);
            }
            return entities;
        }
    }
}
