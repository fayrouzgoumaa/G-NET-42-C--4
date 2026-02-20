namespace G_NET_42_C__4
{
    enum DayOfWeek
    {
        Saturday = 1,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            int dayNumber = ReadDayNumber();

            if (!IsValidDayNumber(dayNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                return;
            }

            DayOfWeek selectedDay = (DayOfWeek)dayNumber;

            PrintDayDetails(selectedDay);
        }
        static int ReadDayNumber()
        {
            Console.Write("Enter a day number (1–7): ");
            return int.Parse(Console.ReadLine() ?? "0");
        }
        static bool IsValidDayNumber(int number)
        {
            return number >= 1 && number <= 7;
        }
        static void PrintDayDetails(DayOfWeek day)
        {
            Console.WriteLine($"Day: {day}");

            switch (day)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("It's the Weekend");
                    break;

                default:
                    Console.WriteLine("It's a Workday");
                    break;
            }
        }
        #endregion
    }
}
