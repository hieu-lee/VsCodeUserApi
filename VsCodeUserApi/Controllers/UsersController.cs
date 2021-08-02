using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VsCodeUserApi.Data;
using VsCodeUserApi.Models;

namespace VsCodeUserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserDbContext dbContext;
        public UsersController(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("users/new")]
        public async Task<IActionResult> NewUser([FromBody] string id)
        {
            Account acc = new() { Id = id };
            var myacc = await dbContext.Accounts.Where(s => s.Id == id).FirstOrDefaultAsync();
            if (myacc is null)
            {
                dbContext.Accounts.Add(acc);
                await dbContext.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return Unauthorized("The account id is already taken");
            }
        }
    }
}
