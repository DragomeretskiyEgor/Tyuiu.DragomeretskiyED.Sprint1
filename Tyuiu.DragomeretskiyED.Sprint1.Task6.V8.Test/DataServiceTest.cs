using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint1.Task6.V8.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string srt = "Пирожок";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(srt);
            string wait = "Кирожоп";
            Assert.AreEqual(wait, res);
        }
    }
}
