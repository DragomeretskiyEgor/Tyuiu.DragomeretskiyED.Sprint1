﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint1.Task7.V6.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = -214.628;
            Assert.AreEqual(wait, res);
        }
    }
}
