using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.data.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        public List<User> GetAllUser();
        public User GetUserById(int userId);
    }
}
