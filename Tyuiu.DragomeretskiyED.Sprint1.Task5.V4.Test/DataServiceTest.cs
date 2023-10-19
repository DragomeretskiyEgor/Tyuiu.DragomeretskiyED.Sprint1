using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint1.Task5.V4.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpress()
        {
            int time = 3;
            DataService ds = new DataService();
            double res = ds.SecondsToHours(time);

            int result = Convert.ToInt32(res);

            int wait = 13257;
            Assert.AreEqual(wait, result);
        }
    }
}
