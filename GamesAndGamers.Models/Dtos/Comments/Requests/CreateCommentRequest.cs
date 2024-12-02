

namespace GamesAndGamers.Models.Dtos.Comments.Requests;

public sealed record CreateCommentRequest(
    int GameId,
    int UserId,
    string Content,
    int Rating,
    DateTime CreatedTime
    );
