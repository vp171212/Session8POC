using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisDemo
{
    class Employee
    {
        private int _id;
        private string _name;
        private string _email;

        public Employee(int _id,string _name,string _email) 
        { 
            this._id = _id;
            this._name = _name;
            this._email = _email;
        }
        public void printEmployee()
        { System.Console.WriteLine("Id: {0}\nName: {1}\nEmail: {2}",this._id,this._name,this._email); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(10,"Ravi","ravi@gmail.com");
            employee1.printEmployee();
        }
    }
}
