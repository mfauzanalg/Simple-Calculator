using System;

namespace Ekspresi
{
    public class SubstractExpression<T> : BinaryExpression<T>
    {
        // ctor
        public SubstractExpression(Expression<T> x, Expression<T> y) : base(x, y)
        {
            //
        }

        public override T Solve()
        {
            dynamic d1 = X.Solve();
            dynamic d2 = Y.Solve();
            return (d1 - d2);
        }
    }
}

