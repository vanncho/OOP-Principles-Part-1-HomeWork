namespace Problem_2.Students_and_workers
{
    public interface IHuman
    {
        string FirstName { get; }
        string LastName { get; }
        int MoneyPerHour();
    }
}
