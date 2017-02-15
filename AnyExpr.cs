using System;
using System.Collections.Generic;

namespace FPAPI
{
    internal class AnyExpr<T,R>
    {
        private List<T> list;

        public AnyExpr(List<T> list)
        {
            this.list = list;
        }

        public ListArguments<R> Then(Func<T,R> flist)
        {
            return null;
        }
    }
}