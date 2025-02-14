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
        int MouseFlag = 0;
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if(LoginTb.Text == "Введите имя пользователя")
            {
                LoginTb.Text = String.Empty;
            }            
        }

        private void LoginTb_MouseLeave(object sender, MouseEventArgs e)
        {
               if (LoginTb.Text == String.Empty)
            {
                LoginTb.Text = "Введите имя пользователя";
            }
        }

   
    }
}
