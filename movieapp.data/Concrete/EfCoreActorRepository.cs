using Microsoft.EntityFrameworkCore;
using movieapp.data.Abstract;
using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.data.Concrete
{
    public class EfCoreActorRepository : EfCoreGenericRepository<Actor, MovieContext>, IActorRepository
    {
        private MovieContext _context;
        public EfCoreActorRepository(MovieContext context) : base(context)
        {
            _context = context;
        }

        public List<Actor> GetActorsWithFull()
        {
            return _context.Actors.Include(m => m.Actors)
                                .ThenInclude(m => m.Movie)
                                .ToList();
        }

        public Actor GetActorWithFull(int actorId)
        {
            var actor = _context.Actors.Include(m => m.Actors)
                                .ThenInclude(m => m.Movie)
                                .FirstOrDefault(m=>m.Id == actorId);
            return actor ?? new Actor();
        }
    }
}
