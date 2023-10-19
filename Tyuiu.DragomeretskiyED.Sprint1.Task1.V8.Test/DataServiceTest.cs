using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint1.Task1.V8.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint1.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServiceTest ds = new DataServiceTest();
            double a = 1;
            double x = 2;
            var res = ds.Calculate(a, x);
            Assert.AreEqual(6.28, res);

        }
    }
}
