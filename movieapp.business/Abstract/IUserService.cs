using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.business.Abstract
{
    public interface IUserService
    {
        User GetById(int id);
        List<User> GetAll();
        void Create(User entity);
        void Update(User entity);
        void Delete(User entity);
        public List<User> GetAllUser();
        public User GetUserById(int userId);

    }
}
