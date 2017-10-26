
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kata_babysitter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BabySitterPaidForOneHourBeforeBedtime1()
        {
            BabySitter babySitter = new BabySitter(5, 6, 10);
            Assert.AreEqual(1, babySitter.calculateHoursBeforeBedtime());
        }
    }
}