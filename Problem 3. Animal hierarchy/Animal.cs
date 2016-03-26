namespace Problem_3.Animal_hierarchy
{
    using System;

    public abstract class Animal : IAnimal, ISound
    {
        private int age;
        private string name;
        private Sex sex;

        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public Animal(int age, string name, Sex sex)
            : this(age, name)
        {
            this.Sex = sex;
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < 0 || value > 30)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 30");
                }

                this.age = value;
            }
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

        public Sex Sex
        {
            get
            {
                return this.sex;
            }

            protected set
            {
                this.sex = value;
            }
        }

        public abstract string SpecificSound();
    }
}
