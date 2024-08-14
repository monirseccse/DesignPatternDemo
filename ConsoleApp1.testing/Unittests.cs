using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleApp1.testing
{
    public class Unittests
    {
        [Fact]
        public void TestDivide_Result()
        {
            decimal result = Logics.Divide(10,2);
            Assert.Equal(5, result);
        }
    }
}
