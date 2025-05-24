using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RevolverBackend.Models;
using RevolverBackend.Services;

namespace RevolverBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_playerService.GetAll());

        [HttpPost]
        public IActionResult Add(Player player)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); 

            var result = _playerService.Add(player);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Player updatedPlayer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _playerService.Update(id, updatedPlayer);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var success = _playerService.Delete(id);
            if (!success) return NotFound();
            return NoContent(); // 204
        }

    }
}
