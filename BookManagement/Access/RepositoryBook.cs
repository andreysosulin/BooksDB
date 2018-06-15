using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source;
namespace Access
{
    public class RepositoryBook : IRepository<Book>
    {
        public List<Book> Items { get; private set; } = new List<Book>();
        Context context = Context.Instance;
        public static RepositoryBook Instance { get; set; } = new RepositoryBook();
        private RepositoryBook() { }
        public void Add(Book t)
        {
            context.Books.Add(t);
            Items.Add(t);
            context.SaveChanges();
        }

        public void LoadData()
        {
            foreach (Book val in context.Books)
            {
                Items.Add(val);
            }
        }
    }
}
