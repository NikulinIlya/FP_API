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
            var resCond = Task.Run(() =>    
            {
               return ifThener.getCondition().execute();
            });
            resCond.Wait();
            Boolean condValue = resCond.Result;
            R result;
            if (condValue)
            {
                var resThen = Task.Run(() =>
                {
                    return ifThener.getThenExpression().execute();
                });
                resThen.Wait();
                return resThen.Result;
            }
            else
            {
                var resElse = Task.Run(() =>
                {
                    return elser.execute();
                });
                resElse.Wait();
                return resElse.Result;
            }
        }
    }
}
