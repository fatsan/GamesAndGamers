

namespace GamesAndGamers.Models.Dtos.Comments.Requests;

public sealed record UpdateCommentRequest(
    int Id,
    int GameId,
    int UserId,
    string Content,
    int Rating,
    DateTime CreatedTime
    );