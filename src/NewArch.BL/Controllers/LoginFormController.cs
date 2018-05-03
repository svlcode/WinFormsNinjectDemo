using NewArch.BL.Controllers.Base;
using NewArch.Common.Interfaces.Controllers;
using NewArch.Common.Interfaces.Forms;

namespace NewArch.BL.Controllers
{
    public class LoginFormController : BaseController, ILoginFormController
    {
        private readonly ILoginForm _form;
        private readonly IUserRepo _userRepo;

        public LoginFormController(ILoginForm form, IUserRepo userRepo)
        {
            _form = form;
            _userRepo = userRepo;
        }

        public bool Login()
        {
            var user = _userRepo.GetUser("vio");
            if(user != null)
            {
                return user.Password == _form.Password;
            }
            return false;
        }
    }
}
