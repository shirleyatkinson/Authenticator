using Microsoft.AspNetCore.Mvc;
using Authenticator.Models;

namespace Authenticator.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    //GET: api/Users
    [HttpGet]
    public IActionResult Get([FromBody] User usr)
    {
        bool Verified = getValidation(usr);
        return Ok(new string[] {"Verified", Verified.ToString()});
    }

    private bool getValidation(User usr)
    {
        bool validation = false;

        if((usr.Email == "testme@test.com")
        && (usr.Password == "insecurePWD"))
        {
            validation = true;
        }

        return validation;
    }

}