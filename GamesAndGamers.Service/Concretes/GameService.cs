
using AutoMapper;
using Core.Entities;
using GamesAndGamers.Models.Dtos.Games.Requests;
using GamesAndGamers.Models.Dtos.Games.Responses;
using GamesAndGamers.Models.Entities;
using GamesAndGamers.Repository.Repositories.Abstracts;
using GamesAndGamers.Service.Abstracts;

namespace GamesAndGamers.Service.Concretes;

public sealed class GameService : IGameService
{
    private readonly IGameRepository _gameRepository;
    private readonly IMapper _mapper;

    public GameService(IGameRepository gameRepository, IMapper mapper)
    {
        _gameRepository = gameRepository;
        _mapper = mapper;
    }

    public ReturnModel<GameResponseDto> Add(CreateGameRequest dto)
    {
        Game createdGame = _mapper.Map<Game>(dto);
        createdGame.Id = Guid.NewGuid();

        Game game = _gameRepository.Add(createdGame);
        GameResponseDto responseDto = _mapper.Map<GameResponseDto>(game);
        return new ReturnModel<GameResponseDto>
        {
            Data = responseDto,
            Message = $"The Game {responseDto.Title} has been added.",
            Status = 200,
            Success = true
        };     
    }

    public ReturnModel<GameResponseDto> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<List<GameResponseDto>> GetAll()
    {
        List<Game> list = _gameRepository.GetAll();
        List<GameResponseDto> responses = _mapper.Map<List<GameResponseDto>>(list);
        return new ReturnModel<List<GameResponseDto>>
        {
            Data = responses,
            Message = string.Empty,
            Status = 200,
            Success = true
        };
    }

    public ReturnModel<GameResponseDto> GetById(Guid id)
    {
        var game = _gameRepository.GetById(id);
        var response = _mapper.Map<GameResponseDto>(game);
        return new ReturnModel<GameResponseDto>
        {
            Data = response,
            Message = "This is the Game that you looking for...",
            Status = 200,
            Success = true
        };

    }

    public ReturnModel<GameResponseDto> Update(UpdateGameRequest dto)
    {
        throw new NotImplementedException();
    }
}
