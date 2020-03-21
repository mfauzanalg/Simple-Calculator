using System;

namespace Ekspresi
{
    static class Program
    {
        static void Main()
        {
            AddExpression<int> e = new AddExpression<int>(new TerminalExpression<int> (4), new TerminalExpression<int> (6));
            Console.WriteLine(e.solve());
        }
    }
}
