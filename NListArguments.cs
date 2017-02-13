using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    class NListArguments<T>
    {
        List<List<T>> arg;
        public NListArguments(List<List<T>> a)
        {
            arg = a;
        }

        /*public ListArguments<T> Zip()
        {
           
        }*/
    }
}
