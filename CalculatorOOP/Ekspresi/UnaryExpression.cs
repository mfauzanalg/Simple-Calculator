namespace Ekspresi
{
    public abstract class UnaryExpression : Expression
    {
        // atribut
        protected Expression X;

        // ctor
        public UnaryExpression(Expression x)
        {
            X = x;
        }

    }

}
