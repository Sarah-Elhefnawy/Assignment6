namespace Assignment6_Part2;

internal class Program
{
    static void Main(string[] args)
    {
        bool isValid = false;
        string? userMovie;
        string? userType;
        char userSeatRow = 'A';
        int userSeatNumber = 0;
        int userPriceNumber = 0;
        int userDiscountAmount = 0;
        TicketType userTicketType = 0;

        do
        {
            Console.Write("Enter Movie Name: ");
            userMovie = Console.ReadLine();

            if (String.IsNullOrEmpty(userMovie))
            {
                Console.WriteLine("movie name can't be null");
            }
            else
            {
                isValid = true;
            }
        } while (!isValid);

        do
        {
            Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            userType = Console.ReadLine();

            if (String.IsNullOrEmpty(userType))
            {
                Console.WriteLine("Ticket Type can't be null");
            }
            else if (!Enum.TryParse(userType, out userTicketType))
            {
                Console.WriteLine("only 0, 1, 2 available");
            }
            else
            {
                int userTypeInt = int.Parse(userType);
                if (userTypeInt >= 0 && userTypeInt <= 2)
                {
                    isValid = false;
                }
                else
                {
                    Console.WriteLine("Only 0, 1, 2 are available");
                }
            }
        } while (isValid);

        do
        {
            Console.Write("Enter Seat Row (A, B, C...): ");
            string userSeat = Console.ReadLine()!;

            if (String.IsNullOrEmpty(userSeat))
            {
                Console.WriteLine("Seat Row can't be null");
            }
            else if (!char.TryParse(userSeat, out userSeatRow))
            {
                Console.WriteLine("Seat Row must be a character only");
            }
            else if (!Char.IsLetter(userSeatRow))
            {
                Console.WriteLine("Seat Row must be a character only");
            }
            else
            {
                isValid = true;
            }
        } while (!isValid);

        do
        {
            Console.Write("Enter Seat Number: ");
            string userNumber = Console.ReadLine()!;

            if (String.IsNullOrEmpty(userNumber))
            {
                Console.WriteLine("Seat Number can't be null");
            }
            else if (!int.TryParse(userNumber, out userSeatNumber))
            {
                Console.WriteLine("Seat Number must be a digits only");
            }
            else if (userSeatNumber < 0)
            {
                Console.WriteLine("Seat Number can't be negative");   
            }
            else
            {
                isValid = false;
            }
        } while (isValid);

        do
        {
            Console.Write("Enter Price: ");
            string userPrice = Console.ReadLine()!;

            if (String.IsNullOrEmpty(userPrice))
            {
                Console.WriteLine("Price can't be null");
            }
            else if (!int.TryParse(userPrice, out userPriceNumber))
            {
                Console.WriteLine("Price must be a digits only");
            }
            else if (userPriceNumber < 0)
            {
                Console.WriteLine("Price can't be negative");
            }
            else
            {
                isValid = true;
            }
        } while (!isValid);

        do
        {
            Console.Write("Enter Discount Amount: ");
            string userDiscount = Console.ReadLine()!;

            if (String.IsNullOrEmpty(userDiscount))
            {
                Console.WriteLine("Discount Amount can't be null");
            }
            else if (!int.TryParse(userDiscount, out userDiscountAmount))
            {
                Console.WriteLine("Discount Amount must be a digits only");
            }
            else if (userDiscountAmount < 0)
            {
                Console.WriteLine("Discount Amount can't be negative");
            }
            else
            {
                isValid = false;
            }
        } while (isValid);

        Ticket ticket = new Ticket(userMovie, userTicketType, userSeatNumber, userSeatRow, userPriceNumber);

        ticket.PrintTicket();

        ticket.ApplyDiscount(userDiscountAmount);
    }
}
