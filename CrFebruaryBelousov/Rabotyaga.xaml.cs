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

namespace CrFebruaryBelousov
{
    /// <summary>
    /// Логика взаимодействия для Rabotyaga.xaml
    /// </summary>
    public partial class Rabotyaga : Window
    {
        private ObservableCollection<Order> order;
        private int countOrders = 0;

        public Rabotyaga()
        {
            InitializeComponent();

            DateTime newdate = new DateTime(2023, 03, 13);
            order = new ObservableCollection<Order>
            {
                new Order { Id = 1, Status = "Не готов", NumberBox = 1, DateCreate = newdate },
                new Order { Id = 2, Status = "Не готов", NumberBox = 2, DateCreate = newdate },
                new Order { Id = 3, Status = "Не готов", NumberBox = 3, DateCreate = newdate }
            };
            listOrders.ItemsSource = order;
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                var orderItem = checkBox.DataContext as Order;
                if (orderItem != null)
                {
                    countOrders += 1;
                    order.Remove(orderItem);
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void buttonStartSmena_Click(object sender, RoutedEventArgs e)
        {
            stackpanelOrders.Visibility = Visibility.Visible;
        }

        private void EndChangeBtn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Статистика за день: " + "\nВыполнено заказов: " + countOrders + "\nВыручка за день: 2500 р.");

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}


