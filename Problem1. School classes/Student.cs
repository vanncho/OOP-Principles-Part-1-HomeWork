namespace Problem1.School_classes
{
    public class Student : People, IPeople
    {
        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, string comment, int classNumber)
            : base(name, comment)
        {
            this.Comment = comment;
            this.ClassNumber = classNumber;
        }

        public new string Comment { get; set; }
        public int ClassNumber { get; private set; }
    }
}
