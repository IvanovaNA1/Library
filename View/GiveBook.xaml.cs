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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Model;
using WpfApp1.ViewModel;
using static WpfApp1.View.Books;
using static WpfApp1.View.Users;

namespace WpfApp1.View
{
    public partial class GiveBook : UserControl
    {
        public GiveBook()
        {
            InitializeComponent();
            GiveBookViewModel viewModel = new GiveBookViewModel();
            this.DataContext = viewModel;
        }

    }
}
