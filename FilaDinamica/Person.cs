using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class Person
    {
        string name;        
        Person? next;

        public Person(string name)
        {
            this.name = name;
            this.next = null;
        }

        public void setNext(Person next)
        {
            this.next= next;
        }
        public Person? getNext()
        {
            return this.next;
        }

        public string getName()
        {
            return this.name;
        }

        public void printName()
        {
            Console.WriteLine($"\nNome: {this.name}");
        }
    }
}
