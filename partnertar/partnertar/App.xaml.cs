using partnertar.Data_Access;
using partnertar.Data_Access.Interfaces;
using partnertar.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace partnertar
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IUnityContainer _container;

        protected override void OnStartup(StartupEventArgs e)
        {
            _container = new UnityContainer();
            _container.RegisterType<IPartnersDataAccess, PartnersDataAccess>();
        }
    }
}
