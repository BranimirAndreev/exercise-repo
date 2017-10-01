using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exsam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++) ;
            {
                string asteriks = new string('*', i);
                string spaces = new string('', n - i);
                Console.Write(spaces);
                Console.Write(asteriks);
                Console.Write("|");
                Console.Write(asteriks);
                Console.Write(spaces);
            }
    }
}
