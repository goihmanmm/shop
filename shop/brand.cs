using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    class Brand
    {
        static  List<Brand> BD = new List<Brand>();
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Brand(string name, string adress, string email)
        {
            this.name = name;
            this.adress = adress;
            this.email = email;

        }

        public static void  read()
            
            {
            BD.Clear();

            string[] line = File.ReadAllLines("brand.txt", Encoding.GetEncoding(1251));
            for (int i = 0; i < line.Length; i++)
            {
                string[] mas = line[i].Split('|');
                Brand element = new Brand(mas[0], (mas[1]), (mas[2]));
                BD.Add(element);
            }
        }

        public string show()
        {
          
            return String.Format("Название компании: {0} Адрес: {1} Email: {2}", name, adress, email);

        }

        public static List<Brand> get()
        {
            return BD;
        }

        public static List<Brand> FSE = new List<Brand>();

        public static List<Brand> search(string n)
        {
            Brand.read();
            FSE.Clear();
                    
            foreach (Brand element in BD)
            {
                if (element.name==n)
                {
                    FSE.Add(element);
                }
            }
            return FSE;
        }

        public void add()
        {

            using (FileStream fs = new FileStream("brand.txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                {
                    sw.WriteLine(this.name+"|"+this.adress+"|"+this.email);
                    sw.Close();
                }
                fs.Close();
            }


        }

        public static void delete(string name, string adress, string email)
        {

            Brand.read();

            using (FileStream fs = new FileStream("brand.txt", FileMode.Create))
                
                {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                {

                    foreach (Brand element in BD)
                    {
                        if (name!=element.name || adress!=element.adress || email!=element.email)
                        {
                            sw.WriteLine(String.Format("{0}|{1}|{2}",element.name, element.adress,element.email));
                        }
                    }
                    sw.Close();
                };
                fs.Close();
            };
                   
                
            

        }
    }
}
