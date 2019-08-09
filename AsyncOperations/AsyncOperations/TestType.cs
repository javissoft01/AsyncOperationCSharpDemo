using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncOperations
{
    public class TestType
    {
        public int IntegerValue;
        public string StringValue;

        public override string ToString()
        {
            return "{int: " + IntegerValue + " str: " + StringValue + "}";
        }
    }
}
