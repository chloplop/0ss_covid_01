using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BillingManagement.UI.ViewModels;

namespace Inventaire
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        CustomerView _window;

        public App()
        {
            CustomerViewModel vm = new CustomerViewModel();

            _window = new CustomerView(vm);

            _window.Show();
        }
    }
}
