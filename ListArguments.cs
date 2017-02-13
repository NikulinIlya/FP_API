using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    class ListArguments<T>
    {
        List<T> args;

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

        public List<T> ToList()
        {
            return args;
        }

        public OneThen<T> If(Func<bool> expr)
        {
            bool res = expr();
            return new OneThen<T>(this, res);
        }
    }

    class OneThen<T>
    {
        public OneThen(ListArguments<T> a, bool ex)
        {
            arg = a;
            expr = ex;
        }
        ListArguments<T> arg;
        bool expr;

        public dynamic Then<Tres>(Func<T, Tres> func)
        {
            return null;

        }
    }
}
