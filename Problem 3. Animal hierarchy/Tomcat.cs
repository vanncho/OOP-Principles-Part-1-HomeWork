namespace Problem_3.Animal_hierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name)
            : base(age, name)
        {
            this.Sex = Sex.male;
        }

        public override string SpecificSound()
        {
            return base.SpecificSound();
        }
    }
}
