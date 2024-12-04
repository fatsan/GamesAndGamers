

using GamesAndGamers.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamesAndGamers.Repository.Contexts;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions opt): base(opt)
    {
    }
    public DbSet<Game> Games { get; set; }
}
