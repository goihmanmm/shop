﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    class clothes
    {

        public static List<clothes> BD = new List<clothes>();
        
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private char size;

        public char Size
        {
            get { return size; }
            set { size = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }


        public clothes(string type, char size, string color, int price)
        {
            this.type = type;
            this.size = size;
            this.color = color;
            
            this.price = price; 
        }

        public void read()
        {
          
            string[] line = File.ReadAllLines("C:\\Users\\миша\\Desktop\\вышка\\программирование\\проект\\shop\\bd.txt", Encoding.GetEncoding(1251));
            for (int i = 0; i < line.Length; i++)
            {
                string[] mas = line[i].Split(' ');
                clothes element = new clothes(mas[0], char.Parse(mas[1]), (mas[2]), int.Parse(mas[3]));
                BD.Add(element);
            }


        }
        public string show()
        {
            return String.Format("Название изделия {0} Размер {1} Цвет {2} Цена {3}",type, size, color, price);
            
        }

        public List<clothes> get()
        {
            return BD;
        }


        public static List<clothes> FSE = new List<clothes>();

        public void search(string t, string p, string c, string s)
        {
            FSE.Clear();
            List<clothes> SE = new List<clothes>();
           
            SE = BD;
            foreach (clothes element in SE)
            {
                if ((element.type == t || t == "0") & (element.price == int.Parse(p) || p == "0") & (element.color == c || c == "0") & (element.size == char.Parse(s) || s == "0"))
                {
                    FSE.Add(element);
                }
            }
        }
        public List<clothes> getsearch()
        {
            return FSE;
        }
    

    }
}
