using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Person
    {
        private int id;
        private string name;
        private int age;
        public static int count;
        
        public Person()
        {
            id = 1;
            name = string.Empty;
            age = 18;
            count++;
        }
        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            count++;
        }
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }

        public int Count { get { return count; } }
        ~Person()
        {
            count--;
        }
        public override string ToString()
        {
            return "Name "+name + " Id:" + id+" Age:"+age ;
        }
    }

}
