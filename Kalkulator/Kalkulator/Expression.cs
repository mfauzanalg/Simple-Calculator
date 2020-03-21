using System;

namespace Kalkulator
{
    public abstract class Expression
    {
        // ctor
        public Expression()
        {
            //
        }

        public abstract dynamic Solve();
    }
}
