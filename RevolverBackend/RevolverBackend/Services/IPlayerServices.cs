using RevolverBackend.Models;

namespace RevolverBackend.Services
{
    public interface IPlayerService
    {
        List<Player> GetAll();
        Player Add(Player player);
        Player? Update(int id, Player updatedPlayer);
        bool Delete(int id);
    }

}
