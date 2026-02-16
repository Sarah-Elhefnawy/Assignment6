namespace Assignment6_Part2;

public class Ticket
{
    public string MovieName;
    public TicketType Type;
    public SeatLocation Location;
    private double Price;

    private readonly int SeatLocationNumber;
    private readonly char SeatLocationRow;

    public Ticket(string MovieName, TicketType Type, int SeatLocationNumber, char SeatLocationRow, double Price)
    {
        Location = new SeatLocation(SeatLocationRow, SeatLocationNumber);
        this.MovieName = MovieName;
        this.Type = Type;
        this.Price = Price;
    }

    public Ticket(string name) : this(name, TicketType.Standard, 1, 'A', 50.00) { }

    public double CalcTotal(double taxPercent)
    {
        return Price + (Price * taxPercent);
    }

    public void PrintTicket()
    {
        Console.WriteLine("==== Ticket Info ====");
        Console.WriteLine($"Movie    : {MovieName}");
        Console.WriteLine($"Type     : {Type}");
        Console.WriteLine($"Seat     : {Location.PrintLocation()}");
        Console.WriteLine($"Price    : {Price}");
        Console.WriteLine($"Total (14% tax)   : {CalcTotal(0.14)}");
    }

    public void ApplyDiscount(double discountAmount)
    {
        Console.WriteLine("==== After Discount ====");
        Console.WriteLine($"Discount Before : {discountAmount}");
        if (discountAmount > 0 && discountAmount <= Price)
        {
            Price -= discountAmount;
            discountAmount = 0;
        }
        Console.WriteLine($"Discount After  : {discountAmount}");
        Console.WriteLine($"Movie    : {MovieName}");
        Console.WriteLine($"Type     : {Type}");
        Console.WriteLine($"Price    : {Price}");
    }
}
