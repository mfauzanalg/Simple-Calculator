using System;


namespace Ekspresi
{
    public class NegativeExpression<T> : UnaryExpression<T>
    {
        // ctor
        public NegativeExpression(Expression<T> x) : base(x)
        {
            // 
        }

        public override T Solve()
        {
            dynamic d1 = X.Solve();
            return (-1 * d1);
        }
    }

}
