namespace Problem_3.Animal_hierarchy
{
    public interface IAnimal
    {
        int Age { get; }

        string Name { get; }

        string SpecificSound();
    }
}
