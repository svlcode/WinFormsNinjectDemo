using NewArch.Model;

namespace NewArch.Common.Interfaces.Controllers
{
    public interface IUserRepo
    {
        UserEntity GetUser(string username);
    }
}
