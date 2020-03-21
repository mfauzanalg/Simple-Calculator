namespace Ekspresi
{
    public abstract class UnaryExpression<T> : Expression<T>
    {
        // atribut
        protected Expression<T> X;

        // ctor
        public UnaryExpression(Expression<T> x)
        {
            X = x;
        }

        // public abstract dynamic solve();

    }

}
