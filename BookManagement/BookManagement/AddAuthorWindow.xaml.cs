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
    
    public partial class AddAuthorWindow : Window
    {
        ManagementWindow mw;
        public AddAuthorWindow(ManagementWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void buttonAddAuthor_Click(object sender, RoutedEventArgs e)
        {
            if (addAuthorName.Text != "")
            {
                Access.RepositoryAuthor.Instance.Add(new Source.Author(addAuthorName.Text));
                mw.LoadAuthors();
                this.Close();
            }
            else
            {
                MessageBox.Show("Инициалы автора должны быть заполнены");
            }
        }
    }
}
