using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parsing;
using Ekspresi;
using Validation;
using CalculatorOOP;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calcu = new Calculator();

            Calcu.Input = "1+1";
            Calcu.Input = Calcu.Input.Replace(".", ",");
            Calcu.Lstring = Parse.makeList(Calcu.Input);

            try
            {
                bool valid = Calcu.Validate(Calcu.Lstring);
                if (Calcu.Lstring.Count != 1)
                {
                    Calcu.Hasil = Solving.solver(Calcu.Lstring).ToString();
                    Calcu.Hasil = Calcu.Hasil.Replace(",", ".");
                    Console.WriteLine(Calcu.Hasil);
                    Calcu.Ans = Calcu.Hasil;
                }
                else
                {
                    Calcu.Ans = Calcu.Input.Replace(",", ".");
                }
            }
            catch (InvalidExpression Error)
            {
                Console.WriteLine("Hasil : " + Error.Message);
            }

             /*string input = "10.2.3";
             Console.WriteLine("Input : " + input);
             input = input.Replace('.', ',');
             List<string> hasil = new List<string>();
             hasil = Parse.makeList(input);

             try
             {
                 bool valid = Validator.Validate(hasil);
                 dynamic c = Solving.solver(hasil);
                 String kk = c.ToString();
                 Console.WriteLine("Hasil : " + kk.Replace(',', '.'));
                 Console.ReadLine();
             }
             catch (InvalidExpression Error)
             {
                 Console.WriteLine("Hasil : " + Error.Message);
             }
            
            dynamic Num1 = 5;
            RootExpression<dynamic> E = new RootExpression<dynamic>(new TerminalExpression<dynamic>(Num1));
            Console.WriteLine("Terminal Ekspression 1 : " + Num1);
            Console.WriteLine("Hasil RootExpression : " + E.solve()); */

            Console.ReadLine();
        }
    }
}
