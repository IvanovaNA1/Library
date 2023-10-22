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
using static WpfApp1.ViewModel.UsersViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : UserControl
    {
        private UsersViewModel viewModel;
        public Users()
        {
            InitializeComponent();
        }
        
        private void TBoxSearch_TextChanged(object sender, EventArgs e)
        {
            viewModel.SearchText = TBoxSearch.Text;
        }
        
    }
}

