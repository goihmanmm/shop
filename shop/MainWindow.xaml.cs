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
using System.Data;
using System.Data.SqlClient;

namespace shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conn;
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

        private async void button5_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\миша\Desktop\вышка\программирование\проект\shop\shop\Database1.mdf;Integrated Security=True";
            conn = new SqlConnection(connectionString);

            await conn.OpenAsync();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Product](type, size)VALUES(@type, @size)",conn);
            cmd.Parameters.Add("@type", SqlDbType.NVarChar, 50).Value = "Свитшот";
            cmd.Parameters.Add("@size", SqlDbType.NVarChar, 50).Value = "XL";

            await cmd.ExecuteNonQueryAsync();
            conn.Close();
        }
    }
}
