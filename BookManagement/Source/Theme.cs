using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Theme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Book> Books { get; private set; } = new List<Book>();

        public Theme()
        {

        }
        public Theme(string name)
        {
            Name = name;
        }
    }
}
