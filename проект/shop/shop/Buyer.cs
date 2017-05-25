using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    
    class Buyer
    {
        static public List<Buyer> Buyers = new List<Buyer>();


        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        private List<clothes> buys = new List<clothes>();

        public List<clothes> Buys 
        {
            get { return buys; }
            set { buys = value; }
        }



        public Buyer(string name)
        {
            this.name = name;
        }
        public Buyer()
        {

        }
        public void buy(clothes cloth)
        {
            buys.Add(cloth);

        }
        public static Buyer renew()
        {
            Buyer n = new Buyer();
            return n;

        }
        
       
        public static void read()
        {

            Buyers.Clear();
            FileStream fs = new FileStream("buyers.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(1251));
            int i = 0;
            Buyer buyer = new Buyer();
            while (!sr.EndOfStream)
            {

                string line = sr.ReadLine();
                if (line == "***")
                {
                    Buyers.Add(buyer);
                    i = 0;
                    buyer = Buyer.renew();
                

                }
                else if (i == 0)
                {
                    buyer.Name = line;
                    i++;
                }
                else
                {
                    string[] mas = line.Split(' ');
                    clothes cloth = new clothes(mas[5], mas[4], mas[1], mas[0], int.Parse(mas[2]), int.Parse(mas[3]));
                    buyer.buy(cloth);
                }
            }


            sr.Close();
            fs.Close();



        }

        public static List<Buyer> get()
        {
            Buyer.read();
            return Buyers;
        }

        public string show()
        {
            return String.Format("Имя: {0}", this.name);

        }

       
    }



}
