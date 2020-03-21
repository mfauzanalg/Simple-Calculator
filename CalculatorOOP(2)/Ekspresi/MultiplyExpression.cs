using System;

namespace Ekspresi
{
    public class MultiplyExpression<T> : BinaryExpression<T>
    {
        // ctor
        public MultiplyExpression(Expression<T> x, Expression<T> y) : base(x, y)
        {
            //
        }

        public override T solve()
        {
            dynamic d1 = X.solve();
            dynamic d2 = Y.solve();
            return (d1 * d2);
        }
    }
}
