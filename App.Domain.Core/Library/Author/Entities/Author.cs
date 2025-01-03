﻿using App.Domain.Core.Library.Book.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Library.Author.Entities
{
    public class Author 
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public List<App.Domain.Core.Library.Book.Entitis.Book> booksWritten { get; set; }
    }
}
