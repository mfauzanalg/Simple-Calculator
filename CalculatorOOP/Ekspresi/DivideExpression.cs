using System;
using Validation;

namespace Ekspresi
{
    public class DivideExpression<T> : BinaryExpression<T>
    {
        // ctor
        public DivideExpression(Expression<T> x, Expression<T> y) : base(x, y)
        {

        }

        public override T solve()
        {
            dynamic d1 = X.solve();
            dynamic d2 = Y.solve();
            if (d2 == 0) {throw new InvalidExpression("Error divide by 0"); }
            return (d1 / d2);    
        }
    }
}
