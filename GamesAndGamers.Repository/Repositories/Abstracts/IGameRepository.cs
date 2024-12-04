
using Core.Repository;
using GamesAndGamers.Models.Entities;

namespace GamesAndGamers.Repository.Repositories.Abstracts;

public interface IGameRepository : IRepository<Game,Guid>
{
}
