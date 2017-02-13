using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    class IfThen<R>
    {
        private Func<dynamic, Boolean> cond;
        private R thener;

        public IfThen(Func<dynamic, Boolean> cond)
        {
            this.cond = cond;
        }

        public ThenElse<R> Then(R thenexpr)
        {
            this.thener = thenexpr;
            return new ThenElse<R>(this);
        }
    }
}
