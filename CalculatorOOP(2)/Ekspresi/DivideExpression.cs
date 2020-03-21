using System;

namespace Ekspresi
{
    public class DivideExpression<T> : BinaryExpression<T>
    {
        // ctor
        public DivideExpression(Expression<T> x, Expression<T> y) : base(x, y)
        {
            try
            {
            }
            catch(DivideByZeroException)
            {
                Console.Writeline("Can't Divide by O");
                throw;
            }
        }

        public override T solve()
        {
            dynamic d1 = X.solve();
            dynamic d2 = Y.solve();
            return (d1 / d2);
        }
    }
}
