using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Access;
using Source;
namespace BookManagement
{
    
    public partial class AddBookWindow : Window
    {
        RepositoryAuthor repoAuthor = RepositoryAuthor.Instance;
        RepositoryTheme repoTheme = RepositoryTheme.Instance;
        RepositoryBook repoBook = RepositoryBook.Instance;
        
        public AddBookWindow()
        {
            InitializeComponent();
            
            foreach(Author val in repoAuthor.Items)
            {
                comboAuthor.Items.Add(val.Name);
            }
            foreach (Theme val in repoTheme.Items)
            {
                comboThemes.Items.Add(val.Name);
            }
        }

        

        private void buttonAddBook_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxBookName.Text != "" && textBoxDescr.Text != ""
                && comboAuthor.SelectedItem != null && comboThemes.SelectedItem != null)
            {
                Book book = new Book(textBoxBookName.Text, textBoxDescr.Text);
                repoBook.Add(book);
                repoAuthor.Change(comboAuthor.SelectedItem.ToString(), book);
                repoTheme.Change(comboThemes.SelectedItem.ToString(), book);
                this.Close();
            }
            else
                MessageBox.Show("Должны быть выбраны или заполнены:\n" +
                    "Тема\n" +
                    "Автор\n" +
                    "Название книги\n" +
                    "Описание книги");
        }
    }
}
