
using GamesAndGamers.Models.Entities;

namespace GamesAndGamers.Models.Dtos.Genres.Responses;

public sealed record GenreResponseDto(
    string Name,
    List<Game> Games);
