using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Lessons.System.Text.Json.L1.Contracts
{
    public interface IEmployee : IPerson
    {
        public string Position { get; }
    }
}
