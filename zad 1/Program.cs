namespace zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine("Напишете число:");
                int number = int.Parse(Console.ReadLine());
                queue.Enqueue(number);
                count++;
            }
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
