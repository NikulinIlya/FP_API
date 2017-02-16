using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    class ListArguments<T> 
    {
        private List<T> args;

        public ListArguments() { }
        public ListArguments(List<T> arg)
        {
            args = arg;
        }

        public ListArguments<T> JoinValues(List<T> args2)
        {
            List<T> result = new List<T>();
            Task.Run(() =>
            {
                result.AddRange(args);
                result.AddRange(args2);
            });
           return new ListArguments<T>(result);
        }

        public ListArguments<R> Map<R>(Func<T, R> func)
        {
            List<R> result = new List<R>();
            var res = Task.Run(() =>
            {
                foreach (var t in args)
                    result.Add(func(t));
            });
            res.Wait();
                          
            return new ListArguments<R>(result);
        }

        public ListArguments<T> Fold(Func<T, T, T> func)
        {
            List<T> resList = new List<T>(1);
            var list = Task.Run(() =>
            {
                using (IEnumerator<T> e = args.GetEnumerator())
                {
                    T result = e.Current;
                    
                    while (e.MoveNext()) result = func(result, e.Current);
                        resList.Add(result);
                }

            });

            list.Wait();
            return new ListArguments<T>(resList);
        }
        
        
        public List<T> ToList()
        {
            return args;
        }
    }
}
