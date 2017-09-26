using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes > 60)
            {
                if (hours <23)
                {
                    int minutesLeft = minutes - 60;
                    hours += 1;
                    Console.WriteLine($"{hours}:{minutesLeft}");
                }


            }
            else
            {
                hours = 0;
                Console.WriteLine($"{hours}:{minutes}");
            }


        }
    }
}
