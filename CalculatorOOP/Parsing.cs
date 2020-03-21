using System;
using System.Collections.Generic;

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
}