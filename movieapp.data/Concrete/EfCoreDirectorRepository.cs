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
    public class EfCoreDirectorRepository : EfCoreGenericRepository<Director, MovieContext>, IDirectorRepository
    {
        private MovieContext _context;
        public EfCoreDirectorRepository(MovieContext context) : base(context)
        {
            _context = context;
        }

        public List<Director> GetDirectorsWithFull()
        {
            return _context.Directors.Include(m => m.Directors)
                                .ThenInclude(m => m.Movie)
                                .ToList();
        }

        public Director GetDirectorWithFull(int directorId)
        {
            var director = _context.Directors.Include(m => m.Directors)
                                .ThenInclude(m => m.Movie)
                                .FirstOrDefault(m => m.Id == directorId);
            return director ?? new Director();
        }
    }
}
