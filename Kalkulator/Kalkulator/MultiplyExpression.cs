using System;

namespace Kalkulator
{
    public class MultiplyExpression : BinaryExpression
    {
        // ctor
        public MultiplyExpression(Expression x, Expression y) : base(x, y)
        {
            //
        }

        public override dynamic Solve()
        {
            return (X.Solve() * Y.Solve());
        }
    }
}
