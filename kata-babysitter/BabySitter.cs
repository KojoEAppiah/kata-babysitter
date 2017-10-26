namespace kata_babysitter
{
    internal class BabySitter
    {
        private int arrival_time;
        private int departure_time;
        private int hours_before_bedtime;
        private int bedtime;

        public BabySitter(int arrival, int departure, int bedtime)
        {
            this.arrival_time = arrival;
            this.departure_time = departure;
            this.bedtime = bedtime;
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
            return 12 * calculateHoursBeforeBedtime();
        }

        public int getAfterBedtimeBeforeMidnightPay()
        {
            return 8 * calculateHoursAfterBedtimeBeforeMidnight();
        }

    }
}