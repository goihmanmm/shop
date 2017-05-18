using System;
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

        private string size;

        public string Size
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

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }



        public clothes(string type, string size, string color, int price, int quantity)
        {
            this.type = type;
            this.size = size;
            this.color = color;

            this.price = price;
            this.quantity = quantity;
        }

        public static void read()
        {
            BD.Clear();

            string[] line = File.ReadAllLines("bd.txt", Encoding.GetEncoding(1251));
            for (int i = 0; i < line.Length; i++)
            {
                string[] mas = line[i].Split(' ');
                clothes element = new clothes(mas[0], (mas[1]), (mas[2]), int.Parse(mas[3]), int.Parse(mas[4]));
                BD.Add(element);
            }


        }
        public string show()
        {
            return String.Format("Название изделия {0} Размер {1} Цвет {2} Цена {3} Количество {4}", type, size, color, price, quantity);

        }

        public static List<clothes> get()
        {
            return BD;
        }


        public static List<clothes> FSE = new List<clothes>();

        public static void search(string t, string p, string c, string s)
        {
            FSE.Clear();
            List<clothes> SE = new List<clothes>();

            SE = BD;
            foreach (clothes element in SE)
           {
                if ((element.type == t || t == "0") & (element.price == int.Parse(p) || p == "0") & (element.color == c || c == "0") & (element.size == (s) || s == "0"))
                {
                    FSE.Add(element);
                }
            }
        }
        public static List<clothes> getsearch()
        {
            return FSE;
        }



        public void add()
        {
            clothes.read();
            bool c = false;

           for (int i = 0; i < 1; i++)
            {



                foreach (clothes element in BD)
                {
                    if (element.type == type & element.size == size & element.color == color & element.price == price)
                    {
                        foreach (clothes e in BD)
                        {

                            if ((e.type!= type) || (e.size != size) || ( e.color != color) || (e.price != price))
                            {

                                using (FileStream fs = new FileStream("bd.txt", FileMode.Create))

                                {
                                    using (StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                                    {
                                        sw.WriteLine(string.Format("{0} {1} {2} {3} {4}", e.type, e.size, e.color, e.price, e.quantity));
                                    }
                                    fs.Close();
                                };


                            }
                        }

                        using (FileStream fs = new FileStream("bd.txt", FileMode.Append))

                        {
                            using (StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                            {
                                sw.WriteLine(string.Format("{0} {1} {2} {3} {4}", type, size, color, price, quantity+element.quantity));
                            }
                            fs.Close();
                        };

                        c = true;
                        break;
                    }
                    
                }
                if (c == true)
                    break;

                using (FileStream fs = new FileStream("bd.txt", FileMode.Append))

                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                    {
                        sw.WriteLine(string.Format("{0} {1} {2} {3} {4}", type, size, color, price, quantity));
                    }
                    fs.Close();
                };

            }





        }

     
        public void delete()
        {
            clothes.read();



            foreach ( clothes element in BD)
            {
                if ((element.type != this.type) || (element.size != this.size) || (element.color != this.color) || (element.price != this.price))
                {
                    using (FileStream fs = new FileStream("bd.txt", FileMode.Create))
                        fs.Close();
                }
            }


            foreach (clothes e in BD)
            {

                if ((e.type != this.type) || (e.size != this.size) || (e.color !=this.color) || (e.price != this.price))
                {

                    using (FileStream fs = new FileStream("bd.txt", FileMode.Append))

                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                        {
                            sw.WriteLine(string.Format("{0} {1} {2} {3} {4}", e.type, e.size, e.color, e.price, e.quantity));
                        }
                        fs.Close();
                    };


                }
           }

            foreach (clothes e in BD)
            {
                if ((e.type == this.type) && (e.size == this.size) && (e.color == this.color) && (e.price == this.price) && (e.quantity - this.quantity >0))

                {
                    using (FileStream fs = new FileStream("bd.txt", FileMode.Append))

                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                        {
                            sw.WriteLine(string.Format("{0} {1} {2} {3} {4}", e.type, e.size, e.color, e.price, e.quantity - this.quantity));
                            sw.Close();
                        }


                        fs.Close();
                    };
                }






            }


        }
        

    }

    }
