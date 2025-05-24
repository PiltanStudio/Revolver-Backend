using RevolverBackend.Models;

namespace RevolverBackend.Services
{
    public interface IPlayerService
    {
        List<Player> GetAll();
        Player Add(Player player);
    }

}
