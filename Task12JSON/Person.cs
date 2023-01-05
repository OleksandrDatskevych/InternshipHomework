using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task12JSON
{
    internal class Person
    {
        public int age;
        public string? name;

        public Person(int age, string? name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
