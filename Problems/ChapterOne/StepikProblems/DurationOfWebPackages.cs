using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepikProblems
{
    public class DurationOfWebPackages
    {
        public struct Package
        {
            public int Arrival;
            public int Duration;

            public Package(int arrival, int duration)
            {
                Arrival = arrival;
                Duration = duration;
            }
        }

        public static void Resolve()
        {
            var input = Console.ReadLine().Split(' ');
            Int32.TryParse(input[0], out int bufferSize);
            Int32.TryParse(input[1], out int n);
            
            var buffer = new Queue<Package>();

            for (int i = 0; i < n; i++)
            {
                GetArrivalAndDuration(out int arrival, out int duration);
                buffer.Enqueue(new Package(arrival, duration));
            }

        }

        private static void GetArrivalAndDuration(out int arrival, out int duration)
        {
            var input = Console.ReadLine().Split(' ');
            Int32.TryParse(input[0], out arrival);
            Int32.TryParse(input[1], out duration);
        }
    }
}
