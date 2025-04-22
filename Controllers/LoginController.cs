using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

[AllowAnonymous]
[ApiController]
[Route("api/login")]
public class LoginController : ControllerBase
{
    private readonly IConfiguration _config;

    public LoginController(IConfiguration config)
    {
        _config = config;
    }

    [AllowAnonymous]
    [HttpPost("")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        if (request.Username == "admin" && request.Password == "password") // Validate credentials
        {
            var token = new JwtService(_config).GenerateToken(request.Username);
            return Ok(new { Token = token });
        }

        return Unauthorized();
    }

        // Define the LoginRequest class
        public class LoginRequest
        {
            public string? Username { get; set; }
            public string? Password { get; set; }
        }
    }
