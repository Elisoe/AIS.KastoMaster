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

namespace AIS.KastoMaster.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для NewOrderClientInfo.xaml
    /// </summary>
    public partial class NewOrderClientInfo : Window
    {
        public NewOrderClientInfo()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (ClientName.Text == String.Empty && ClientPhone.Text == String.Empty)
            {
                MessageBox.Show("Ошибка. Введите имя клиента и его номер телефона");
            }
            else if (ClientName.Text == String.Empty)
            {
                MessageBox.Show("Ошибка. Введите имя клиента");
            }
            else if (ClientPhone.Text == String.Empty)
            {
                MessageBox.Show("Ошибка. Введите номер телефона клиента");
            }         
            else
            {
                NewOrderChoiceOfClothes newOrderChoiceOfClothes = new NewOrderChoiceOfClothes();
                newOrderChoiceOfClothes.Show();
                this.Close();
            }
        }
                
        

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
