using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.SprintReview1.TaskReview.V10.Lib;

namespace Tyuiu.KozhevnikovDG.SprintReview1.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 150;
            var res = ds.Calculate(x);
            Assert.AreEqual(2.173, res);
        }
    }
}
