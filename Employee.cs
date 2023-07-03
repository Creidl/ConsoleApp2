using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int Score { get; private set; }

        public Employee(string firstName = "Zombie", string lastName = "XXXXX", int age = 18)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Score = 0;
        }

        public void AddScore(int p)
        {
            Score += p;
        }
    }
}
