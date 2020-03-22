using System;
using System.Collections.Generic;

// Validate input string
namespace Validation
{
    // Exception class
    public class InvalidExpression : Exception
    {
        public InvalidExpression(String message) : base(message)
        {
        }
    }

    // Class token to validate
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
    }

    // Validator class
    class Validator
    {
        public static bool Validate(List<string> tokens)
        {
            List<Tokens> tokenList = Categorize(tokens);
            int i, comma;
            int end = tokenList.Count - 1;
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
                        if (i == 0)
                        {
                            throw new InvalidExpression("Invalid 1st \nOperator");
                        }
                        else if (!(prev.Type.Equals("num") && !prev.Type.Equals("op")))
                        {
                            throw new InvalidExpression("Operator \nbefore Operator");
                        }
                        break;
                    case "neg":
                        //Tanda '-' tidak bisa diikuti operator kec. negatif (double negative)
                        if (i == end)
                        {
                            throw new InvalidExpression("Operator \nat the end");
                        }
                        else if (tokenList[i + 1].Type.Equals("op"))
                        {
                            throw new InvalidExpression("Operator \nbefore Operator");
                        }
                        break;
                    case "root":
                        //Root tidak bisa diiikuti operator
                        if (i == end)
                        {
                            throw new InvalidExpression("Operator \nat the end");
                        }
                        else if (tokenList[i + 1].Type.Equals("op"))
                        {
                            throw new InvalidExpression("Operator \nbefore Operator");
                        }
                        break;
                    default:
                        comma = 0;
                        foreach (var chr in tokenList[i].Text)
                        {
                            if (chr == ',')
                            {
                                comma++;
                            }
                        }
                        //Suatu angka hanya bisa memiliki max. 1 comma (real value)
                        if (comma > 1)
                        {
                            throw new InvalidExpression("Comma more than 1");
                        }
                        else if ((i != end && tokenList[i + 1].Type.Equals("root")))
                        {
                            throw new InvalidExpression("Root after Comma");
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
