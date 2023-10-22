using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class BooksViewModel : INotifyPropertyChanged
    {
        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                if (searchText != value)
                {
                    searchText = value;
                    OnPropertyChanged(nameof(SearchText));
                    FilterBooks();
                }
            }
        }

        public ObservableCollection<Book> books;
        public ObservableCollection<Book> Books
        {
            get { return books; }
            set
            {
                if (books != value)
                {
                    books = value;
                    OnPropertyChanged(nameof(Books));
                }
            }
        }

        public BooksViewModel()
        {
            Books = new ObservableCollection<Book>(ListBooks._books);
        }

        public void FilterBooks()
        {
            var filteredBooks = ListBooks._books
                .Where(book => book.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase))
                .ToList();
            Books = new ObservableCollection<Book>(filteredBooks);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}

