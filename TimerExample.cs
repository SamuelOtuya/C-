using System;
using System.Diagnostics;

class TimerExample
{
    public static void RunTimer()
    {
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < 1000000; i++) { var x = i * i; }

        sw.Stop();
        Console.WriteLine($"Time elapsed: {sw.ElapsedMilliseconds} ms");
    }
}
