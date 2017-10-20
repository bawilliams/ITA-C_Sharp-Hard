using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            // Counters for stars and spaces
            var stars = 0;
            var spaces = 4;

            // Loop through 25 times - the number of total stars
            for (var i = 0; i < 25; i++)
            {
                // Loop for spaces - only add after certain amount of stars
                for (var j = 0; j < 1; j++)
                {
                    if (stars == 0 || stars == 1 || stars == 4 || stars == 9)
                    {
                        // Use string class to repeat the given string x (or spaces) number of times
                        var spacesFinal = new String(' ', spaces);
                        Console.Write(spacesFinal);
                        sp--;
                    }
                    
                }

                // Loop for stars
                for (var st = 0; st < 1; st++)
                {
                    Console.Write("*");
                    stars ++;
                }

                // Create a line break after the correct number of stars
                switch (stars)
                {
                    case 1:
                    case 4:
                    case 9:
                    case 16:
                    case 25:
                        Console.Write("\n");
                        break;
                    default:
                        break;
                }

            }

        }
    }
}


