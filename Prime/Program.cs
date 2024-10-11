using System.Diagnostics;

namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string results = String.Join(',',PrimeMethods.prime(1000000));
            stopWatch.Stop();
            File.WriteAllText("Results.txt",$"Time in Milliseconds:{stopWatch.ElapsedMilliseconds.ToString()}\n\n{results}");
        }
    }
}
