

using Core.Entities;
using System.Reflection.Metadata;

namespace GamesAndGamers.Models.Entities;

public class Game : Entity<Guid>
{
    public string Title         { get; set; }
    public string Description    { get; set; }
    public Genre Genre               { get; set; }
    public decimal Price             { get; set; }
    public DateTime ReleaseDate         { get; set; }
    public string Developer                 { get; set; }
    public float Rating                  { get; set; }
    public List<Comment> Rewiews                { get; set; }
    public string ImageUrl              { get; set; }
    public int StockCount                   { get; set; }
}
