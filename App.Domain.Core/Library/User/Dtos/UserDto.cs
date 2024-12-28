using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Library.User.Dtos
{
    public class UserDto
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public List<App.Domain.Core.Library.Book.Entitis.Book> BorrowedBooks { get; set; }
    }
}
