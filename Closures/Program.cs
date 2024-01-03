namespace Closures
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Closure();
            ClosureInLoop();
        }

        private static void Closure()
        {
            int i = 0;
            Action action = () => Console.WriteLine($"i : {i}");
            action();

            i = 100;
            action();
        }

        private static void ClosureInLoop()
        {
            Action[] actions = new Action[4];

            for (int i = 0; i < actions.Length; i++)
            {
                actions[i] = () => Console.WriteLine($"i : {i}");
            }

            foreach (Action action in actions)
            {
                action();
            }
        }
    }
}