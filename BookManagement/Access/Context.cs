using Source;
using System;
using System.Data.Entity;

namespace Access
{
    public class Context : DbContext
    {
        public static Context Instance { get; } = new Context();


        private Context() : base("BookDB")
        {
            Database.SetInitializer<Context>(new Access.Initializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        

        public class Initializer : CreateDatabaseIfNotExists<Context>
        {
            protected override void Seed(Context context)
            {

                JsonDataBase _repo = new JsonDataBase();

                _repo.ReadAll();

                foreach (var author in _repo.Authors)
                {
                    context.Authors.Add(author);


                    context.SaveChanges();
                }

                foreach (var book in _repo.Books)
                {
                    context.Books.Add(book);


                    context.SaveChanges();
                }

                foreach (var theme in _repo.Themes)
                {
                    context.Themes.Add(theme);


                    context.SaveChanges();
                }


            }
        }

    }
}
