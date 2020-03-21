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

        public override T Solve()
        {
            // dua angka blkg koma:
            dynamic d1 = X.Solve();
            return Math.Sqrt(d1).ToString("0.00");
            // return (Math.Sqrt(X.Solve()));
        }
    }

}
