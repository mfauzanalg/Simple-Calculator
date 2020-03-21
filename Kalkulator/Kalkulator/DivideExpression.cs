using System;

namespace Ekspresi
{
    public class DivideExpression<T> : BinaryExpression<T>
    {
        // ctor
        public DivideExpression(Expression<T> x, Expression<T> y) : base(x, y)
        {
            //
        }

        public override T Solve()
        {
            dynamic d1 = X.Solve();
            dynamic d2 = Y.Solve();
            return (d1 / d2);
        }
    }
}