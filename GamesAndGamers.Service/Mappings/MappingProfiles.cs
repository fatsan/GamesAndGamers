
using AutoMapper;
using GamesAndGamers.Models.Dtos.Games.Requests;
using GamesAndGamers.Models.Dtos.Games.Responses;
using GamesAndGamers.Models.Entities;

namespace GamesAndGamers.Service.Mappings;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateGameRequest, Game>();  //reverse de yazabilirisn
        CreateMap<Game, GameResponseDto>();
    }
}
