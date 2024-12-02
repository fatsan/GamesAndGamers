

using Core.Entities;

namespace GamesAndGamers.Models.Entities;

public class Genre : Entity<int>
{
    public string Name { get; set; }
    public List<Game> Games { get; set; }
}
