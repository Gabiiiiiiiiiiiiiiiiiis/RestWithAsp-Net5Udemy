using API_GameList_WhitASPNETCore.Model;
using API_GameList_WhitASPNETCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_GameList_WhitASPNETCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameListController : ControllerBase
    {


        private readonly ILogger<GameListController> _logger;
        private IGameServices _gameService;

        public GameListController(ILogger<GameListController> logger, IGameServices gameService)
        {
            _logger = logger;
            _gameService = gameService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_gameService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var game = _gameService.FindById(id);
            if(game==null) return NotFound();
            return Ok(game);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Game game)
        {
            if (game == null) return BadRequest();
            return Ok(_gameService.Create(game));
        }
        
        [HttpPut]
        public IActionResult Put([FromBody] Game game)
        {
            if (game == null) return BadRequest();
            return Ok(_gameService.Update(game));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var game = _gameService.FindById(id);
            _gameService.Delete(id);
            return NoContent();
        }
    }
}
