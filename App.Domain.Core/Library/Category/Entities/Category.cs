

namespace App.Domain.Core.Library.Category.Entities
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<App.Domain.Core.Library.Book.Entitis.Book> Books { get; set; }

    }
}
