using System;
using Validation;

namespace Ekspresi
{
    public class DivideExpression<T> : BinaryExpression<T>
    {
        // ctor
        public DivideExpression(Expression<T> x, Expression<T> y) : base(x, y)
        {
            //
        }

        // Divide solver
        public override T solve()
        {
            // Exception divide num by 0
            dynamic d1 = X.solve();
            dynamic d2 = Y.solve();
            if (d2 == 0) {throw new InvalidExpression("Error divide by 0"); }
            return (d1 / d2);    
        }
    }
}
