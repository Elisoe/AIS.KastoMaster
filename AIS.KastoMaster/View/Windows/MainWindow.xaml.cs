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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HistoryOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderHistoryWindow orderHistoryWindow = new OrderHistoryWindow();   
            orderHistoryWindow.Show();
            this.Close();
        }

        private void ActiveOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            ActiveOrderWindow activeOrderWindow = new ActiveOrderWindow();
            activeOrderWindow.Show();
            this.Close();
        }
    }
}
