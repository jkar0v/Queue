namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число в интервала от 10 до 100");
            int n = int.Parse(Console.ReadLine());

            if (n < 10 || n > 100)
            {
                Console.WriteLine("Въведете правилна стойност");
                return;
            }

            Queue<int> queue = new Queue<int>();
            while (n > 0)
            {
                Random random = new Random();
                queue.Enqueue(random.Next(1, 101));
                n--;
            }

            Queue<int> even = new Queue<int>();
            Queue<int> odd = new Queue<int>();

            Console.WriteLine("The numbers are:");
            while (queue.Count > 0)
            {
                int number = queue.Dequeue();
                Console.WriteLine(number + " ");
                if (number % 2 == 0)
                {
                    even.Enqueue(number);
                }
                else
                {
                    odd.Enqueue(number);
                }
            }

            Console.WriteLine("The sorted numbers are:");
            while (even.Count > 0)
            {
                Console.WriteLine(even.Dequeue() + " ");
            }
            while (odd.Count > 0)
            {
                Console.WriteLine(odd.Dequeue() + " ");
            }
        }
    }
}
