using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Theme Theme { get; set; }
        public Author Author { get; set; }

        public Book() { }
        public Book(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
