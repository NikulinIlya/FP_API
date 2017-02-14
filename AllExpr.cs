using System.Collections.Generic;

namespace FPAPI
{
    internal class AllExpr<T>
    {
        private List<T> list;

        public AllExpr(List<T> list)
        {
            this.list = list;
        }
    }
}