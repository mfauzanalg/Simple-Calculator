using System;

namespace Ekspresi
{
    public class SubstractExpression : BinaryExpression
    {
        // ctor
        public SubstractExpression(Expression x, Expression y) : base(x, y)
        {
            //
        }

        public override dynamic Solve()
        {
            return (X.Solve() - Y.Solve());
        }
    }
}

