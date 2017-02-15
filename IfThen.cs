//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    class IfThen<R>
    {
        private IFunctionType<bool> cond;
        private IFunctionType<R> thener;

        public IfThen(IFunctionType<bool> cond)
        {
            this.cond = cond;
        }

        public ThenElse<R> Then(IFunctionType<R> thenexpr)
        {
            this.thener = thenexpr;
            return new ThenElse<R>(this);
        }

        public IFunctionType<bool> getCondition()
        {
            return cond;
        }

        public IFunctionType<R> getThenExpression()
        {
            return thener;
        }
    }
}
