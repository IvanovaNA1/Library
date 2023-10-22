using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.View;

namespace WpfApp1.Model
{
    public static class ListBooks
    {
        public static List<Book> _books = new List<Book>();

        static ListBooks()
        {
            _books.Add(new Book()
            {
                Arc = 1, Name = "Властелин Колец", Age = 1998, Count = 3
            });
            _books.Add(new Book()
            {
                Arc = 2,Name = "1984",Age = 1949,Count = 2
            });
            _books.Add(new Book()
            {
                Arc = 3,Name = "Убийство в «Восточном экспрессе»",Age = 1934,Count = 5
            });
            _books.Add(new Book()
            {
                Arc = 4,Name = "Тёмная сторона",Age = 1997,Count = 1
            });
            _books.Add(new Book()
            {
                Arc = 5,Name = "Бегущий за ветром",Age = 2003,Count = 4
            });
            _books.Add(new Book()
            {
                Arc = 6,Name = "Битва королей",Age = 1998,Count = 3
            });

        }
    }
}
