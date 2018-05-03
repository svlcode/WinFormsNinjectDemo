using NewArch.Common.Interfaces.Controllers;
using NewArch.Common.Interfaces.Factories;
using NewArch.Common.Interfaces.Forms;
using System.Windows.Forms;

namespace NewArchitectureDemo.UI
{
    public partial class LoginForm : Form, ILoginForm
    {
        private readonly ILoginFormController _controller;

        public string Username { get { return txtUsername.Text; } }

        public string Password { get { return txtPassword.Text; } }

        public LoginForm(IControllerFactory controllerFactory)
        {
            InitializeComponent();

            _controller = controllerFactory.Get(this);
        }

        public bool? Login()
        {
            bool? loginResult = null;

            switch(ShowDialog())
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    loginResult = null;
                    break;
                default:
                    loginResult = false;
                    break;
            }
            return loginResult;
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            var result = _controller.Login();
            if(result)
            {
                this.DialogResult = DialogResult.OK;
            }
           
        }
    }
}
