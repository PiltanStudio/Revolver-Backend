using RevolverBackend.Data; // for AppDbContext
using Microsoft.EntityFrameworkCore;
using RevolverBackend.Models;
using RevolverBackend.Services;

public class PlayerService : IPlayerService
{
    private readonly AppDbContext _context;

    public PlayerService(AppDbContext context)
    {
        _context = context;
    }

    public List<Player> GetAll()
    {
        return _context.Players.ToList(); // Query database
    }

    public Player Add(Player player)
    {
        _context.Players.Add(player);  // Stage new player
        _context.SaveChanges();        // Write to DB
        return player;
    }

    public Player? Update(int id, Player updatedPlayer)
    {
        var existing = _context.Players.Find(id);
        if (existing == null) return null;

        existing.Username = updatedPlayer.Username;
        existing.Score = updatedPlayer.Score;

        _context.SaveChanges();
        return existing;
    }

    public bool Delete(int id)
    {
        var player = _context.Players.Find(id);
        if (player == null) return false;

        _context.Players.Remove(player);
        _context.SaveChanges();
        return true;
    }
}
