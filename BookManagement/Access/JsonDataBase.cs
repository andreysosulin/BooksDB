using Newtonsoft.Json;
using Source;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class JsonDataBase
    {
        const string _autorsfile = "../../../author.json";
        const string _booksfile = "../../../book.json";
        const string _themesfile = "../../../theme.json";

        public List<Theme> Themes { get; set; } = new List<Theme>();
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Author> Authors { get; set; } = new List<Author>();

        Context context = Context.Instance;

        public JsonDataBase()
        {

        }

        public void SaveAll()
        {
            
                Themes = context.Themes.Include("Books").ToList();
                Books = context.Books.Include("Theme").Include("Author").ToList();
                Authors = context.Authors.Include("Books").ToList();

            Save(_booksfile, Books);
            Save(_autorsfile, Authors);
            Save(_themesfile, Themes);
            
        }

        private void Save<T>(string file, List<T> list)
        {
            
            using (var sw = new StreamWriter(file))
            {
                using (var writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Newtonsoft.Json.Formatting.Indented;

                    var serializer = new JsonSerializer();
                    serializer.Serialize(writer, list);
                }
            }
        }

        public void ReadAll()
        {
            Themes = ReadData<Theme>(_themesfile);
            Authors = ReadData<Author>(_autorsfile);
            Books = ReadData<Book>(_booksfile);

        }

        private List<T> ReadData<T>(string filename)
        {
            using (var sr = new StreamReader(filename))
            {
                using (var reader = new JsonTextReader(sr))
                {
                    var serializer = new JsonSerializer();

                    return serializer.Deserialize<List<T>>(reader);
                }
            }
        }

    }
}
