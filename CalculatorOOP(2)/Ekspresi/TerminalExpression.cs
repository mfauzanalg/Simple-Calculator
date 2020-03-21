namespace Ekspresi
{
    public class TerminalExpression<T> : Expression<T>
    {
        // atribut
        protected T X;

        // ctor
        public TerminalExpression(T x)
        {
            X = x;
        }

        public override T Solve()
        {
            return X;
        }

    }

}

/*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }*/
