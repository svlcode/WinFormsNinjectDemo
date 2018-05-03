using NewArch.Common.Interfaces.Controllers;
using NewArch.Model;

namespace NewArch.Repos
{
    public class UserRepo : IUserRepo
    {
        public UserEntity GetUser(string username)
        {
            if(username?.ToLower() == "vio")
            {
                return new UserEntity { Username = username, Password = "123" };
            }
            return null;
        }
    }
}
