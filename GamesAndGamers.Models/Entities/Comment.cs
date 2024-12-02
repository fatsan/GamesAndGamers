
using Core.Entities;

namespace GamesAndGamers.Models.Entities;

public class Comment : Entity<int>
{
    public int GameId { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public int Rating { get; set; } //1-5 arasında puanlama olacak
    public DateTime CreatedTime { get; set; } // buraya bir daha bak entity den geliyor olması lazım
}
