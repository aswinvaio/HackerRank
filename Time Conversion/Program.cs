using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    class Program
    {
        static void Main(String[] args)
        {
            string time = Console.ReadLine().Trim();
            String ampm = time.Substring(time.Length - 2, 2);
            string timeo = "";
            int h = (Convert.ToInt32(time.Substring(0, 2))) % 12;
            if (ampm.Equals("PM"))
                h += 12;
            if (h < 10) timeo += "0";
            timeo += h.ToString();
            timeo += time.Substring(2, 6);
            Console.WriteLine(timeo);
            Console.ReadLine();
        }
    }
}
