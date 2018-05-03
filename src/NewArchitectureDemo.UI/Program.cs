using NewArch.BL;
using NewArch.Common;
using NewArch.Common.Interfaces.Forms;
using NewArch.Repos;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewArchitectureDemo.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //AppDomain.CurrentDomain.GetAssemblies()
            //   .SelectMany(a => a.DefinedTypes)
            //   .Where(t => t.IsSubclassOf(typeof(NinjectModule)))
            //   .ToList()
            //   .ForEach(t =>
            //   {
            //    });

           
            IoCContainer.Container = BuildKernel();

            var loginForm = IoCContainer.Get<ILoginForm>();
            if(loginForm.Login().GetValueOrDefault())
            {
                Application.Run(new MainForm());
            }
        }

        public static IKernel BuildKernel()
        {
            var modules = new INinjectModule[]
            {
                new UIModule(), // just my L2S binding
                new BLModule(),
                new ReposModule()
            };
            return new StandardKernel(modules);
        }
    }
}
