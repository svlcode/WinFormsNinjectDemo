using NewArch.Common.Interfaces.Controllers;
using NewArch.Common.Interfaces.Forms.Base;

namespace NewArch.Common.Interfaces.Forms
{
    public interface ILoginForm : IBaseForm<ILoginFormController>
    {
        bool? Login();

        string Username { get; }

        string Password { get; }
    }
}
