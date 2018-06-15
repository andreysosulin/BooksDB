
using Source;
using Access;
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

namespace BookManagement
{
    
    public partial class ManagementWindow : Window
    {
        
        public ManagementWindow()
        {
            InitializeComponent();
            LoadThemes();
            LoadAuthors();
            
        }

        public void LoadThemes()
        {
            comboThemes.Items.Clear();
            List<Theme> themes = RepositoryTheme.Instance.Items;
            foreach (Theme val in themes)
            {
                comboThemes.Items.Add(val.Name);
            }
        }

        public void LoadAuthors()
        {
            comboAuthors.Items.Clear();
            List<Author> authors = RepositoryAuthor.Instance.Items;
            foreach (Author val in authors)
            {
                comboAuthors.Items.Add(val.Name);
            }
        }

        
        private void comboThemes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboThemes.SelectedItem != null)
            {
                textBoxInfo.Clear();
                int flag = 0;
                var themes = RepositoryTheme.Instance.Items.Where(t => t.Name == comboThemes.SelectedValue.ToString());
                foreach (Theme theme in themes)
                {
                    foreach (Book book in theme.Books)
                    {
                        textBoxInfo.AppendText(book.Name + "\n");
                        textBoxInfo.AppendText(book.Description + "\n\n\n");
                        flag = 1;
                    }
                }
                if (flag == 0)
                    MessageBox.Show("Книг с такой темой не найдено");
                comboAuthors.SelectedItem = null;
            }

        }
        
        private void comboAuthors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboAuthors.SelectedItem != null)
            {
                textBoxInfo.Clear();
                int flag = 0;
                var authors = RepositoryAuthor.Instance.Items.Where(t => t.Name == comboAuthors.SelectedValue.ToString());
                foreach (Author author in authors)
                {
                    foreach (Book book in author.Books)
                    {
                        textBoxInfo.AppendText(book.Name + "\n");
                        textBoxInfo.AppendText(book.Description + "\n\n\n");
                        flag = 1;
                    }
                }
                if (flag == 0)
                    MessageBox.Show("Книг с таким автором не найдено");
                comboThemes.SelectedItem = null;
            }
            
        }

        private void btnAddTheme_Click(object sender, RoutedEventArgs e)
        {
            new AddThemeWindow(this).Show();
            
        }

        private void btnAddAuthor_Click(object sender, RoutedEventArgs e)
        {
            new AddAuthorWindow(this).Show();
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            new AddBookWindow().Show();
        }

        
    }
}
