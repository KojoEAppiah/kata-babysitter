﻿namespace kata_babysitter
{
    internal class BabySitter
    {
        private int arrival_time;
        private int departure_time;
        private int hours_before_bedtime;
        private int bedtime;

        private int rate_before_bedtime;
        private int rate_after_bedtime_before_midnight;
        private int rate_after_midnight;

        public BabySitter(int arrival, int departure, int bedtime)
        {
            this.arrival_time = arrival;
            this.departure_time = departure;
            this.bedtime = bedtime;

            this.rate_before_bedtime = 12;
            this.rate_after_bedtime_before_midnight = 8;
            this.rate_after_midnight = 16;
    }

        public int calculateHoursBeforeBedtime()
        {
            if (this.departure_time <= this.bedtime)
                return this.departure_time - this.arrival_time;
            else
                return this.bedtime - this.arrival_time;
        }

        public int calculateHoursAfterBedtimeBeforeMidnight()
        {
            if (this.departure_time > 12)
                return 12 - (this.arrival_time > this.bedtime ? this.arrival_time : this.bedtime);
            else
                return this.departure_time - (this.arrival_time > this.bedtime ? this.arrival_time : this.bedtime);
        }

        public int calculateHoursAfterMidnight()
        {
            if (this.departure_time <= 12)
                return 0;
            else
            {
                return this.departure_time - 12;
            }
        }

        public int getBeforeBedtimePay()
        {
            return this.rate_before_bedtime * this.calculateHoursBeforeBedtime();
        }

        public int getAfterBedtimeBeforeMidnightPay()
        {
            return this.rate_after_bedtime_before_midnight * this.calculateHoursAfterBedtimeBeforeMidnight();
        }

        public int getAfterMidnightPay()
        {
            return this.rate_after_midnight * this.calculateHoursAfterMidnight();
        }

        public int calculateNightsPay()
        {
            return this.getBeforeBedtimePay() + this.getAfterBedtimeBeforeMidnightPay() + getAfterMidnightPay();
        }
    }
}