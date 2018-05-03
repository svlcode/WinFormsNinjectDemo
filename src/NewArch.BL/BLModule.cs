using NewArch.BL.Controllers;
using NewArch.BL.Factories;
using NewArch.Common.Interfaces.Controllers;
using NewArch.Common.Interfaces.Factories;
using Ninject.Modules;

namespace NewArch.BL
{
    public class BLModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoginFormController>().To<LoginFormController>();
            Bind<IControllerFactory>().To<ControllerFactory>();
        }
    }
}
