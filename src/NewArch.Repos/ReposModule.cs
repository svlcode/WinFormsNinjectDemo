using NewArch.Common.Interfaces.Controllers;
using Ninject.Modules;

namespace NewArch.Repos
{
    public class ReposModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserRepo>().To<UserRepo>();
        }
    }
}
