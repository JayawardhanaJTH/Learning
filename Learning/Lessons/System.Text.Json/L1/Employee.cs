using Learning.Lessons.System.Text.Json.L1.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Lessons.System.Text.Json.L1
{
    public class Employee(string name, string email, string position) : IEmployee
    {
        public string Position => position;
        public string Name => name;
        public string Email => email;

        public int Age { get; set; }
    }
}
