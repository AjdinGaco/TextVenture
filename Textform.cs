using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextVenture
{
    abstract class Textform
    {
        public void Text(string _input, int _delay = 100)
        {
            char[] charArr = _input.ToCharArray();

            foreach (Char cher in charArr)
            {
                Console.Write(cher);
                Thread.Sleep(_delay);
            }

            Console.WriteLine();
        }
    }
    class Normal : Textform
    {

    }
}
