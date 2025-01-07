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
    public class EfCoreUserRepository : EfCoreGenericRepository<User, MovieContext>, IUserRepository
    {
        private MovieContext _context;
        public EfCoreUserRepository(MovieContext context) : base(context)
        {
            _context = context;
        }
        public List<User> GetAllUser()
        {
            List<User> userList;
            userList = _context.Users.Include(m=>m.FavoriteMovies).ToList();
            return userList;
        }
        public User GetUserById(int userId)
        {
            User user;
            user = _context.Users.Include(m => m.FavoriteMovies).Include(m=>m.Reviews).FirstOrDefault(m => m.Id == userId) ?? new User();
            return user;
        }

    }
}
