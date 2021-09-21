using ImplementCors.Base.Controllers;
using ImplementCors.Repositories.Data;
using Microsoft.AspNetCore.Mvc;
using NETCore.Models;

namespace ImplementCors.Controllers
{
    public class UniversitiesController : BaseController<University, UniversityRepository, int>
    {
        private readonly UniversityRepository repository;
        public UniversitiesController(UniversityRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
