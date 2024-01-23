using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Threading;

namespace CrFebruaryBelousov
{
    public partial class Klient : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private ObservableCollection<Order> order;
        public Klient()
        {
            InitializeComponent();
            DateTime newdate = new DateTime(2023, 03, 13);
            order = new ObservableCollection<Order>
            {
                new Order { Id = 1, Status = "Готов", NumberBox = 1, DateCreate = newdate},
                new Order { Id = 2, Status = "Не готов", NumberBox = 2, DateCreate = newdate },
                new Order { Id = 3, Status = "Готов", NumberBox = 3, DateCreate = newdate }
            };
            listOrders.ItemsSource = order;
        }
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Zakaz zakaz = new Zakaz();
            zakaz.Show();
            this.Close();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
