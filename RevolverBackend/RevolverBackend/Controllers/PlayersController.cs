using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RevolverBackend.Models;
using RevolverBackend.Services;

namespace RevolverBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private static List<Player> players = new List<Player>();
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_playerService.GetAll());

        [HttpPost]
        public IActionResult Add(Player player) => Ok(_playerService.Add(player));
    }
}
