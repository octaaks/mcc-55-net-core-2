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

        //[HttpPost("Register")]
        //public JsonResult Register(string nik, string firstname, string lastname, string phone, string birthdate, int gender, int salary, string email, string password, string degree, string gpa, int univId)
        //{
        //    PersonVM entity = new PersonVM();
        //    entity.NIK = nik;
        //    entity.FirstName = firstname;
        //    entity.LastName = lastname;
        //    entity.Phone = phone;
        //    entity.BirthDate = DateTime.Parse(birthdate);
        //    entity.gender = (PersonVM.Gender)gender;
        //    entity.Salary = salary;
        //    entity.Email = email;
        //    entity.Password = password;
        //    entity.Degree = degree;
        //    entity.GPA = gpa;
        //    entity.UniversityId = univId;


        //    var result = repository.Post(entity);
        //    return Json(result);
        //}

        [HttpPost("Register")]
        public JsonResult Register(PersonVM entity)
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
