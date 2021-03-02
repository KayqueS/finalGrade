using System;

namespace finalGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            FinalGrade x = new FinalGrade();

            Console.Write("Student's name: ");
            x.Name = Console.ReadLine();
            Console.WriteLine("Enter the student's three grades:");
            x.Quarter1 = double.Parse(Console.ReadLine());
            x.Quarter2 = double.Parse(Console.ReadLine());
            x.Quarter3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"FINAL GRADE = {x.Final():F2}");

            if (x.Approved())
            {
                Console.WriteLine("APRPOVED");
            }
            else
            {
                Console.WriteLine("DISAPPROVED");
                Console.WriteLine($"MISSED {x.RemainingNote():F2} POINTS");
            }
        }
    }
}
