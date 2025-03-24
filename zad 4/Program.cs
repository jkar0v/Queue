using System.Security.Cryptography;

namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число в интервала от 10 до 1000010:");
            int n = int.Parse(Console.ReadLine());

            if(n < 10 && n > 1000010)
            {
                Console.WriteLine("Грешка!");
            }

            Queue<int> queue = new Queue<int>();
            while (n > 0)
            {
                Random random = new Random();
                int newNumber = random.Next(100, 10000010);
                Console.Write(newNumber + " ");
                newNumber /= 10;
                queue.Enqueue(newNumber);
                n--;
            }
            Console.WriteLine("\nНачален набор от числа");
            int countRN = queue.Count;
            while(countRN > 0)
            {
                int number = queue.Dequeue();
                Console.Write(number + " ");
                queue.Enqueue(number);
                countRN--;
            }

            countRN = queue.Count;
            while (countRN > 0)
            {
                int number = queue.Dequeue();
                if (number % 2 != 0)
                {
                    queue.Enqueue(number);
                }
                countRN--;
            }
            Console.WriteLine("\nЧисла, след редукцията:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue() + " ");
            }
        }
    }
}
