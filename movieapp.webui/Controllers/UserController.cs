using Microsoft.AspNetCore.Mvc;
using movieapp.business.Abstract;
using movieapp.entity;

namespace movieapp.webui.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index(string id)
        {
            User user = _userService.GetUserById(int.Parse(id));
            return View(user);
        }
        public IActionResult ManageUserInfo(string id)
        {
            User user = _userService.GetUserById(int.Parse(id));
            return View(user);
        }
        [HttpPost]
        public IActionResult UpdateUser(User user,string passwordNow)
        {
            User userUpdate = _userService.GetUserById(user.Id);
            if(userUpdate.Password == passwordNow)
            {
                userUpdate.Password = user.Password;
                userUpdate.UserName = user.UserName;
                userUpdate.Email = user.Email;
                userUpdate.Password = user.Password;
            }
            //_userService.UpdateUser(userUpdate);
            return RedirectToAction("Index",userUpdate.Id);
        }
    }
}
