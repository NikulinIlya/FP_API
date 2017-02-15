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
        private R elser;

        public ThenElse(IfThen<R> ifThener)
        {
            this.ifThener = ifThener;
        }

        public  R Else(R elser)
        {
            this.elser = elser;
            return compute();
        }

        private R compute()
        {
            var condValue = ifThener.getCondition().execute();
            return default(R);
        }
    }
}
