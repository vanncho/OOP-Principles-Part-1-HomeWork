namespace Problem1.School_classes
{
    using System.Collections.Generic;

    public class Teacher : People, IPeople
    {
        public Teacher(string name, List<Discipline> teaches)
            : base(name)
        {
            this.Teaches = new List<Discipline>();
        }

        public List<Discipline> Teaches { get; private set; }
    }
}
