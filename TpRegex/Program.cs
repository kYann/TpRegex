using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TpRegex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string regex = "^(a+)+$";

            var watch = new Stopwatch();
            watch.Start();
            Regex.Match("aaaaaaaaaaaaaaaaaaaaaaaaaZ", regex);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.Read();
        }
    }
}
