public class Person
{
    public readonly string Name;
    public int Turns { get; set; }
    public readonly bool InfiniteTurns;

    internal Person(string name, int turns)
    {
        Name = name;
        Turns = turns;
        InfiniteTurns = turns <= 0;
    }

    public override string ToString()
    {
        return InfiniteTurns ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}