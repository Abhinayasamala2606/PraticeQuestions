namespace ConsoleApp30
{
    public class Movie
    {
        public static string name { get; set; }
        public int ticketId { get; set; }
        public string seatNumber { get; set; }

        public Movie ReturnMovieDetails(string name, int ticketId, string seatNumber)
        {
            Movie M = new Movie();
            {
                name = name;
                ticketId = ticketId;
                seatNumber = seatNumber;
            }
            return M;
        }

    }
    public class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the movie name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the ticket id");
            int ticketId=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seat number");
            string seatNumber=Console.ReadLine();
            Console.WriteLine("Movie name : " + name);
            Console.WriteLine("Ticket id : " + ticketId);
            Console.WriteLine("Seat number : " + seatNumber);
        }
    }
}
