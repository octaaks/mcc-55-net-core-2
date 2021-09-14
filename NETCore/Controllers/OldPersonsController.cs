using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NETCore.Models;
using NETCore.Repository;
using System;
using System.Net;

namespace NETCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OldPersonsController : ControllerBase
    {
        private readonly OldPersonRepository personRepository;
        public OldPersonsController(OldPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        [HttpPost]
        public ActionResult Insert(Person person)
        {
            
            try
            {
                personRepository.Insert(person);
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

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(new
                {
                    data = personRepository.Get(),
                    /*statusCode = StatusCode(200),*/
                    status = HttpStatusCode.OK,
                    message = "Success"
                });
            }
            catch
            {
                return BadRequest(new
                {
                    status = HttpStatusCode.NoContent,
                    message = "No Data",
                    /*error = e*/
                });
            }
        }

        [HttpGet ("{NIK}")]
        public ActionResult Get(string NIK)
        {
            try
            {
                return Ok(new
                {
                    data = personRepository.Get(NIK),
                    /*StatusCode(200),*/
                    status = HttpStatusCode.OK,
                    message ="Success"
                });
            }
            catch
            {
                return BadRequest(new {
                    /*statusCode=StatusCode(400),*/
                    status = HttpStatusCode.BadRequest,
                    message ="Data tidak ditemukan"
                });
            }
            
        }

        [HttpPut]
        public ActionResult Update(Person person)
        {
            try
            {
                return Ok(personRepository.Update(person));
            }
            catch
            {
                return BadRequest(new
                {
                    message = "NIK tidak ditemukan",
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

        [HttpDelete ("{NIK}")]
        public ActionResult Delete(string NIK)
        {
            try
            {
                return Ok(personRepository.Delete(NIK));
            }
            catch
            {
                return BadRequest("NIK tidak ditemukan");
            }
            
        }
    }
}
