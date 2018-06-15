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
    
    public partial class RegistrationWindow : Window
    {
        RepositoryUser repoUser;
        public RegistrationWindow()
        {
            InitializeComponent();
            repoUser = RepositoryUser.Instance;
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            if (regLogin.Text != "" && regPswd.Text != "")
            {
                repoUser.Add(new User(regLogin.Text, regPswd.Text));
                new MainWindow().Show();
                this.Close();
            }
            else
                MessageBox.Show("Поля логин и пароль должны быть заполнены");

        }
    }
}
