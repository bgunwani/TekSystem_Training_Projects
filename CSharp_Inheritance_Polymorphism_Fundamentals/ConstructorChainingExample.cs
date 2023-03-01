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
        public Person()
        {
            this.name = "Sarah Bowling";
            this.age = 23;
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
        public Employee()
        {
            this.designation = "Manager";
            this.salary = 50000;
        }
        public new void show()
        {
            base.show();
            Console.WriteLine("Designation: {0}, Salary: {1}", this.designation, this.salary);
        }
    }

    class ConstructorChainingExample
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.show();
        }
    }
}
