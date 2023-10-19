using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint1.Task3.V1.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpress()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 2;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(25.133, res);
        }
    }
}
