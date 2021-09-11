using System;

namespace ConsoleApp2_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n========== 1. uzdevums ==========\n");

            Console.WriteLine("Kāds ir Tavs vārds?");
            string userName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Sveiki, {userName}!");

            Console.WriteLine("\n========== 2. uzdevums ==========\n");

            Console.WriteLine("Kāds ir Tavs vecums?");
            string userAgeText = Console.ReadLine();
            int userAge = int.Parse(userAgeText);

            int userAgeNextYear = userAge + 1;

            bool is18Age = userAge >= 18;

            Console.WriteLine();
            Console.WriteLine($"Nākamgad Tev paliks {userAgeNextYear} gadi! Vai Tu esi pilngadīgs: {is18Age}");


            Console.WriteLine("\n========== 3. uzdevums ==========\n");

            Console.Write("Lūdzu ievadiet pirmo skaitli:");
            string userMaxNumber1 = Console.ReadLine();

            Console.Write("Lūdzu ievadiet otro skaitli:");
            string userMaxNumber2 = Console.ReadLine();

            int maxLargest = Math.Max(int.Parse(userMaxNumber1), int.Parse(userMaxNumber2));

            Console.WriteLine();
            Console.WriteLine($"Lielākais ievadītais skaitlis ir {maxLargest}.");

            Console.WriteLine("\n========== 4. uzdevums ==========\n");

            Console.Write("Lūdzu ievadiet pirmo skaitli:");
            string userMinNumber1 = Console.ReadLine();

            Console.Write("Lūdzu ievadiet otro skaitli:");
            string userMinNumber2 = Console.ReadLine();

            int min = Math.Min(int.Parse(userMinNumber1), int.Parse(userMinNumber2));

            Console.WriteLine();
            Console.WriteLine($"Mazākais ievadītais skaitlis ir {min}.");

            Console.WriteLine("\n========== 5. uzdevums ==========\n");

            Console.Write("Lūdzu ievadiet pirmo skaitli:");
            string userRemainderNumber1 = Console.ReadLine();

            Console.Write("Lūdzu ievadiet otro skaitli:");
            string userRemainderNumber2 = Console.ReadLine();

            int remainderResult = int.Parse(userRemainderNumber1) % int.Parse(userRemainderNumber2);

            Console.WriteLine();
            Console.WriteLine($"Skaitļu dalījuma atlikums ir {remainderResult}.");

            Console.WriteLine("\n========== 6. uzdevums ==========\n");

            Console.Write("Lūdzu ievadiet skaitli:");
            string userOddEvenNumber1 = Console.ReadLine();

            int oddEvenResult = int.Parse(userOddEvenNumber1) % 2;
            bool isEven = oddEvenResult == 0;

            Console.WriteLine();
            Console.WriteLine($"Vai ievadītais skaitlis ir pāra: {isEven}.");

            Console.WriteLine("\n========== 7. uzdevums ==========\n");

            Console.Write("Lūdzu ievadiet taisnstūra platumu:");
            string rectangleWidth = Console.ReadLine();

            Console.Write("Lūdzu ievadiet taisnstūra augstumu:");
            string rectangleHeight = Console.ReadLine();

            decimal rectangleArea = Math.Round(decimal.Parse(rectangleWidth) * decimal.Parse(rectangleHeight), 2);

            Console.WriteLine();
            Console.WriteLine($"Taisnstūra laukums ir {rectangleArea}.");

            Console.WriteLine("\n========== 8. uzdevums ==========\n");

            Console.Write("Lūdzu ievadiet vienādsānu trijstūra pamata platumu:");
            string triangleBase = Console.ReadLine();

            Console.Write("Lūdzu ievadiet vienādsānu trijstūra augstumu:");
            string triangleHeight = Console.ReadLine();

            decimal triangleArea = Math.Round((decimal.Parse(triangleBase) * decimal.Parse(triangleHeight)) / 2, 2);

            Console.WriteLine();
            Console.WriteLine($"Vienādsānu trijstūra laukums ir {triangleArea}.");

            //Console.WriteLine("\n========== 9. uzdevums ==========\n");

            // See first task
        }
    }
}
