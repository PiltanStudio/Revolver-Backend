using RevolverBackend.Models;

namespace RevolverBackend.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly List<Player> _players = new();

        public List<Player> GetAll() => _players;

        public Player Add(Player player)
        {
            player.Id = _players.Count + 1;
            _players.Add(player);
            return player;
        }
    }

}
