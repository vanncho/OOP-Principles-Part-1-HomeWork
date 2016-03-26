namespace Problem_3.Animal_hierarchy
{
    public class Dog : Animal, IAnimal
    {
        public Dog(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public override string SpecificSound()
        {
            return "Miauuu...";
        }
    }
}
