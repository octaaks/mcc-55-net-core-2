using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NETCore.Base;
using NETCore.Models;
using NETCore.Repository.Data;
using NETCore.ViewModel;
using System.Net;

namespace NETCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : BaseController<Account, AccountRepository, string>
    {
        private readonly AccountRepository repository;
        public AccountsController(AccountRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Send reset password link to the email
        /// </summary>
        /// <param name="emailVM"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost("forget-password")]
        public ActionResult ForgetPassword(EmailVM emailVM)
        {
            int output = repository.ForgetPassword(emailVM.Email);
            if (output == 100)
            {
                return BadRequest(new
                {
                    status = HttpStatusCode.BadRequest,
                    message = "Email Not Found",
                    /*error = e*/
                });
            }
            return Ok(new
            {
                /*statusCode = StatusCode(200),*/
                status = HttpStatusCode.OK,
                message = "Reset Password link sent !"
            });
        }

        /// <summary>
        /// Generate new password then send to the email
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        /// 
        [Authorize]
        [HttpPost("reset-password/email={Email}&token={Token}")]
        public ActionResult ResetPassword(string Email, string Token)
        {
            /*string tempEmail = Request.Query.Keys.Contains("email").ToString();*/
            int output = repository.ResetPassword(Email, Token);
            if (output == 100)
            {
                return BadRequest(new
                {
                    status = HttpStatusCode.BadRequest,
                    message = "Wrong Token !",
                    /*error = e*/
                });
            }
            else if (output == 200)
            {
                return BadRequest(new
                {
                    status = HttpStatusCode.BadRequest,
                    message = "Wrong Email !",
                    /*error = e*/
                });
            }
            return Ok(new
            {
                statusCode = StatusCode(200),
                status = HttpStatusCode.OK,
                message = "Password has been reset !"
            });
            /*return RedirectToAction()*/
        }

        /// <summary>
        /// Change account's password
        /// </summary>
        /// <param name="cpVM"></param>
        /// <returns></returns>
        /// 
        [Authorize]
        [HttpPost("change-password")]
        public ActionResult ChangePassword(ChangePasswordVM cpVM)
        {
            if (ModelState.IsValid)
            {
                //
            }
            int output = repository.ChangePassword(cpVM);
            if (output == 100)
            {
                return NotFound(new
                {
                    status = HttpStatusCode.NotFound,
                    message = "NIK tdk terdaftar!"
                });
            }
            else if (output == 200)
            {
                return BadRequest(new
                {
                    status = HttpStatusCode.BadRequest,
                    message = "Email tdk terdaftar!"
                });
            }
            else if (output == 300)
            {
                return BadRequest(new
                {
                    status = HttpStatusCode.BadRequest,
                    message = "Password lama salah!"
                });
            }
            else if (output == 400)
            {
                return BadRequest(new
                {
                    status = HttpStatusCode.BadRequest,
                    message = "Konfirmasi password tidak sama!"
                });
            }
            return Ok(new
            {
                status = HttpStatusCode.OK,
                message = "Success ganti password!"
            });
        }

    }
}
