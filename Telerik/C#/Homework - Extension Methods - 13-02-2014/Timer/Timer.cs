using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Timer
{
    /* 07.
     * Using delegates write a class Timer that has can execute certain method at each t seconds.
     */

    public delegate void Repeat(string message, int seconds);

    public class Timer
    {
        public static void Loop(string message, int seconds)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                if (sw.ElapsedMilliseconds == seconds * 1000) //Convert sec to millisec.
                {
                    Console.WriteLine(message);
                    sw.Restart();
                }
            }
        }

        static void Main()
        {
            Repeat repeat = new Repeat(Loop);
            repeat("This sentence repeats every five seconds (or so)...", 5);
        }
    }
}
