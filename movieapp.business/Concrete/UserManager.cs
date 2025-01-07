using movieapp.business.Abstract;
using movieapp.data.Abstract;
using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Create(User entity)
        {
            
        }

        public void Delete(User entity)
        {
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAllUser();
        }

        public List<User> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User GetUserById(int userId)
        {
            return _userRepository.GetUserById(userId);
        }

        public void Update(User entity)
        {
        }
    }
}
