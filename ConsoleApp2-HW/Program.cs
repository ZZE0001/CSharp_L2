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
            string userNumber1 = Console.ReadLine();

            Console.Write("Lūdzu ievadiet otro skaitli:");
            string userNumber2 = Console.ReadLine();

            int maxLargest = Math.Max(int.Parse(userNumber1), int.Parse(userNumber2));

            Console.WriteLine();
            Console.WriteLine($"Lielākais ievadītais skaitlis ir {maxLargest}.");

            Console.WriteLine("\n========== 4. uzdevums ==========\n");
            // TODO: 
        }
    }
}
