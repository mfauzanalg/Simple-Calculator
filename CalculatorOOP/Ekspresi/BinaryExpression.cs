namespace Ekspresi
{
    public abstract class BinaryExpression<T> : Expression<T>
{
        // atribut
        protected Expression<T> X;
        protected Expression<T> Y;

        // ctor
        public BinaryExpression (Expression<T> x, Expression<T> y)
        {
            X = x;
            Y = y;
        }

    }
}
