using System;
using System.Collections.Generic;
using System.Linq;

namespace StepikProblems
{
    public class DurationOfWebPackages
    {
        public struct Package
        {
            public long Arrival;
            public long Duration;
            public bool Failed;

            public Package(long arrival, long duration, bool failed = false)
            {
                Arrival = arrival;
                Duration = duration;
                Failed = failed;
            }
        }

        public static void Resolve()
        {
            var input = Console.ReadLine().Split(' ');
            Int32.TryParse(input[0], out int bufferSize);
            Int32.TryParse(input[1], out int n);

            var packages = new Queue<Package>();
            var buffer = new Queue<Package>();
            long currTime = 0;
            var times = new Queue<long>();

            for (int i = 0; i < n; i++)
            {
                GetArrivalAndDuration(out long arrival, out long duration);
                packages.Enqueue(new Package(arrival, duration));
            }

            for (int i = 0; i < n; i++)
            {
                Package currPackage;
                if (buffer.Any())
                {
                    currPackage = buffer.Dequeue();
                    if (currPackage.Failed)
                    {
                        times.Enqueue(-1);
                        continue;
                    }
                }
                else
                {
                    currPackage = packages.Dequeue();
                }

                times.Enqueue(currTime);
                currTime += currPackage.Duration;

                packages.Select(c => c).Where(c => c.Arrival < currTime).ToList().ForEach(package =>
                {
                    if (buffer.Count < bufferSize - 1)
                    {
                        buffer.Enqueue(package);
                    }
                    else
                    {
                        buffer.Enqueue(new Package(0, 0, true));
                    }
                });
            }

            times.ToList().ForEach(time => Console.WriteLine(time));
        }

        private static void GetArrivalAndDuration(out long arrival, out long duration)
        {
            var input = Console.ReadLine().Split(' ');
            Int64.TryParse(input[0], out arrival);
            Int64.TryParse(input[1], out duration);
        }
    }
}
