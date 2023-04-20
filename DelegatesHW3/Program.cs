namespace DelegatesHW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Print printString = PrintGreen;
            printString.Invoke("Hello, World!");
            printString = PrintOrange;
            printString("Hello, World!");

            Action<string> printAction = new Action<string>(PrintGreen);
            printAction("Action Green");

            printAction = PrintOrange;
            printAction("Action Orange");

            //PrintGreen("Hello, World!");
            //PrintOrange("Hello, World!");
        }
        public delegate void Print(string msg);

        static public void PrintGreen(string msg)
        { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        static public void PrintOrange(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}