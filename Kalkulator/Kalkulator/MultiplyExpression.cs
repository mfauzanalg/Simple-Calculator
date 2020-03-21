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

        public override T Solve()
        {
            dynamic d1 = X.Solve();
            dynamic d2 = Y.Solve();
            return (d1 * d2);
        }
    }
}
