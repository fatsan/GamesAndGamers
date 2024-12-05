using GamesAndGamers.Models.Dtos.Games.Requests;
using GamesAndGamers.Service.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamesAndGamers.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GamesController(IGameService _gameService) : ControllerBase
{

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _gameService.GetAll();
        return Ok(result);
    }
    [HttpPost("add")]
    public IActionResult Add([FromBody] CreateGameRequest dto)
    {
        var result = _gameService.Add(dto);
        return Ok(result);
    }
    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var result = _gameService.GetById(id);
        return Ok(result);
    }
}
