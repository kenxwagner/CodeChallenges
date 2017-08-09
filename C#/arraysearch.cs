using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace MakeASearchArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strname = { "Monu", "Mohan", "satendra", "jeetendra", "Rohatash" };
            string match = Array.Find(strname, ContainsA);
            Console.WriteLine("Search string is:" + match);
        }
        static bool ContainsA(string findname)
        {
            return findname.Contains("h");
        }
    }
}

 