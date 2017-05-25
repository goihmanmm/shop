using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для brand.xaml
    /// </summary>
    public partial class brand : Window
    {
        public brand()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            logger.log("brand вывести");
            Brand.read();
            main.Items.Clear();
            List<Brand> BD = new List<Brand>();

            BD = Brand.get();
            foreach (Brand element in BD)
            {
                main.Items.Add(element.show());
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            logger.log("brand добавить");

            try { 
            if (!String.IsNullOrWhiteSpace(addname.Text) && !String.IsNullOrWhiteSpace(addadress.Text) && !String.IsNullOrWhiteSpace(addname.Text))
                {
                    Brand element = new Brand(addname.Text, addadress.Text, addemail.Text);
                    element.add();
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
          }catch { MessageBox.Show("Убедитесь, что все поля заполнены", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        };

    }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.log("brand поиск");
                if (!String.IsNullOrWhiteSpace(searchbr.Text))
                {
                    Brand.read();

                    List<Brand> BD = new List<Brand>();
                    string s;
                    s = searchbr.Text;



                    BD = Brand.search(s);

                    Search.Items.Clear();
                    foreach (Brand element in BD)


                    {
                        Search.Items.Add(element.show());
                    }
                }else
                {
                    MessageBox.Show("Заполните поле", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch { MessageBox.Show("Убедитесь, что все поля заполнены", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error); };
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {if (!String.IsNullOrWhiteSpace(delname.Text) && !String.IsNullOrWhiteSpace(deladress.Text) && !String.IsNullOrWhiteSpace(delemail.Text))
                {
                    logger.log("brand удалить");
                    Brand.delete(delname.Text, deladress.Text, delemail.Text);
                }
            }
            catch { MessageBox.Show("Убедитесь, что все поля заполнены", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error); };
        }
    }
}
