
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kata_babysitter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BabySitterCreditedForOneHourBeforeBedtime()
        {
            BabySitter babySitter = new BabySitter(5, 6, 10);
            Assert.AreEqual(1, babySitter.calculateHoursBeforeBedtime());
        }

        [TestMethod]
        public void BabySitterCreditedForOneHourAfterBedtimeBeforeMidnight()
        {
            BabySitter babySitter = new BabySitter(11, 12, 10);
            Assert.AreEqual(1, babySitter.calculateHoursAfterBedtimeBeforeMidnight());
        }

        [TestMethod]
        public void BabySitterCreditedForOneHourAfterMidnight()
        {
            BabySitter babySitter = new BabySitter(11, 13, 10);
            Assert.AreEqual(1, babySitter.calculateHoursAfterMidnight());
        }

        [TestMethod]
        public void BabySitterCreditedForOneFullNight()
        {
            BabySitter babySitter = new BabySitter(5, 16, 10);
            Assert.AreEqual(5, babySitter.calculateHoursBeforeBedtime());
            Assert.AreEqual(2, babySitter.calculateHoursAfterBedtimeBeforeMidnight());
            Assert.AreEqual(4, babySitter.calculateHoursAfterMidnight());
        }

        [TestMethod]
        public void BabySitterPaidForOneHourBeforeBedtime()
        {
            BabySitter babySitter = new BabySitter(5, 6, 10);
            Assert.AreEqual(12, babySitter.getBeforeBedtimePay());
        }

        [TestMethod]
        public void BabySitterPaidForOneHourAfterBedtimeBeforeMidnight()
        {
            BabySitter babySitter = new BabySitter(11, 12, 10);
            Assert.AreEqual(8, babySitter.getAfterBedtimeBeforeMidnightPay());
        }

        [TestMethod]
        public void BabySitterPaidForOneHourAfterMidnight()
        {
            BabySitter babySitter = new BabySitter(11, 13, 10);
            Assert.AreEqual(16, babySitter.getAfterMidnightPay());
        }
    }
}