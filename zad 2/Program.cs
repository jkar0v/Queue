namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<char> queue = new Queue<char>();
            Stack<char> stack = new Stack<char>();
            Console.WriteLine("Въведете дума, за да проверим за палиндром:");
            string word = Console.ReadLine();

            foreach (char letter in word)
            {
                queue.Enqueue(letter);
                stack.Push(letter);
            }
            while (queue.Count > 0)
            {
                if(queue.Dequeue() != stack.Pop())
                {
                    Console.WriteLine("Думата не е палиндром.");
                    return;
                }
            }
            Console.WriteLine("Думата е палиндром :)");
        }
    }
}
