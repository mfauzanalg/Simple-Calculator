﻿using System;

namespace Kalkulator
{
    public class AddExpression : BinaryExpression
    {
        // ctor
        public AddExpression(Expression x, Expression y) : base(x,y)
        {
            //
        }

        public override dynamic Solve()
        {
            return (X.Solve() + Y.Solve()); //.ToString("0.00");
        }
    }
}