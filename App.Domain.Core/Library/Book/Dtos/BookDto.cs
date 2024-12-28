using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Library.Book.Dtos
{
    public class BookDto
    {

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public int PageNumber { get; set; }

        public DateTime PublishDate { get; set; }

    }
}
