using System.Text.RegularExpressions;

namespace Taskü
{
    internal class Program
    {
        public static bool CustomTryParse(string a, out int b)
        {
            b = 0;
            try
            {
                b = int.Parse(a);
                return true;

            }
            catch (FormatException)
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string a = "100";
            int b;
            if (CustomTryParse(a, out b))
            { Console.WriteLine(b); }
            else
            { Console.WriteLine(b); }



        }
    }

}