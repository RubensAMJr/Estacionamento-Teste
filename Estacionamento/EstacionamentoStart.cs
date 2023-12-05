using Estacionamento.Controllers;
using Estacionamento.Models;
using Estacionamento.Services;
using Estacionamento.Views;
using SimpleInjector;
using SimpleInjector.Diagnostics;
using System.Windows.Forms.Design;

namespace Estacionamento
{
    internal static class EstacionamentoStart
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();

            var container = new Container();
            container.Register<IEstacionamentoService, EstacionamentoService>(Lifestyle.Singleton);
            container.Register<EstacionamentoController>(Lifestyle.Singleton);
            container.Register<FormConfiguracao>(Lifestyle.Singleton);
            container.Register<FormEstacionamento>(Lifestyle.Singleton);
            container.Verify();

            //Application.Run(new FormConfiguracao());
            Application.Run(container.GetInstance<FormConfiguracao>());
        }
    }
}