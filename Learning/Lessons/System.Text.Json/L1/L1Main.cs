using Learning.Lessons.System.Text.Json.L1.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Learning.Lessons.System.Text.Json.L1
{
    public class L1Main
    {
        /// <summary>
        /// .NET 8 feature
        /// The json converted string will print all of the properties related 
        /// to its parent interface as well
        /// </summary>
        public static void Execute()
        {
            //create object from employee
            IEmployee employee = new Employee("Test", "test@test.com", "P1")
            {
                Age = 20
            };
            //conver the object to json string
            string json = JsonSerializer.Serialize(employee);

            //print on console
            Console.WriteLine("Lesson 1 {0}", json);
            /*
             * {"Position":"P1","Name":"Test","Email":"test@test.com"}
             */
        }
    }
}
