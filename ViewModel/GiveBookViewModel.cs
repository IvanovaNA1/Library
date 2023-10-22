using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Event;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class GiveBookViewModel
    {
        private List<string> users;
        public List<string> Users
        {
            get { return users; }
            set { users = value; }
        }
        private List<string> books;
        public List<string> Books
        {
            get { return books; }
            set { books = value; }
        }
        private string selectedUser;
        public string SelectedUser
        {
            get { return selectedUser; }
            set { selectedUser = value; }
        }
        private string selectedBook;
        public string SelectedBook
        {
            get { return selectedBook; }
            set { selectedBook = value; }
        }

        public GiveBookViewModel()
        {
            users = new List<string>();
            books = new List<string>();

            foreach (var item in ListUsers._users)
            {
                users.Add($"{item.Name} {item.Family}");
            }

            foreach (var item in ListBooks._books)
            {
                books.Add(item.Name);
            }

            GrantBookCommand = new RelayCommand(GrantBook);
        }
        public ICommand GrantBookCommand { get; private set; }
        private void GrantBook()
        {
            Book selectedBookObject = ListBooks._books.FirstOrDefault(book => book.Name == selectedBook);

            if (selectedUser != null && selectedBook != null)
            {
                if (selectedBookObject.Count > 0)
                {
                    selectedBookObject.Count--;
                    MessageBox.Show($"Книга '{selectedBook}' успешно выдана пользователю '{selectedUser}'.");
                }
                else
                {
                    MessageBox.Show("Выбранной книги нет в наличии.");
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя и книгу.");
            }
        }

        private bool CanGrantBook(object parameter)
        {
            return !string.IsNullOrEmpty(selectedUser) && !string.IsNullOrEmpty(selectedBook);
        }

    }
}
