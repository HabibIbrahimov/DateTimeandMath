using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Math
            double x = 4;
            double y = 6;


            double a = Math.Pow(x, 2);
            double b = Math.Sqrt(x);
            double c = Math.Abs(x);
            double d = Math.Round(x);
            double e = Math.Ceiling(x);
            double f = Math.Floor(x);
            double g = Math.Max(x, y);
            double h = Math.Min(x, y);

            Console.WriteLine(h);
            #endregion

            #region DateTime struct
            var date01 = new DateTime(2021, 10, 31, 11, 36, 23);
            Console.WriteLine(date01);

            var date02 = DateTime.Now;
            var date03 = DateTime.UtcNow;
            var date04 = DateTime.Today;
            Console.WriteLine(date02);
            Console.WriteLine(date03);
            Console.WriteLine(date04);

            var tomorrow = date02.AddDays(1);
            Console.WriteLine(tomorrow);

            Console.WriteLine(date02.ToLongDateString());
            Console.WriteLine(date02.ToShortDateString());
            Console.WriteLine(date02.ToLongTimeString());
            Console.WriteLine(date02.ToShortTimeString());

            Console.WriteLine(date02.ToString());
            Console.WriteLine(date02.ToString("dd-MM-yy"));

            #endregion
        }
    }
}
