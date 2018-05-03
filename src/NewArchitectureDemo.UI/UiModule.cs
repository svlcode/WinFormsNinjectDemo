using NewArch.Common.Interfaces.Forms;
using Ninject.Modules;

namespace NewArchitectureDemo.UI
{
    public class UIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoginForm>().To<LoginForm>();
        }
    }
}
