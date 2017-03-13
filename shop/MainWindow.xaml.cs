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

namespace shop
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "admin" && textBox1.Text == "1234")
            {
               
                adminwindow a = new adminwindow();
                a.Show();
                Close();
            }

            if (textBox.Text == "guest")
            {
                guestwindow a = new guestwindow();
                a.Show();
                Close();
            }
        }
    }
}
