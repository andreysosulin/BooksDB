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
namespace BookManagement
{
    
    public partial class AddThemeWindow : Window
    {
        ManagementWindow mw;
        public AddThemeWindow(ManagementWindow mw)
        {
            InitializeComponent();
            this.mw = mw;

            
        }
        


        private void buttonAddTheme_Click(object sender, RoutedEventArgs e)
        {
            if (addThemeName.Text != "")
            {
                RepositoryTheme.Instance.Add(new Source.Theme(addThemeName.Text));
                mw.LoadThemes();
                this.Close();
            }
            else
                MessageBox.Show("Название темы должно быть заполнено");
        }
    }
}
