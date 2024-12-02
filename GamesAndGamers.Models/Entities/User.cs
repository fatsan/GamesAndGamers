

namespace GamesAndGamers.Models.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public List<FavoriteGame> FavoriteGames { get; set; }
    public List<Comment> Reviews { get; set; }
}
