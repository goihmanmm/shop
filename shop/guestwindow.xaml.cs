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
    /// <summary>
    /// Логика взаимодействия для guestwindow.xaml
    /// </summary>
    public partial class guestwindow : Window
    {
        public guestwindow()
        {
            InitializeComponent();
        }

     

        private void button_Click(object sender, RoutedEventArgs e)
        {
            clothes.read();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

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
            clothes.read();
            //show a = new show();
            //a.Show();

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

        //private void button3_Click(object sender, RoutedEventArgs e)
        //{

        //    main.Items.Clear();
        //    List<clothes> BD = new List<clothes>();
        //    BD = clothes.getsearch();
        //    foreach (clothes element in BD)
        //    {
        //        main.Items.Add(element.show());
        //    }

        //}
    }
}
