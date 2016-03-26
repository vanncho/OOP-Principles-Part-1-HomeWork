namespace Problem_2.Students_and_workers
{
    public class Worker : Human, IHuman
    {
        public Worker(string firstName, string lastName, int weekSalary)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
        }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : this(firstName, lastName, weekSalary)
        {
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }
        public override int MoneyPerHour()
        {
            return (this.WeekSalary / this.WorkHoursPerDay) / 5;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + "money per hour: " + this.MoneyPerHour();
        }
    }
}
