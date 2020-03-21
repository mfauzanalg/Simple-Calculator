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

        public override T solve()
        {
            dynamic d1 = X.solve();
            dynamic d2 = Y.solve();
            return (d1 - d2);
        }
    }
}

