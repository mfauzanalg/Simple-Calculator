using System;

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
            try
            {
                dynamic d1 = X.solve();
                dynamic d2 = Y.solve();
                return (d1 / d2);
            }
            catch (DivideByZeroException)
            {
                Console.Writeln("Can't Divide by 0");
                throw;
            }
        }
    }
}
