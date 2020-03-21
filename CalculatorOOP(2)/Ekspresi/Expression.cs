using System;

namespace Ekspresi
{
    public abstract class Expression<T>
    {
        // ctor
        public Expression()
        {
            //
        }

        public abstract T Solve();
    }
}
