using System;

namespace Kalkulator
{
    public class RootExpression : UnaryExpression
    {
        // ctor
        public RootExpression(Expression x): base(x)
        {
            // 
        }

        public override dynamic Solve()
        {
            // dua angka blkg koma:
            return Math.Sqrt(X.Solve()).ToString("0.00");
            // return (Math.Sqrt(X.Solve()));
        }
    }

}
