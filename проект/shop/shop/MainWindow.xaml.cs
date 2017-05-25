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
      
        public MainWindow()
        {
            InitializeComponent();

            using (FileStream fs = new FileStream("logger.txt", FileMode.Create))

            { fs.Close(); }
        }



        private void button_Click(object sender, RoutedEventArgs e)

        {
            try
            {


                logger.log("sign in");

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
            catch { MessageBox.Show("Проверьте правильность введенных данных. Возможно, остались незаполненные поля", "что-то пошло не так!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try { 
          

            logger.log("sign up");



            string[] line = File.ReadAllLines("log.txt", Encoding.GetEncoding(1251));
                string pas = passwordBox.Password;
                string log = textBox.Text;
             
                if (line.Count() == 0&& !String.IsNullOrWhiteSpace(textBox.Text) && !String.IsNullOrWhiteSpace(passwordBox.Password))
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
            else if((String.IsNullOrWhiteSpace(log)||(String.IsNullOrWhiteSpace(pas))))
                {
                    MessageBox.Show("Проверьте правильность введенных данных. Возможно, остались незаполненные поля", "что-то пошло не так!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            else

            {

                MessageBox.Show("Введите логин и пароль для авторизации и нажмите login", "Вы уже авторизированы", MessageBoxButton.OK);

            }

            }
            catch { MessageBox.Show("Проверьте правильность введенных данных. Возможно, остались незаполненные поля", "что-то пошло не так!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

    


        private void sign_in_MouseLeave(object sender, MouseEventArgs e)
        {
            sign_in.FontSize = 18;
        }

        private void sign_in_MouseEnter_1(object sender, MouseEventArgs e)
        {
            sign_in.FontSize = 24;
        }

        private void sign_up_MouseEnter(object sender, MouseEventArgs e)
        {
            sign_up.FontSize = 24;
        }

        private void sign_up_MouseLeave(object sender, MouseEventArgs e)
        {
            sign_up.FontSize = 18;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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
