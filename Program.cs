using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FPAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, string> convert = delegate (int s)
            { return s + "dfdsf"; };

            var res = Expression<int>.Value(new List<int> { 1, 2, 3, 4 }).JoinValues(new List<int> { 5, 6 }).Map(convert).ToList();
            var res2 = Expression<int>.Value(new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 2, 3, 4 });
            foreach (var r in res)
                Console.WriteLine(r);
            Console.ReadLine();
          
        }
    }
}
