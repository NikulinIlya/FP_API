using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    class FunctionArguments<T, R>
    {
        private Func<T, R> farg;

        public FunctionArguments(Func<T,R> func)
        {
            farg = func;
        }

        public FunctionArguments<T, R2> Then<R2>(Func<R, R2> g)
        {
            //return new FunctionArguments<R,R2>((x) => g(farg(x)));
            return null;
        }

        public FunctionArguments<T,R> Rec()
        {
            return new FunctionArguments<T,R>(x => farg(x));
        }
    }
}
