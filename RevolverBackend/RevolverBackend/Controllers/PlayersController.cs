using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RevolverBackend.Models;

namespace RevolverBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private static List<Player> players = new List<Player>();

        [HttpGet]
        public IActionResult Get() => Ok(players);

        [HttpPost]
        public IActionResult Add(Player player)
        {
            player.Id = players.Count + 1;
            players.Add(player);
            return Ok(player);
        }
    }
}
