
namespace GamesAndGamers.Models.Dtos.Comments.Responses;

public sealed record CommentResponseDto(

    int UserId,
    string Content,
    int Rating,
    DateTime CreatedTime
    );
