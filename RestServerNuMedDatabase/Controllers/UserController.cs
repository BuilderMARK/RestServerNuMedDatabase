using System;
using System.Threading.Tasks;
using Database4Adult1.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Database4Adult1.Controllers
{
   
        [ApiController]
        [Route("[controller]")]
        public class UsersController : ControllerBase
        {
            private readonly IUserRepo userRepo;

            public UsersController(IUserRepo userRepo)
            {
                this.userRepo = userRepo;
            }

            [HttpGet]
            public async Task<ActionResult<User>> ValidateUser([FromQuery] string username, [FromQuery] string password)
            {
                Console.WriteLine("Here");
                try
                {
             
                    var user = await userRepo.ValidateUser(username, password);
                    return Ok(user);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
    }
}