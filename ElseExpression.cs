namespace FPAPI
{
    class ElseExpression<R>
    {
        private ThenElse<R> thenelser;
        private R elser

        public ElseExpression(ThenElse<R> thenelser)
        {
            this.thenelser = thenelser;
        }

        public ListArguments<R> Else(R elser)
        {

        }

     
    }
}