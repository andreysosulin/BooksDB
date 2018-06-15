using Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class RepositoryTheme : IRepository<Theme>
    {
        public List<Theme> Items { get; private set; } = new List<Theme>();
        Context context = Context.Instance;
        public static RepositoryTheme Instance { get; set; } = new RepositoryTheme();
        private RepositoryTheme() { }
        public void Add(Theme t)
        {
            context.Themes.Add(t);
            Items.Add(t);
            context.SaveChanges();
        }

        public void LoadData()
        {
            foreach(Theme val in context.Themes)
            {
                Items.Add(val);
            }
        }

        public void Change(string themeName, Book book)
        {
            var themeContext = context.Themes.Where(t => t.Name == themeName);
            foreach (Theme val in themeContext)
            {
                val.Books.Add(book);
            }
            context.SaveChanges();

        }


    }
}
