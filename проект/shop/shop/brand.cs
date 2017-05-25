using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace shop
{
    [Serializable]
   
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
        public Brand() { }

        public static void  read()
            
            {
            
            
            BD.Clear();

            
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("brands.dat", FileMode.OpenOrCreate))
            {
              BD  = (List<Brand>)formatter.Deserialize(fs);

                
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
            
            BinaryFormatter formatter = new BinaryFormatter();
            Brand adding = new Brand(this.name, this.adress,  this.email);
            BD.Add(adding);
            using (FileStream fs = new FileStream("brands.dat", FileMode.Create))
            {
                
                formatter.Serialize(fs, BD);
                


            }


        }

        public static void delete(string name, string adress, string email)
        {

            Brand.read();
         
            
            foreach ( Brand element in BD.ToArray())
            {
                if (name == element.name && adress == element.adress && email == element.email)
                {
                    BD.Remove(element);
                }
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("brands.dat", FileMode.Create))
            {
               
                formatter.Serialize(fs, BD);
               


            }







        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
