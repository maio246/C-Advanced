namespace _01.Action_Print
{
    using System;
    using System.Linq;

    public static class ActionPrint
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split().ToList();
            var printer = new Action<string>(Print);

            inputLine.ForEach(x => printer(x));
        }

        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
