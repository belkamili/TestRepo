using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUsingGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Areth.Add(3, 2));
            Console.WriteLine("Odd or not odd : {0}", Areth.checkOddNumber(34));
            // simultaneously : this is some github line
            // simultaneously : this is some vs line
            Console.ReadLine();
        }
    }
}
