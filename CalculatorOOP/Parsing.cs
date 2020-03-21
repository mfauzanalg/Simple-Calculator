﻿using System;
using System.Collections.Generic;
using Ekspresi;

namespace Parsing
{
    public class Parse
    {
        public static List<string> makeList(string input)
        {
            int i = 0;
            string Result = "";
            List<string> Res = new List<string>();

            while (input[i].Equals('+') || input[i].Equals('-') || input[i].Equals('x') || input[i].Equals(':') || input[i].Equals('√'))
            {
                Res.Add(input[i].ToString());
                i++;
            }

            for (int x = i; x < input.Length; x++)
            {
                // Kalau Ketemu Angka
                if (!(input[x].Equals('+') || input[x].Equals('-') || input[x].Equals('x') || input[x].Equals(':') || input[x].Equals('√')))
                {
                    Result += input[x];
                }
                // Kalau Ketemmu Operator
                else
                {
                    if (!Result.Equals(""))
                    {
                        Res.Add(Result);
                    }
                    Res.Add(input[x].ToString());
                    Result = "";
                }
            }

            if (!Result.Equals(""))
            {
                Res.Add(Result);
                Result = "";
            }

            return Res;
        }
    }

    class Solving
    {
        public static dynamic solver(List<string> input)
        {
            dynamic ret = 0;
            Stack<double> NumS = new Stack<double>();
            Stack<string> OpS = new Stack<string>();
            // Masukkan ke dalam stack
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Equals("+") || input[i].Equals("-") || input[i].Equals("x") || input[i].Equals(":") || input[i].Equals("√"))
                {
                    OpS.Push(input[i]);
                }
                else
                {
                    double P = Convert.ToDouble(input[i]);
                    NumS.Push(P);
                }
            }

            // Solve dari Stack
            int count = OpS.Count;
            for (int i = 0; i < count; i++)
            {
                string Op = OpS.Pop();
                if (Op.Equals("+"))
                {
                    dynamic Num1 = NumS.Pop();
                    dynamic Num2 = NumS.Pop();
                    AddExpression<dynamic> E = new AddExpression<dynamic>(new TerminalExpression<dynamic>(Num1), new TerminalExpression<dynamic>(Num2));

                    NumS.Push(E.solve());
                    ret = E.solve();
                }
                else if (Op.Equals("-"))
                {
                    dynamic Num1 = NumS.Pop();
                    dynamic Num2 = NumS.Pop();
                    SubstractExpression<dynamic> E = new SubstractExpression<dynamic>(new TerminalExpression<dynamic>(Num1), new TerminalExpression<dynamic>(Num2));

                    NumS.Push(E.solve());
                    ret = E.solve();
                }
            }
            return ret;
        }
    }
}