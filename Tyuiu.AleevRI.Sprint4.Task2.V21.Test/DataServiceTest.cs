using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AleevRI.Sprint4.Task2.V21.Lib;

namespace Tyuiu.AleevRI.Sprint4.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 5, 4, 3, 5, 5, 2, 6, 3, 4, 5, 6, 2, 4, 5 };

            int res = ds.Calculate(numsArray);
            int wait = 9216;

            Assert.AreEqual(wait, res);
        }
    }
}
