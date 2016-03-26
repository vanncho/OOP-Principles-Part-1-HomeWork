namespace Problem_2.Students_and_workers
{
    using System;

    public abstract class Human : IHuman
    {
        private string firstName;
        private string lastName;

        public Human (string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name length cannot be less than two characters");
                }
                this.firstName = value; 
            }
        }

        public string LastName 
        {
            get { return this.lastName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Last name length cannot be less than two characters");
                }
                this.lastName = value; 
            } 
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        public abstract int MoneyPerHour();
    }
}
