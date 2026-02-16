namespace Assignment6_Part1;

internal class Person
{
    private int Id;
    public string Name;

    public Person(int Id, string name)
    {
        this.Id = Id;
        Name = name;
    }
    public Person(int Id) : this(Id, "Unknown") { }

    public Person() : this(1) { }

    public int PrintPrivateId()
    {
        return Id;
    }
    public string PrintPublicName()
    {
        return Name;
    }

    public void PrintPerson()
    {
        Console.WriteLine($"Id = {Id}, name = {Name}");
    }
}
