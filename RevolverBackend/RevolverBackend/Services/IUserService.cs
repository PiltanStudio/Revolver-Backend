using RevolverBackend.Models;

public interface IUserService
{
    User Register(string username, string password);
    bool UserExists(string username);
}
