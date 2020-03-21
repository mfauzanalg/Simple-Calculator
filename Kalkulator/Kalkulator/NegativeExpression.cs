using System;


namespace Kalkulator
{
    public class NegativeExpression : UnaryExpression
    {
        // ctor
        public NegativeExpression(Expression x) : base(x)
        {
            // 
        }

        public override dynamic Solve()
        {
            return (-1 * X.Solve());
        }
    }

}
