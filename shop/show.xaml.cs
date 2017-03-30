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
    /// Логика взаимодействия для show.xaml
    /// </summary>
    public partial class show : Window
    {
        public show()
        {
            InitializeComponent();
        }

      
        private void button_Click(object sender, RoutedEventArgs e)
        {
            clothes element = new clothes("x", 'm', "red", 1);
         

            string t, p, c, s;
            t = type.Text;
            p = price.Text;
            c = color.Text;
            s = size.Text;

            
            element.search(t,p,c,s);
            Close();
        }
    }
}
