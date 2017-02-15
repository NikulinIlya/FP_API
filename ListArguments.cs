using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    class ListArguments<T> : IArguments
    {
        private List<T> args;

        public ListArguments(List<T> arg)
        {
            args = arg;
        }

        public ListArguments<T> JoinValues(List<T> args2)
        {
            List<T> result = new List<T>();
            result.AddRange(args);
            result.AddRange(args2);
            return new ListArguments<T>(result);
        }

        public ListArguments<R> Map<R>(Func<T, R> func)
        {
            List<R> result = new List<R>();
            foreach (var t in args)
                result.Add(func(t));
            return new ListArguments<R>(result);
        }

        public ListArguments<T> Fold(Func<T, T, T> func)
        {
            using (IEnumerator<T> e = args.GetEnumerator())
            {
                T result = e.Current;
                while (e.MoveNext()) result = func(result, e.Current);
                List<T> resList = new List<T>(1);
                resList.Add(result);
                return new ListArguments<T>(resList);
            }
        }
        
        public List<T> ToList()
        {
            return args;
        }
    }
}
