using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            "Zhenya".AskAboutVerstka("Kogda zhe budet sdelana verstka?");
        }
    }

    public static class AskExtention
    {
        public static void AskAboutVerstka(this string name, string message)
        {
            Console.WriteLine($"{name}, {message}?");
        }
    }
}
