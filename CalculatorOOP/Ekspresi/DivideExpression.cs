using System;

namespace Ekspresi
{
    public class DivideExpression : BinaryExpression
    {
        // ctor
        public DivideExpression(Expression x, Expression y) : base(x, y)
        {
            //
        }

        public override dynamic Solve()
        {
            return (X.Solve() / Y.Solve()); // .ToString("0.00");
        }
    }
}