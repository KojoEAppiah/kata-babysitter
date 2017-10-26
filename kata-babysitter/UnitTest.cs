
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kata_babysitter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BabySitterPaidForOneHourBeforeBedtime()
        {
            BabySitter babySitter = new BabySitter(5, 6, 10);
            Assert.AreEqual(1, babySitter.calculateHoursBeforeBedtime());
        }

        [TestMethod]
        public void BabySitterPaidForOneHourAfterBedtimeBeforeMidnight()
        {
            BabySitter babySitter = new BabySitter(11, 12, 10);
            Assert.AreEqual(1, babySitter.calculateHoursAfterBedtimeBeforeMidnight());
        }
    }
}