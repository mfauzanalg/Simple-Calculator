using System;

namespace Ekspresi
{
    public class RootExpression<T> : UnaryExpression<T>
    {
        // ctor
        public RootExpression(Expression<T> x): base(x)
        {
            // 
        }

        public override T solve()
        {
            // dua angka blkg koma:
            dynamic d1 = X.solve();
            return Math.Sqrt(d1).ToString("0.00000");
        }
    }

}
