namespace Kalkulator
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

        // public abstract dynamic Solve();

    }

}

/*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }*/
