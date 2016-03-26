namespace Problem1.School_classes
{
    using System;

    public class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }

        public People(string name, string comment)
        {
            this.Name = name;
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public string Comment { get; set; }
    }
}
