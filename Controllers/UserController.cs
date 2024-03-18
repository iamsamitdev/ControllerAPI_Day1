using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")] // api/User
public class UserController : ControllerBase
{
    // GET: api/User
    [HttpGet]
    public ActionResult<List<User>> GetUsers()
    {
        var users = new List<User>
        {
            new User { 
                Id = 1, 
                Username = "john", 
                Email = "john@email.com", 
                Fullname = "John Doe"
            },
            new User { 
                Id = 1, 
                Username = "samit", 
                Email = "samit@email.com", 
                Fullname = "Samit Koyom"
            },
        };

        return Ok(users);
    }
}