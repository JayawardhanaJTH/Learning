using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Learning.Lessons.System.Text.Json.L2
{
    public class L2Main
    {
        public record Person(string FirstName, string LastName);

        /// <summary>
        /// .NET 8 Feature
        /// Convert the snake case json properties to the given policy
        /// (snake case -> lower)
        /// </summary>
        public static void Execute()
        {
            var json = """
                {
                    "first_name":"Test",
                    "last_name":"Test Last"
                }
                """;

            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
            };

            var person = JsonSerializer.Deserialize<Person>(json, jsonOptions);

            //print on console
            Console.WriteLine("Lesson 2 {0}", person);
            /*
             *  Person { FirstName = Test, LastName = Test Last }
             */
        }
    }
}
