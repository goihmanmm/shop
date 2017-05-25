using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    class logger
    {

        public static void log(string mes)
        {
            using (FileStream fs = new FileStream("logger.txt", FileMode.Append))

            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                {
                    sw.WriteLine(string.Format("{0} - {1}", DateTime.Now, mes));
                }
                fs.Close();
            };
        }

    }
}
