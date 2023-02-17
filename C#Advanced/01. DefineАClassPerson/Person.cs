using System;
using System.Collections.Generic;
using System.Text;

namespace _01._DefineАClassPerson
{
    class Person
    {
        private string name;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
