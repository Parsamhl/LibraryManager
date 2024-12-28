using App.Domain.Core.Library.Category.Entities;
using App.Domain.Core.Library.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Library.Book.Entitis
{
    public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorsName { get; set; }
        public int PageNumbers { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int UserId { get; set; }
        public bool IsAvailabel {  get; set; }

        public DateTime PublishedDate { get; set; }

        public App.Domain.Core.Library.User.Entities.User UserBorrowed { get; set; }
        public App.Domain.Core.Library.Category.Entities.Category Category { get; set; }
    }
}
