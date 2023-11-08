using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AleevRI.Sprint4.Task6.V18.Lib;

namespace Tyuiu.AleevRI.Sprint4.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var week = new string[] { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };
            var res = ds.Calculate(week);
            string[] wait = { "Попугай", "Черепаха" }; 
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
