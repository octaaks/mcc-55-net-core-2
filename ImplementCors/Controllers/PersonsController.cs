using ImplementCors.Base.Controllers;
using ImplementCors.Repositories.Data;
using Microsoft.AspNetCore.Mvc;
using NETCore.Models;
using NETCore.ViewModel;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace ImplementCors.Controllers
{
    [Route("[controller]")]
    public class PersonsController : BaseController<Person, PersonRepository, string>
    {
        private readonly PersonRepository repository;
        public PersonsController(PersonRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        [HttpGet("GetPerson")]
        public async Task<JsonResult> GetPerson()
        {
            var result = await repository.GetPerson();
            return Json(result);
        }

        [HttpGet("GetPersonById/{nik}")]
        //[HttpGet]
        public async Task<JsonResult> GetPersonById(string nik)
        {
            var result = await repository.GetPersonById(nik);
            return Json(result);
        }


        [HttpDelete("DeletePerson/{id}")]
        public JsonResult DeletePerson(string id)
        {
            var result = repository.DeletePerson(id);
            return Json(result);
        }

        [HttpPost("InsertPerson")]
        public JsonResult InsertPerson([FromBody] PersonVM entity)
        {
            var result = repository.Register(entity);
            return Json(result);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Table()
        {
            return View();
        }
    }
}
