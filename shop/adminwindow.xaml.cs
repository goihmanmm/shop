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

namespace shop
{
    
    public partial class adminwindow : Window
    {
        public adminwindow()
        {
            InitializeComponent();
        }

       

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            logger.log("adminwindow вывести");
            clothes.read();
            main.Items.Clear();
            List<clothes> BD = new List<clothes>();

            BD = clothes.get();
            foreach (clothes element in BD)
            {
                main.Items.Add(element.show());
            } 
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {


            logger.log("adminwindow поиск");
            clothes.read();
            

            string t, p, c, s;
            t = type.Text;
            p = price.Text;
            c = color.Text;
            s = size.Text;


            clothes.search(t, p, c, s);

            main.Items.Clear();
            List<clothes> BD = new List<clothes>();
            BD = clothes.getsearch();
            foreach (clothes element in BD)
            {
                main.Items.Add(element.show());
            }

        }

        

        private void add_Click(object sender, RoutedEventArgs e)
        {

            logger.log("adminwindow добавить");


            clothes element = new clothes(type2.Text, size2.Text, color2.Text, int.Parse(price2.Text), int.Parse(quantity2.Text));
            element.add();


        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {


            logger.log("adminwindow удалить");
            clothes element = new clothes(type2.Text, size2.Text, color2.Text, int.Parse(price2.Text), int.Parse(quantity2.Text));
            element.delete();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {


            logger.log("adminwindow очистить");
            main.Items.Clear();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {


            logger.log("adminwindow сменить пользователя");
            MainWindow a = new MainWindow();
            a.Show();
            Close();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {

            logger.log("adminwindow очистить программу");
            Clear a = new Clear();
            a.Show();
        }
    }
}
