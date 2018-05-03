using NewArch.Common.Interfaces.Controllers.Base;
using NewArch.Common.Interfaces.Forms.Base;
using Ninject;

namespace NewArch.Common
{
    public static class IoCContainer
    {
        public static IKernel Container { get; set; }

        public static T Get<T>()
        {
            return Container.Get<T>();
        }
    }
}
