using System;
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
                // Kalau Ketemu Operator
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
            dynamic Ret = 0;
            Boolean isNow = false;
            Stack<double> NumS = new Stack<double>();
            Stack<string> OpS = new Stack<string>();

            // Memisahkan ke dalam stack
            for (int i = 0; i < input.Count; i++)
            {
                // Kalau operator masuk sini
                if (input[i].Equals("+") || input[i].Equals("-") || input[i].Equals("x") || input[i].Equals(":") || input[i].Equals("√"))
                {
                    if (!isNow && (input[i].Equals("x") || input[i].Equals(":") || input[i].Equals("-")))
                    {
                        isNow = true;
                        OpS.Push(input[i]);
                    }
                    else if (isNow && input[i].Equals("-"))
                    {
                        if (input[i - 1].Equals("+"))
                        {
                            dynamic Num1 = input[i + 1];
                            NegativeExpression<dynamic> E = new NegativeExpression<dynamic>(new TerminalExpression<dynamic>(Num1));
                            NumS.Push(E.solve());
                            i++;
                            isNow = false;
                        }
                        else if (input[i - 1].Equals("-"))
                        {
                            dynamic Num1 = input[i + 1];
                            NegativeExpression<dynamic> E = new NegativeExpression<dynamic>(new TerminalExpression<dynamic>(Num1));
                            NumS.Push(E.solve());
                            i++;
                            isNow = false;
                        }
                        else
                        {
                            dynamic Num1 = input[i + 1];
                            NegativeExpression<dynamic> E = new NegativeExpression<dynamic>(new TerminalExpression<dynamic>(Num1));

                            dynamic Num3 = E.solve();
                            dynamic Num4 = NumS.Pop();  //Convert.ToDouble(input[i-2]);

                            if (input[i - 1].Equals("x"))
                            {
                                MultiplyExpression<dynamic> E2 = new MultiplyExpression<dynamic>(new TerminalExpression<dynamic>(Num3), new TerminalExpression<dynamic>(Num4));
                                NumS.Push(E2.solve());
                                Ret = E2.solve();
                                isNow = false;
                                i++;
                            }
                            else
                            {
                                DivideExpression<dynamic> E2 = new DivideExpression<dynamic>(new TerminalExpression<dynamic>(Num4), new TerminalExpression<dynamic>(Num3));
                                NumS.Push(E2.solve());
                                Ret = E2.solve();
                                isNow = false;
                                i++;
                            }
                        }
                    }
                    else
                    {
                        OpS.Push(input[i]);
                    }
                }
                else // Kalau angka masuk sini
                {
                    if (isNow)
                    {
                        string Op = OpS.Pop(); // Operatornya
                        if (Op.Equals("x"))
                        {
                            dynamic Num1 = NumS.Pop();
                            dynamic Num2 = Convert.ToDouble(input[i]);
                            MultiplyExpression<dynamic> E = new MultiplyExpression<dynamic>(new TerminalExpression<dynamic>(Num1), new TerminalExpression<dynamic>(Num2));

                            NumS.Push(E.solve());
                            Ret = E.solve();
                        }
                        else if (Op.Equals(":"))
                        {
                            dynamic Num1 = NumS.Pop();
                            dynamic Num2 = Convert.ToDouble(input[i]);
                            DivideExpression<dynamic> E = new DivideExpression<dynamic>(new TerminalExpression<dynamic>(Num1), new TerminalExpression<dynamic>(Num2));

                            NumS.Push(E.solve());
                            Ret = E.solve();
                        }
                        else if (Op.Equals("-"))
                        {
                            dynamic Num1 = input[i];
                            NegativeExpression<dynamic> E = new NegativeExpression<dynamic>(new TerminalExpression<dynamic>(Num1));
                            if (i != 1 && (!input[i - 2].Equals("+") && !input[i - 2].Equals("√")))
                            {
                                OpS.Push("+");
                            }
                            NumS.Push(E.solve());
                        }
                        isNow = false;
                    }
                    else
                    {
                        double P = Convert.ToDouble(input[i]);
                        NumS.Push(P);
                    }
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
                    Ret = E.solve();
                }
                else if (Op.Equals("-"))
                {
                    dynamic Num1 = NumS.Pop();
                    dynamic Num2 = NumS.Pop();
                    SubstractExpression<dynamic> E = new SubstractExpression<dynamic>(new TerminalExpression<dynamic>(Num2), new TerminalExpression<dynamic>(Num1));

                    NumS.Push(E.solve());
                    Ret = E.solve();
                }
                else if (Op.Equals("√"))
                {
                    dynamic Num1 = NumS.Pop();
                    RootExpression<dynamic> E = new RootExpression<dynamic>(new TerminalExpression<dynamic>(Num1));

                    double temp = Convert.ToDouble(E.solve());
                    NumS.Push(temp);
                    Ret = E.solve();
                }
            }
            return Ret;
        }
    }
}