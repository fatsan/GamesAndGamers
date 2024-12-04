

using GamesAndGamers.Models.Entities;

namespace GamesAndGamers.Models.Dtos.Games.Responses;

public sealed record GameResponseDto(
    string Title,
    string Description,
    Genre Genre,
    decimal Price,
    DateTime ReleaseDate,
    string Developer,
    float Rating,
    List<Comment> Rewiews,
    string ImageUrl,
    int StockCount);
