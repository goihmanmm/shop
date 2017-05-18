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
using System.Security.Cryptography;
using System.IO;

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

            if (textBox.Text == "guest")
            {
                guestwindow a = new guestwindow();
                a.Show();
                Close();

            }
            else
            {


                string[] line = File.ReadAllLines("log.txt", Encoding.GetEncoding(1251));


                if (line.Count() == 0)
                {
                    MessageBox.Show("Введите логин и пароль для авторизации", "Вы вошли в первый раз", MessageBoxButton.OK);

                }
                else
                {

                    string[] mas = line[0].Split(' ');

                    string password = Log.comparing(passwordBox.Password);

                    if (textBox.Text == mas[0] && mas[1] == password)
                    {



                        adminwindow a = new adminwindow();
                        a.Show();
                        Close();
                    }
                    else MessageBox.Show("Попробуйте еще раз!", "Вы ввели неверный  логин или пароль", MessageBoxButton.OK);
                }


            }
            }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string[] line = File.ReadAllLines("log.txt", Encoding.GetEncoding(1251));
            if (line.Count() == 0)
            {

                string password = Log.comparing(passwordBox.Password);
                using (FileStream fs = new FileStream("log.txt", FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                    {
                        sw.WriteLine(textBox.Text + " " + password);
                    }
                }
                MessageBox.Show("Вы зарегистрировались", "Ура!", MessageBoxButton.OK);
            }
            else

            {

                MessageBox.Show("Введите логин и пароль для авторизации и нажмите login", "Вы уже авторизированы", MessageBoxButton.OK);

            }
        

        }

        //private async void button5_Click(object sender, RoutedEventArgs e)
        //{
        //    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\миша\Desktop\вышка\программирование\проект\shop\shop\Database1.mdf;Integrated Security=True";
        //    conn = new SqlConnection(connectionString);

        //    await conn.OpenAsync();

        //    SqlCommand cmd = new SqlCommand("INSERT INTO [Product](type, size)VALUES(@type, @size)",conn);
        //    cmd.Parameters.Add("@type", SqlDbType.NVarChar, 50).Value = "Свитшот";
        //    cmd.Parameters.Add("@size", SqlDbType.NVarChar, 50).Value = "XL";

        //    await cmd.ExecuteNonQueryAsync();
        //    conn.Close();
        //}
    
    }
}
