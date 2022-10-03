using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project;

namespace project
{
    internal class Client
    {
        private int age;
        public string name;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Данное значение недопустимо");
                }
            }

        }


    }
}
