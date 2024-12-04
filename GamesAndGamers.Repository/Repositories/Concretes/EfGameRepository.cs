
using Core.Repository;
using GamesAndGamers.Models.Entities;
using GamesAndGamers.Repository.Contexts;
using GamesAndGamers.Repository.Repositories.Abstracts;

namespace GamesAndGamers.Repository.Repositories.Concretes;

public class EfGameRepository : EfRepositoryBase<BaseDbContext, Game, Guid>, IGameRepository
{
    public EfGameRepository(BaseDbContext context) : base(context)
    {
    }
}
