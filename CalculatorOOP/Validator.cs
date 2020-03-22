using System;
using System.Collections.Generic;

namespace Validation
{
    class Tokens
    {
        private string text;
        private string type;

        public string Text { get => text; }
        public string Type { get => type; }

        public Tokens()
        {
        }
        public Tokens(string text, string type)
        {
            this.text = text;
            this.type = type;
        }

        public override string ToString()
        {
            return "Token: " + text + "\nType: " + type;
        }
    }
    class Validator
    {
        public static bool Validate(List<string> tokens)
        {
            List<Tokens> tokenList = Categorize(tokens);
            int i, comma, count;
            int end = tokenList.Count-1;
            Tokens prev = new Tokens();
            Tokens curr;

            for (i = 0; i < tokenList.Count; i++)
            {
                curr = tokenList[i];
                if (i > 0)
                    prev = tokenList[i - 1];

                switch (tokenList[i].Type)
                {
                    case "op":
                        //Operator hanya bisa didahului oleh angka dan diikuti angka atau tanda negatif (angka < 0)
                        if (i == 0 || !(prev.Type.Equals("num") && !prev.Type.Equals("op")))
                        {
                            Console.WriteLine("Op exception");
                            throw new Exception();
                        }
                        break;
                    case "neg":
                        //Tanda '-' tidak bisa diikuti operator kec. negatif (double negative)
                        count = 1;
                        while (count <= 2 && curr.Type.Equals("neg"))
                        {
                            count++;
                        }
                        if (count > 2 || i == end || tokenList[i + 1].Type.Equals("op") || (i == 0 && count > 1))
                        {
                            Console.WriteLine("Neg exception");
                            throw new Exception();
                        }
                        i += count - 1;
                        break;
                    case "root":
                        //Root tidak bisa diiikuti operator
                        Console.WriteLine("Root");
                        if (i == end || tokenList[i + 1].Type.Equals("op") || tokenList[i + 1].Type.Equals("neg"))
                        {
                            Console.WriteLine("Root exception");
                            throw new Exception();
                        }
                        break;
                    default:
                        Console.WriteLine("Num");
                        comma = 0;
                        foreach (var chr in tokenList[i].Text)
                        {
                            if (chr == ',')
                            {
                                comma++;
                            }
                        }
                        //Suatu angka hanya bisa memiliki max. 1 comma (real value)
                        if (comma > 1 || (i != end && tokenList[i+1].Type.Equals("root")))
                        {
                            Console.WriteLine("Num exception");
                            throw new Exception();
                        }
                        break;
                }
            }
            return true;
        }

        public static List<Tokens> Categorize(List<string> tokens)
        {
            string[] op = { ":", "x", "+" };
            string neg = "-";
            List<Tokens> tokenList = new List<Tokens>();
            foreach (var item in tokens)
            {
                if (item.Equals(neg))
                {
                    tokenList.Add(new Tokens(item, "neg"));
                }
                else if (Array.Exists(op, opr => opr.Equals(item)))
                {
                    tokenList.Add(new Tokens(item, "op"));
                }
                else if (item.Equals("√"))
                {
                    tokenList.Add(new Tokens(item, "root"));
                }
                else
                {
                    tokenList.Add(new Tokens(item, "num"));
                }
            }
            return tokenList;
        }
    }
}
