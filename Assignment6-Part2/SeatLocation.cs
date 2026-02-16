namespace Assignment6_Part2;

public struct SeatLocation
{
    readonly char Row;
    readonly int Number;

    public SeatLocation(char row, int number)
    {
        Number = number;
        Row = Char.ToUpper(row);
    }

    public string PrintLocation()
    {
        return $"{Row}{Number}";
    }
}
