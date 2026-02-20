namespace G_NET_42_C__4
{
    //enum DayOfWeek
    //{
    //    Saturday = 1,
    //    Sunday,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday
    //}
   


    internal class Program
    {
        const int NumberOfStudents = 3;
        const int NumberOfSubjects = 4;
        static void Main(string[] args)
        {
            #region Part1
            //int dayNumber = ReadDayNumber();

            //if (!IsValidDayNumber(dayNumber))
            //{
            //    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            //    return;
            //}

            //DayOfWeek selectedDay = (DayOfWeek)dayNumber;

            //PrintDayDetails(selectedDay);
            #endregion
            //---------------------------------------part2-------------
            //#region part2
            //int arraySize = ReadArraySize();
            //int[] numbers = ReadArrayElements(arraySize);

            //DisplayArrayStatistics(numbers);
            //#endregion
            #region Q2
            //double[,] grades = ReadStudentGrades();

            //PrintStudentAverages(grades);
            //PrintClassAverage(grades);
            #endregion
        }
        #region part1
        //static int ReadDayNumber()
        //{
        //    Console.Write("Enter a day number (1–7): ");
        //    return int.Parse(Console.ReadLine() ?? "0");
        //}
        //static bool IsValidDayNumber(int number)
        //{
        //    return number >= 1 && number <= 7;
        //}
        //static void PrintDayDetails(DayOfWeek day)
        //{
        //    Console.WriteLine($"Day: {day}");

        //    switch (day)
        //    {
        //        case DayOfWeek.Saturday:
        //        case DayOfWeek.Sunday:
        //            Console.WriteLine("It's the Weekend");
        //            break;

        //        default:
        //            Console.WriteLine("It's a Workday");
        //            break;
        //    }
        //}
        #endregion
        #region part2
        //static int ReadArraySize()
        //{
        //    Console.Write("Enter array size: ");
        //    return int.Parse(Console.ReadLine() ?? "0");
        //}

        //static int[] ReadArrayElements(int size)
        //{
        //    int[] values = new int[size];

        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.Write($"Enter element [{i}]: ");
        //        values[i] = int.Parse(Console.ReadLine() ?? "0");
        //    }

        //    return values;
        //}
        //static void DisplayArrayStatistics(int[] numbers)
        //{
        //    int sum = 0;
        //    int max = numbers[0];
        //    int min = numbers[0];

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];

        //        if (numbers[i] > max)
        //            max = numbers[i];

        //        if (numbers[i] < min)
        //            min = numbers[i];
        //    }

        //    double average = (double)sum / numbers.Length;

        //    Console.WriteLine($"\nSum = {sum}");
        //    Console.WriteLine($"Average = {average}");
        //    Console.WriteLine($"Max = {max}");
        //    Console.WriteLine($"Min = {min}");

        //    Console.Write("Reverse = ");
        //    for (int i = numbers.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(numbers[i]);

        //        if (i > 0)
        //            Console.Write(", ");
        //    }
        //}
        #endregion
        #region Q2
        //static double[,] ReadStudentGrades()
        //{
        //    double[,] grades = new double[NumberOfStudents, NumberOfSubjects];

        //    for (int student = 0; student < NumberOfStudents; student++)
        //    {
        //        Console.WriteLine($"\nEntering grades for Student {student + 1}:");

        //        for (int subject = 0; subject < NumberOfSubjects; subject++)
        //        {
        //            Console.Write($"Enter grade for Subject {subject + 1}: ");
        //            grades[student, subject] = double.Parse(Console.ReadLine() ?? "0");
        //        }
        //    }

        //    return grades;
        //}
        //static void PrintStudentAverages(double[,] grades)
        //{
        //    Console.WriteLine("\nStudent Averages:");

        //    for (int student = 0; student < NumberOfStudents; student++)
        //    {
        //        double total = 0;

        //        for (int subject = 0; subject < NumberOfSubjects; subject++)
        //        {
        //            total += grades[student, subject];
        //        }

        //        double average = total / NumberOfSubjects;
        //        Console.WriteLine($"Student {student + 1} Average = {average}");
        //    }
        //}
        //static void PrintClassAverage(double[,] grades)
        //{
        //    double total = 0;

        //    for (int student = 0; student < NumberOfStudents; student++)
        //    {
        //        for (int subject = 0; subject < NumberOfSubjects; subject++)
        //        {
        //            total += grades[student, subject];
        //        }
        //    }

        //    double classAverage = total / (NumberOfStudents * NumberOfSubjects);

        //    Console.WriteLine($"\nOverall Class Average = {classAverage}");
        //}
        #endregion

    }
}
