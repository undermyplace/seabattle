using Microsoft.AspNetCore.Mvc;
using SeaBattle.Models;
using SeaBattle.Services;

namespace SeaBattle.Controllers
{
    [ApiController]
    [Route("")]
    public class BattleController : ControllerBase
    {
        private readonly IBattleService _service;
        private readonly ICoordParser _parser;
        public BattleController(IBattleService service, ICoordParser parser)
        {
            _service = service;
            _parser = parser;
        }

        [HttpPost("create-matrix")]
        public void CreateMatrix([FromBody] CreateMatrixRequest model)
        {
            _service.CreateBattle(model.Range);

        }
        [HttpPost("ship")]
        public void SetShips([FromBody] SetChipsRequest model)
        {
            var ships = _parser.ParseShips(model.Coordinates);

            var battle = _service.GetCurrentBattle();

            battle.SetShips(ships);

        }

        [HttpPost("shot")]
        public ActionResult<ShotResponse> Shot([FromBody] ShotRequest model)
        {

            var coord = _parser.ParseCoord(model.Coordinates);

            var battle = _service.GetCurrentBattle();

            var result = battle.Shot(coord);

            return result.ToActionResult();
        }

        [HttpPost("clear")]
        public void Clear()
        {
            _service.CreateBattle(_service.GetCurrentBattle().Range);
            
        }

        [HttpGet("state")]
        public ActionResult<StateResponse> GetState()
        {

            var battle = _service.GetCurrentBattle();

            var info = battle.GetInfo();

            return Ok(new StateResponse(info));
        }
    }
}
