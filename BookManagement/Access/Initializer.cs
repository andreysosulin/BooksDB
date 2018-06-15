using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Source;
namespace Access
{
    class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        

        protected override void Seed(Context context)
        {

            RepositoryUser.Instance.Add(new User("admin", "admin"));
            JsonDataBase db = new JsonDataBase();
            db.ReadAll();
            foreach(Author val in db.Authors)
            {
                RepositoryAuthor.Instance.Add(val);
            }
            foreach (Theme val in db.Themes)
            {
                RepositoryTheme.Instance.Add(val);
            }
            foreach (Book val in db.Books)
            {
                RepositoryBook.Instance.Add(val);
            }

            base.Seed(context);
        }
    }
}
