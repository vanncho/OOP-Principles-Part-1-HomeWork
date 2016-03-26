namespace Problem1.School_classes
{
    public class Discipline : People, IPeople
    {
        public Discipline(string name, int numberOfLectures, int numberOfExcercises)
            : base(name)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
        }

        public Discipline(string name, string comment, int numberOfLectures, int numberOfExcercises)
            : base(name, comment)
        {
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
        }

        public new string Comment { get; set; }
        public int NumberOfLectures { get; private set; }
        public int NumberOfExcercises { get; private set; }
    }
}
