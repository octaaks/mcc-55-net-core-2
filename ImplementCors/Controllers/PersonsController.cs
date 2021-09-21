using ImplementCors.Base.Controllers;
using ImplementCors.Repositories.Data;
using Microsoft.AspNetCore.Mvc;
using NETCore.Models;
using NETCore.ViewModel;
using System.Threading.Tasks;

namespace ImplementCors.Controllers
{
    public class PersonsController : BaseController<Person, PersonRepository, string>
    {
        private readonly PersonRepository repository;
        public PersonsController(PersonRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<JsonResult> GetPerson()
        {
            var result = await repository.GetPerson();
            return Json(result);
        }

        [HttpGet("GetPersonBy/{nik}")]
        public async Task<JsonResult> GetPersonBy(string nik)
        {
            var result = await repository.GetPersonById(nik);
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
