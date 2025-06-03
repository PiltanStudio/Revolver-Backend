using RevolverBackend.Data;
using RevolverBackend.Models;
using Microsoft.AspNetCore.Identity;

public class UserService : IUserService
{
    private readonly AppDbContext _context;
    private readonly PasswordHasher<User> _passwordHasher = new();

    public UserService(AppDbContext context)
    {
        _context = context;
    }

    public User Register(string username, string password)
    {
        if (UserExists(username))
            return null;

        var user = new User { Username = username };
        user.PasswordHash = _passwordHasher.HashPassword(user, password);

        _context.Users.Add(user);
        _context.SaveChanges();
        return user;
    }

    public bool UserExists(string username)
    {
        return _context.Users.Any(u => u.Username == username);
    }
}
