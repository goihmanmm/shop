using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop
{
    class clothes
    {

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

        public clothes(string type, char size, string color, int count)
        {
            this.type = type;
            this.size = size;
            this.color = color;
            this.count = count;
        } 

    }
}
