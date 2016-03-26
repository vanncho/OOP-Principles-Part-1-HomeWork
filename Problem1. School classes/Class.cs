namespace Problem1.School_classes
{
    using System.Collections.Generic;

    public class Class : People, IPeople
    {
        public Class(string comment, string textIdentifier, List<Teacher> listOfTeachers, List<Student> listOfStudents)
            : base(comment)
        {
            this.TextIdentifier = textIdentifier;
            this.ListOfTeachers = new List<Teacher>();
            this.ListOfStudents = new List<Student>();
        }

        public new string Comment { get; set; }
        public string TextIdentifier { get; private set; }
        public List<Teacher> ListOfTeachers { get; private set; }
        public List<Student> ListOfStudents { get; private set; }
    }
}
