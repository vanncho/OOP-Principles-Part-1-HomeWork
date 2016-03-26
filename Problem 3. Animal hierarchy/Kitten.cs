namespace Problem_3.Animal_hierarchy
{
    public class Kitten : Cat, ISound
    {
        public Kitten(int age, string name)
            : base(age, name)
        {
            this.Sex = Sex.female;
        }

        public new string SpecificSound()
        {
            return base.SpecificSound();
        }
    }
}
