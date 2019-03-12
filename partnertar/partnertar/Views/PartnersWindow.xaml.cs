using partnertar.ViewModels;
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
    /// Interaction logic for PartnersWindow.xaml
    /// </summary>
    public partial class PartnersWindow : Window
    {
        public PartnersViewModel ViewModel { get; set; }

        public PartnersWindow()
        {
            InitializeComponent();
            DataContext = ViewModel;
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            Binding partnersBinding = new Binding("Partners")
            {
                Source = DataContext
            };
            partnersList.SetBinding(DataGrid.ItemsSourceProperty, partnersBinding);
        }
    }
}
