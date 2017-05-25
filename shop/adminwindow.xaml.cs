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
using System.IO;
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
            try
            {
                logger.log("adminwindow вывести");
                clothes.read();
                main.Items.Clear();
                List<clothes> BD = new List<clothes>();

                BD = clothes.get();
                logger.log("adminwindow вывести метод get");
                foreach (clothes element in BD)
                {
                    main.Items.Add(element.show());
                }
                logger.log("adminwindow вывод осущетсвлен");
            }
            catch { MessageBox.Show("Возможно, повредился файл, попробуйте выполнить сброс программы", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error); logger.log("adminwindow вывести ошибка"); }
        }



    private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                logger.log("adminwindow поиск");
                clothes.read();


                string t, p, c, s, b;
                t = type.Text;
                p = price.Text;
                c = color.Text;
                s = size.Text;
                b = bname.Text;


                clothes.search(t, p, c, s, b);
                logger.log("adminwindow поиск метод search");

                main.Items.Clear();
                List<clothes> BD = new List<clothes>();
                BD = clothes.getsearch();
                logger.log("adminwindow поиск метод getsearch");
                foreach (clothes element in BD)
                {
                    main.Items.Add(element.show());
                }
                logger.log("adminwindow поиск выход из цикла");
            }
            catch { MessageBox.Show("Убедитесь в правильности введенных данных. Цена должна быть целочисленной", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error); logger.log("adminwindow поиск ошибка"); };


        }



        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.log("adminwindow добавить");


                clothes element = new clothes(type2.Text, size2.Text, color2.Text, bname2.Text, int.Parse(price2.Text), int.Parse(quantity2.Text));
                element.add();
                logger.log("adminwindow добавить метод add");
                clothes.read();
                logger.log("adminwindow добавить метод read");
                main.Items.Clear();
                List<clothes> BD = new List<clothes>();


                BD = clothes.get();
                logger.log("adminwindow добавить метод get");
                foreach (clothes elem in BD)
                {
                    main.Items.Add(elem.show());
                }
            }
            catch { MessageBox.Show("Убедитесь в правильности введенных данных.", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error); logger.log("adminwindow добавить ошибка"); };


        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                logger.log("adminwindow удалить");
                clothes element = new clothes(type2.Text, size2.Text, color2.Text, bname2.Text, int.Parse(price2.Text), int.Parse(quantity2.Text));
                element.delete();
                logger.log("adminwindow удалить метод delete");
                clothes.read();
                logger.log("adminwindow удалить метод read");
                main.Items.Clear();
                List<clothes> BD = new List<clothes>();

                BD = clothes.get();
                logger.log("adminwindow удалить метод dget");
                foreach (clothes elemen in BD)
                {
                    main.Items.Add(elemen.show());
                }
            }catch { MessageBox.Show("Убедитесь в правильности введенных данных.", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                logger.log("adminwindow удалить ошибка");
            };
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

        private void brand_Click(object sender, RoutedEventArgs e)
        {
            brand b = new brand();
            b.Show();
        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.log("adminwindow купить");


                List<Buyer> Buyers = new List<Buyer>();
                List<clothes> cheking = new List<clothes>();
                Buyers = Buyer.get();
                logger.log("adminwindow купить метод clothes.get");
                cheking = clothes.get();
                logger.log("adminwindow купить метод get");

                clothes.buy(type3.Text, size3.Text, color3.Text, bname3.Text, int.Parse(price3.Text), int.Parse(quantity3.Text));
                string name = username.Text;
                bool i = false;
                foreach (clothes el in cheking)
                {
                    if (el.Type == type3.Text && el.Size == size3.Text && el.Color == color3.Text && el.Bname == bname3.Text && el.Price == int.Parse(price3.Text) && el.Quantity >= int.Parse(quantity3.Text))
                    {
                        i = true;
                        logger.log("adminwindow купить if1");
                    }
                }

                if (i == true)
                {
                    bool ok = false;
                    logger.log("adminwindow купить if2");
                    foreach (Buyer element in Buyers)
                    {
                        if (element.Name == name)
                        {
                            ok = true;
                            logger.log("adminwindow купить if3");
                            element.buy(new clothes(type3.Text, size3.Text, color3.Text, bname3.Text, int.Parse(price3.Text), int.Parse(quantity3.Text)));
                        }
                    }
                    if (ok == false)
                    {
                        logger.log("adminwindow купить if4");
                        Buyer buyer = new Buyer(name);
                        clothes c = new clothes(type3.Text, size3.Text, color3.Text, bname3.Text, int.Parse(price3.Text), int.Parse(quantity3.Text));
                        buyer.buy(c);
                        Buyers.Add(buyer);
                    }
                    FileStream fs = new FileStream("buyers.txt", FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1251));
                    foreach (Buyer buyer in Buyers)
                    {
                        sw.WriteLine(buyer.Name);
                        foreach (clothes cloth in buyer.Buys)
                        {
                            sw.WriteLine(String.Format("{0} {1} {2} {3} {4} {5}", cloth.Bname, cloth.Color, cloth.Price, cloth.Quantity, cloth.Size, cloth.Type));
                        }
                        sw.WriteLine("***");
                    }
                    sw.Close();
                    fs.Close();
                }
                clothes.read();
                main.Items.Clear();
                List<clothes> BD = new List<clothes>();

                BD = clothes.get();
                foreach (clothes elementus in BD)
                {
                    main.Items.Add(elementus.show());
                }
                logger.log("adminwindow купить вывод остатка");
            }
            catch { MessageBox.Show("Убедитесь в правильности введенных данных.", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        };
    }

        private void buyers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                logger.log("adminwindow вывести базу данных клиентов");
                Buyer.read(); logger.log("adminwindow вывести базу данных метод read");
                buyerslook.Items.Clear();
                List<Buyer> BDclients = new List<Buyer>();

                BDclients = Buyer.get(); logger.log("adminwindow вывести базу данных метод get");
                foreach (Buyer element in BDclients)
                {
                    buyerslook.Items.Add(element.show());
                    foreach (clothes item in element.Buys)
                    {
                        buyerslook.Items.Add(item.show());
                    }
                }
                logger.log("adminwindow вывести базу данных dsdjl");
            }
            catch { MessageBox.Show("Возможно, программа повреждена,попробуйте выполнить сброс программы", "ошибка!", MessageBoxButton.OK, MessageBoxImage.Error); };


        }

       
    }
}
