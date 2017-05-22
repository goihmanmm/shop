﻿using System;
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
    /// Логика взаимодействия для Clear.xaml
    /// </summary>
    public partial class Clear : Window
    {
        public Clear()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            logger.log("adminwindow удалить всё");
            FileStream fs = new FileStream("bd.txt", FileMode.Create);
            fs.Close();
            FileStream fk = new FileStream("log.txt", FileMode.Create);
            fk.Close();
        }
    }
}
