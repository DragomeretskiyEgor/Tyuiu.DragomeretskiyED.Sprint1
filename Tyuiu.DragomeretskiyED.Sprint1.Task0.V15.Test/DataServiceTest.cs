using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint1.Task0.V15.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint1.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServiceTest ds = new DataServiceTest();
            var res = ds.Calculate();
            Assert.AreEqual(24, res);
        }
    }
}
}
