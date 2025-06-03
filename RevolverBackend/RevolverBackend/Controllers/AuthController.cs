using Microsoft.AspNetCore.Mvc;
using RevolverBackend.Models;
using RevolverBackend.Services;
using System.ComponentModel.DataAnnotations;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = _userService.Register(request.Username, request.Password);
        if (user == null)
            return Conflict("Username already exists.");

        return Ok(new { user.Id, user.Username });
    }
}

public class RegisterRequest
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
