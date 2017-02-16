using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    class NListArguments<T> : ListArguments<T>
    {
        List<List<T>> arg;
        public NListArguments(List<List<T>> a)
        {
            arg = a;
        }

        /*public ListArguments<Tuple<T>> Zip()
        {
            int count = arg.Count();
            List<Tuple<T>> res = new List<Tuple<T>>();

            int size = arg[0].Count();
            for (var i = 1; i < count; i++)
            {
                int s = arg[i].Count();
                if (s < size) size = s;

            }

            for (var i=0; i < size; i++)
            {
                Tuple t = new Tuple();
           
            }

            return new ListArguments<Tuple<T>>(res);
        }*/

        public ListArguments<R> FlatMap<R>(Func<T, R> func)
        {
            List<T> result = arg[0];
            List<R> results = new List<R>();
            var res = Task.Run(() =>
            {
                for (var i = 1; i < arg.Count; i++)
                {
                    result.AddRange(arg[i]);
                }

                foreach (var t in result)
                    results.Add(func(t));
            });
            res.Wait();
            
            return new ListArguments<R>(results);
        }
    }
}
