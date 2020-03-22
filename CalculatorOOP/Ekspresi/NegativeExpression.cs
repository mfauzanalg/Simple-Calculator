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

        public override T solve()
        {
            dynamic d1 = X.solve();
            return (-1 * Convert.ToDouble(d1));
        }
    }

}
