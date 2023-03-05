using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inheritance_Polymorphism_Fundamentals
{
    class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void show()
        {
            Console.WriteLine("Name: {0}, Age: {1}", this.name, this.age);
        }
    }

    class Employee : Person
    {
        private string designation;
        private float salary;
        public Employee(string name, int age, string designation, float salary): base(name, age)
        {
            this.designation = designation;
            this.salary = salary;
        }
        public new void show()
        {
            base.show();
            Console.WriteLine("Designation: {0}, Salary: {1}", this.designation, this.salary);
        }
    }

    class ParameterizedConstructorChainingExample
    {
        static void Main(string[] args)
        {
            Employee emp2 = new Employee("Karthik", 32, "Developer", 70000);
            emp2.show();

        }
    }
}
