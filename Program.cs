using System;
using System.Threading;

namespace TextVenture
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalText defaultText = new NormalText(50);
            defaultText.Text("Hi there young one, how are you doing?");

            defaultText.Text("Now with colors!",ConsoleColor.Red);
            defaultText.Text("And even more colors", ConsoleColor.Blue);


            Console.ReadKey();
        }


    }
}
