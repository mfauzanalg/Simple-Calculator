namespace Kalkulator
{
    public class TerminalExpression : Expression
    {
        // atribut
        protected dynamic X;

        // ctor
        public TerminalExpression(dynamic x)
        {
            X = x;
        }

        public override dynamic Solve()
        {
            return X;
        }

    }

}

/*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }*/
