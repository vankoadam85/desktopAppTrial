using partnertar.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Unity;

namespace partnertar.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class PartnersWindow : Window
    {
        private readonly IPartnersViewModel _viewModel;

        public PartnersWindow()
        {
            InitializeComponent();
        }

        [InjectionConstructor]
        public PartnersWindow(IPartnersViewModel viewModel) : this()
        {
            _viewModel = viewModel;
        }
    }
}
