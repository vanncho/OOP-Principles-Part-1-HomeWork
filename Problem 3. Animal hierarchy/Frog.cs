namespace Problem_3.Animal_hierarchy
{
    public class Frog : Animal, IAnimal
    {
        public Frog(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public override string SpecificSound()
        {
            return "Miauuu...";
        }
    }
}
