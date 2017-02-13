namespace FPAPI
{
    class ElseExpression<R>
    {
        private ThenElse<R> thenelser;

        public ElseExpression(ThenElse<R> thenelser)
        {
            this.thenelser = thenelser;
        }

        public R Eval()
        {
             
        }
    }
}