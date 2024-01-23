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

namespace CrFebruaryBelousov
{
    /// <summary>
    /// Логика взаимодействия для Delete_Account.xaml
    /// </summary>
    public partial class Delete_Account : Window
    {
        public Delete_Account()
        {
            InitializeComponent();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Dovolen dovolen = new Dovolen();
            dovolen.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
