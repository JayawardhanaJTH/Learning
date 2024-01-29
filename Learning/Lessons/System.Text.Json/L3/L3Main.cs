using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Learning.Lessons.System.Text.Json.L3
{
    public class L3Main
    {
        /// <summary>
        /// This will throw an exception because the Name property is not a member of
        /// Person class and the policy is setted to Disallow
        /// First pirority to policy under class definition
        /// Second pirority to json policy options
        /// </summary>
        public static void Execute()
        {
            var json = """
                {
                    "Id": 1,
                    "Name": "Test"
                }
                """;

            var jsonOptions = new JsonSerializerOptions
            {
                UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow
            };

            try
            {
                var person = JsonSerializer.Deserialize<Person>(json, jsonOptions);
            }
            catch (Exception e)
            {

            }
            /*
             * System.Text.Json.JsonException: 
             * 'The JSON property 'Name' could not be mapped to any .NET member contained in type 
             * 'Learning.Lessons.System.Text.Json.L3.Person'.'
             */
        }
    }

    [JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
    public class Person
    {
        public int Id { get; set; }
    }
}