using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_class
{   class Person
    {
        string name;
        public string name1;

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
    }
    class Apt
    {
        private string aptname;
        private string aptcolor;

       public Apt()
        {
            aptname = "삼성";
            aptcolor = "red";
        }
        public Apt(string aptname, string aptcolor)
        {
            this.aptname = aptname; 
            this.aptcolor = aptcolor;
        }

        public string Aptname
        {
            get { return aptname; }
        }
        public string Aptcolor
        {
            get { return aptcolor; }
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Apt apt = new Apt();
            Apt apt2 = new Apt("LG", "yellow");
           
        }
    }
}
