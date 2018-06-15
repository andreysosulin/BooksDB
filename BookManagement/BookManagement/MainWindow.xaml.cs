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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Access;

namespace BookManagement
{

    public partial class MainWindow : Window
    {
        RepositoryUser repoUser;
        RepositoryTheme repoTheme;
        RepositoryAuthor repoAuthor;
        RepositoryBook repoBook;
        public MainWindow()
        {
            InitializeComponent();
            repoUser = RepositoryUser.Instance;
            repoTheme = RepositoryTheme.Instance;
            repoAuthor = RepositoryAuthor.Instance;
            repoBook = RepositoryBook.Instance;
            repoUser.LoadData();
            repoTheme.LoadData();
            repoAuthor.LoadData();
            repoBook.LoadData();

            
            
        }

        private void authEnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (repoUser.Authorisation(authLogin.Text, authPassword.Text))
            {
                new ManagementWindow().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь с такими данными не найден");
            }
        }

        private void authRegButton_Click(object sender, RoutedEventArgs e)
        {
            
            new RegistrationWindow().Show();
            this.Close();
        }
    }
}
