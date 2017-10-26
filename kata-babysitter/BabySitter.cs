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
            {
                return this.bedtime - this.arrival_time;
            }
        }
    }
}