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
        public Player Update(int id, Player updatedPlayer)
        {
            var player = _players.FirstOrDefault(p => p.Id == id);
            if (player == null) return null;

            player.Username = updatedPlayer.Username;
            player.Score = updatedPlayer.Score;
            return player;
        }
        public bool Delete(int id)
        {
            var player = _players.FirstOrDefault(p => p.Id == id);
            if (player == null) return false;

            _players.Remove(player);
            return true;
        }
    }

}
