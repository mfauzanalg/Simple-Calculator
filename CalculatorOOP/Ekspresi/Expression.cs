using System;

namespace Ekspresi
{
    public abstract class Expression
    {
        // ctor
        public Expression() { }

        public abstract dynamic Solve();
    }
}
