using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.View;

namespace WpfApp1.Model
{
    public static class ListUsers 
    { 
        public static List<User> _users = new List<User>();
        static ListUsers()
        {
            _users.Add(new User()
            {
                Id = 1, Name = "Анна", Family = "Иванова"
            });
            _users.Add(new User()
            {
                Id = 2, Name = "Елизавета", Family = "Петрова"
            });
            _users.Add(new User()
            {
                Id = 3, Name = "Александр", Family = "Михайлов"
            });
            _users.Add(new User()
            {
                Id = 4, Name = "Иван", Family = "Волков"
            });

        }
    }
}
