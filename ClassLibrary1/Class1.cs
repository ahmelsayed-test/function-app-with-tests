using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary1
{
    public class Class1
    {
        [Fact]
        public void Test()
        {
            FunctionApp27.Function1.Run(null, null).Wait();
        }
    }
}
