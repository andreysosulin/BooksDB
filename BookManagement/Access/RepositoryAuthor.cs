using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class RepositoryAuthor : IRepository<Author>
    {
        public List<Author> Items { get; private set; } = new List<Author>();
        Context context = Context.Instance;
        public static RepositoryAuthor Instance { get; set; } = new RepositoryAuthor();
        private RepositoryAuthor() { }
        public void LoadData()
        {
            foreach (Author val in context.Authors)
            {
                Items.Add(val);
            }
        }


        public void Add(Author t)
        {
            
            context.Authors.Add(t);
            Items.Add(t);
            context.SaveChanges();
        }

        public void Change(string authorName, Book book)
        {
            var authorContext = context.Authors.Where(t => t.Name == authorName);
            foreach(Author val in authorContext)
            {
                val.Books.Add(book);
            }
            context.SaveChanges();

        }

    }
}
