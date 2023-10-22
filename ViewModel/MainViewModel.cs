using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1.Event;
using WpfApp1.View;

namespace WpfApp1.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Frame _contentFrame;
        public MainViewModel(Frame contentFrame)
        {
            CloseCommand = new RelayCommand(Close);
            ToggleWindowStateCommand = new RelayCommand(ToggleWindowState);
            NavigateToBooksCommand = new RelayCommand(NavigateToBooks);
            _contentFrame = contentFrame;
            NavigateToUsersCommand = new RelayCommand(NavigateToUsers);
            NavigateToGiveBookCommand = new RelayCommand(NavigateToGiveBook);
        }

        public ICommand CloseCommand { get; set; }
        private void Close()
        {
            App.Current.Shutdown();
        }

        public ICommand ToggleWindowStateCommand { get; set; }
        private bool isMaximized = false;
        public bool IsMaximized
        {
            get { return isMaximized; }
            set
            {
                isMaximized = value;
                OnPropertyChanged("IsMaximized");
            }
        }
        private void ToggleWindowState()
        {
            IsMaximized = !IsMaximized;
        }

        private object currentPage;
        public object CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }

        public ICommand NavigateToBooksCommand { get; private set; }
        private void NavigateToBooks()
        {
            _contentFrame.Content = new Books();
        }

        public ICommand NavigateToUsersCommand { get; private set; }
        private void NavigateToUsers()
        {
            _contentFrame.Content = new Users();
        }

        public ICommand NavigateToGiveBookCommand { get; private set; }
        private void NavigateToGiveBook()
        {
            _contentFrame.Content = new GiveBook();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
