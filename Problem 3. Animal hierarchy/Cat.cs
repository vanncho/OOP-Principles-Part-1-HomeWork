namespace Problem_3.Animal_hierarchy
{
    public class Cat : Animal, IAnimal
    {
        public Cat(int age, string name)
            : base(age, name)
        {
        }

        public Cat(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public override string SpecificSound()
        {
            return "Miauuu...";
        }
    }
}
