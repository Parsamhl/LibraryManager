using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Library.Category.Dtos
{
    public class CategoryDto
    {

        public string Name { get; set; }
        public List<App.Domain.Core.Library.Book.Entitis.Book> Books { get; set; }

    }
}
