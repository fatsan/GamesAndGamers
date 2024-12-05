

using Core.Entities;
using GamesAndGamers.Models.Dtos.Games.Requests;
using GamesAndGamers.Models.Dtos.Games.Responses;
using GamesAndGamers.Models.Entities;

namespace GamesAndGamers.Service.Abstracts;

public interface IGameService
{
    ReturnModel<GameResponseDto> Add(CreateGameRequest dto );
    ReturnModel<List<GameResponseDto>> GetAll();
    ReturnModel<GameResponseDto> GetById(Guid id);
    ReturnModel<GameResponseDto> Update(UpdateGameRequest dto );
    ReturnModel<GameResponseDto> Delete(Guid id);
}
