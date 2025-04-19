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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace AIS.KastoMaster.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
       
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginTb_MouseEnter(object sender, MouseEventArgs e)
        {
            if (LoginTb.Text == "Имя пользователя")
            {
                LoginTb.Text = String.Empty;
            }
        }

        private void LoginTb_MouseLeave(object sender, MouseEventArgs e)
        {
            if (LoginTb.Text == String.Empty)
            {
                LoginTb.Text = "Имя пользователя";
            }
        }

        private void AuthorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
