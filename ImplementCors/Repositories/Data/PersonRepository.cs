using ImplementCors.Base.Urls;
using ImplementCors.Controllers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NETCore.ViewModel;
using Newtonsoft.Json;
using NETCore.Models;
using System.Net;
using System.Text;

namespace ImplementCors.Repositories.Data
{
    public class PersonRepository : GeneralRepository<Person, string>
    {
        private readonly Address address;
        private readonly HttpClient httpClient;
        private readonly string request;
        private readonly IHttpContextAccessor contextAccessor;
        public PersonRepository(Address address, string request = "Persons/") : base(address, request)
        {
            this.address = address;
            this.request = request;
            contextAccessor = new HttpContextAccessor();
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(address.link)
            };
        }
        public async Task<List<PersonVM>> GetPerson()
        {
            List<PersonVM> registers = new List<PersonVM>();
            using (var response = await httpClient.GetAsync(request + "GetPerson"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                registers = JsonConvert.DeserializeObject<List<PersonVM>>(apiResponse);
            }
            return registers;
        }

        public async Task<PersonVM> GetPersonById(string nik)
        {
            PersonVM register = new PersonVM();
            //PersonVM register = null;

            using (var response = await httpClient.GetAsync(request + "GetPerson/" + nik))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                register = JsonConvert.DeserializeObject<PersonVM>(apiResponse);
            }
            return register;
        }


        public HttpStatusCode DeletePerson(string id)
        {
            var result = httpClient.DeleteAsync(request + id).Result;
            return result.StatusCode;
        }

        //public HttpStatusCode Register(PersonVM entity)
        //{
        //    StringContent content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
        //    var result = httpClient.PostAsync(address.link + request + "Register/", content).Result;
        //    return result.StatusCode;
        //}
        public string Register(PersonVM entity)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
            var result = httpClient.PostAsync( request + "Register", content).Result.Content.ReadAsStringAsync().Result;
            return result;
        }
    }
}