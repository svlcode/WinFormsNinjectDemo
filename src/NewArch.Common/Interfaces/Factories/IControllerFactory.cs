using NewArch.Common.Interfaces.Controllers.Base;
using NewArch.Common.Interfaces.Forms.Base;

namespace NewArch.Common.Interfaces.Factories
{
    public interface IControllerFactory
    {
        T Get<T>(IBaseForm<T> form) where T : IBaseController;
    }
}
