using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint1.Task7.V21.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 13.377;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
