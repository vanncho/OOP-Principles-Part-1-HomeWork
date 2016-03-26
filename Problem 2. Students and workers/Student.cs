namespace Problem_2.Students_and_workers
{
    public class Student : Human, IHuman
    {
        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
        public int Grade { get; private set; }
        public override int MoneyPerHour()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + this.Grade;
        }
    }
}
