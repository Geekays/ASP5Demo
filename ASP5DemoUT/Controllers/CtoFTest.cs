using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using ASP5Demo.Controllers;


namespace ASP5DemoUT
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class CtoFTest
    {
        private readonly ASP5Demo.Controllers.CtoFController _ctrl;

        public CtoFTest()
        {
            _ctrl = new CtoFController();
        }

        [Theory]
        [InlineData(0, 32)]
        [InlineData(100, 212)]
        public void CtoFTestCheckForTrue(int value, int result)
        {
            string f= _ctrl.Get(value);
            Assert.True(f == result.ToString());
        }

        [Fact]
        public void CtoFTestCheckForFalse()
        {
            int value = 100;
            int result = 0;
            string f = _ctrl.Get(value);
            Assert.False(f == result.ToString());
        }
    }
}
