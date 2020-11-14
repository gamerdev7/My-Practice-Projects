using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class ProcessDelegate
    {
        public static void Process(int x, int y, RulesDelegate rd)
        {
            var result = rd(x, y);
            Console.WriteLine($"Result = {result}");
        }
    }
}
