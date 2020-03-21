namespace Kalkulator
{
    public abstract class BinaryExpression : Expression
{
        // atribut
        protected Expression X;
        protected Expression Y;

        // ctor
        public BinaryExpression(Expression x, Expression y)
        {
            X = x;
            Y = y;
        }

        // public abstract dynamic Solve();
    }

}

/*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }*/
