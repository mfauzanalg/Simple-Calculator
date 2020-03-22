using System;
using Validation;

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
            // Exception jika root of negative number
            dynamic d1 = X.solve();
            if (d1 < 0) {throw new InvalidExpression("Root of \nNegative num");}
            return Math.Sqrt(d1).ToString("0.00000");
        }
    }

}
