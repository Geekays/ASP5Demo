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
        [InlineData(100)]
        public void CtoFTestCheck(int value)
        {
            string f= _ctrl.Get(value);
            Assert.True(f == "212");
        }
    }
}
