using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Library.Author.Dtos
{
    public class IAuthorDto
    {
        public string FullName { get; set; }
        public List<App.Domain.Core.Library.Book.Entitis.Book> booksWritten { get; set; }

    }
}
