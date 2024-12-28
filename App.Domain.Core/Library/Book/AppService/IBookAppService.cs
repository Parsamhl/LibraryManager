using App.Domain.Core.Library.Book.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Library.Book.AppService
{
    public interface IBookAppService
    {
        List<BookDto> GetAllBooks();


    }
}
