using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPAPI
{
    class ThenElse<R>
    {
        private IfThen<R> ifThener;
        private IFunctionType<R> elser;

        public ThenElse(IfThen<R> ifThener)
        {
            this.ifThener = ifThener;
        }

        public R Else(IFunctionType<R> elser)
        {
            this.elser = elser;
            return compute();
        }

        private R compute()
        {
            Boolean condValue = ifThener.getCondition().execute();
            R result;
            if (condValue)
                result = ifThener.getThenExpression().execute();
            else
                result = elser.execute();

            return result;
        }
    }
}
