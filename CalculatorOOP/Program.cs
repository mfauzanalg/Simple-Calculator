using System;
using System.Collections.Generic;
using Parsing;
using Validation;

namespace CalculatorOOP 
{
    // Kelas Kalkulator
    public class Calculator
    {
        public string Input;
        public dynamic Hasil;
        public string Ans;
        public List<string> Lstring;
        public Queue<string> Container;

        public Calculator()
        {
            this.Input = "";
            this.Hasil = "";
            this.Ans = "";
            Container = new Queue<string>();
            Lstring = new List<string>();
        }

        public bool Validate(List<string> tokens)
        {
            return Validator.Validate(tokens);
        }

        public List<string> makeList(string input)
        {
            return Parse.makeList(input);
        }

        public dynamic solver(List<string> input)
        {
            return Solving.solver(input);
        }
    }
} 