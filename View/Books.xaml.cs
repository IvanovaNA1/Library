using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static WpfApp1.MainWindow;
using static WpfApp1.View.Books;
using static WpfApp1.View.Users;
using static WpfApp1.ViewModel.BooksViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для Books.xaml
    /// </summary>
    public partial class Books : UserControl
    {
        private BooksViewModel viewModel;
        public Books()
        {
            InitializeComponent();

            viewModel = new BooksViewModel();
            this.DataContext = viewModel;
        }
        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            viewModel.SearchText = TBoxSearch.Text; // Передача текста во ViewModel
        }
    }
}

