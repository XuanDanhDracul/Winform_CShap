using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckClock
{
    class SplitString
    {
        public static void Charstring(string a = "00",string b = "00",string c = "00")
        {
            string[] rex = Regex.Split(a, "day");
            string[] rex1_ = Regex.Split(b, " hrs");
            string[] rex2_ = Regex.Split(c, "mins");
            Console.WriteLine("{0} {1} {2}", rex[0].Trim(), rex1_[0].Trim(), rex2_[0].Trim());
        }
        public static void Main(string[] args)
        {
            Charstring(a:"2 day",b:"3 hrs");
        }
    }
}
