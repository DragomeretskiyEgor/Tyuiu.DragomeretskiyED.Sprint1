using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint1.Task2.V9.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint1.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpress()
        {
            DataService ds = new DataService();
            int r = 2;
            var res = ds.CalculateVolumeCircle(r);
            Assert.AreEqual(3, res);
        }
    }
}
