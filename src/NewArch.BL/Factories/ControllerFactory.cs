using NewArch.Common;
using NewArch.Common.Interfaces.Controllers.Base;
using NewArch.Common.Interfaces.Factories;
using NewArch.Common.Interfaces.Forms.Base;
using Ninject;
using Ninject.Parameters;

namespace NewArch.BL.Factories
{
    public class ControllerFactory : IControllerFactory
    {
        public T Get<T>(IBaseForm<T> form) where T : IBaseController
        {
            var argument = new ConstructorArgument(nameof(form), form);
            return IoCContainer.Container.Get<T>(argument);
        }
    }
}
