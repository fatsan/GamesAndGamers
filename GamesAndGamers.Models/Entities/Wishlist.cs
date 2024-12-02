

using Core.Entities;

namespace GamesAndGamers.Models.Entities;

public class Wishlist : Entity<int>
{
    public int UserId { get; set; }
    public int GameId { get; set; }
}

