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
    /// Логика взаимодействия для adminwindow.xaml
    /// </summary>
    public partial class adminwindow : Window
    {
        public adminwindow()
        {
            InitializeComponent();
        }

        clothes element = new clothes("x", 'm', "red", 1);

        private void button_Click(object sender, RoutedEventArgs e)
        {
            element.read();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            main.Items.Clear();
            List<clothes> BD = new List<clothes>();

            BD = element.get();
            foreach (clothes element in BD)
            {
                main.Items.Add(element.show());
            } 
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            show a = new show();
            a.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            List<clothes> BD = new List<clothes>();
            BD=element.getsearch();
            foreach (clothes element in BD)
            {
               main.Items.Add(element.show());
            }
            
        }
    }
}
