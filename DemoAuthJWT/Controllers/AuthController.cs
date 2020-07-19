using DemoAuthJWT.Helpers;
using DemoAuthJWT.Models;
using DemoAuthJWT.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DemoAuthJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Auth([FromBody]User user)
        {
            try
            {
                //uma boa prática seria usar DI (Injeção de dependência)
                var userExists = new UserRepository().GetByEmail(user.Email);

                if (userExists == null)
                    return BadRequest(new { Message = "Email e/ou senha inválidos." });


                if (userExists.Password != user.Password)
                    return BadRequest(new { Message = "Email e/ou senha inválidos." });


                var token = AuthHelper.GenerateToken(userExists);

                return Ok(new
                {
                    Token = token,
                    Usuario = userExists
                });

            }
            catch (Exception)
            {
                return BadRequest(new { Message = "Ocorreu algum erro interno na aplicação, por favor tente novamente." });
            }
        }
    }
}