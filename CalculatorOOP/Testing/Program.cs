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

            /*
            Testing Kalkulasi
            1) 2+3
            2) 2-3
            3) 10:2
            4) 10.5x2.3
            5) √99
            6) -5+-5
            7) 5x-10
            8) √10+10
            9) -10+5x-10--5
            10) -10+-5:10--5
            11) 20+-10+√100
            12) -30-100:10+-10+√1000

            Testing Exception
            1) 10:0
            2) √-10
            3) +5-3
            4) 5++2
            5) 12-98-
            6) 12-+32
            7) 10√
            8) √:10
            9) 10.12√2
            10) 10.2.3

            */
            Calcu.Input = "-30-100:10+-10+√1000";
            Console.WriteLine("Input : " + Calcu.Input);
            Calcu.Input = Calcu.Input.Replace(".", ",");
            Calcu.Lstring = Parse.makeList(Calcu.Input);

            //Testing parse
            Console.WriteLine("\nHasil Parse Input");
            foreach (var elmt in Calcu.Lstring) 
            {
                Console.WriteLine(elmt);
            }

                try
            {
                bool valid = Calcu.Validate(Calcu.Lstring);
                if (Calcu.Lstring.Count != 1)
                {
                    Calcu.Hasil = Solving.solver(Calcu.Lstring).ToString();
                    Calcu.Hasil = Calcu.Hasil.Replace(",", ".");
                    Console.WriteLine("\nHasil : " + Calcu.Hasil);
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

            
            // Testing Expression
            double Num1 = 5;
            double Num2 = 4;

            Console.WriteLine("\nTestingExpression");
            AddExpression<dynamic> E = new AddExpression<dynamic>(new TerminalExpression<dynamic>(Num1), new TerminalExpression<dynamic>(Num2));
            Console.WriteLine("Terminal Ekspression 1 : " + Num1);
            Console.WriteLine("Terminal Ekspression 2 : " + Num2);
            Console.WriteLine("Hasil AddExpression : " + E.solve());

            SubstractExpression<dynamic> E2 = new SubstractExpression<dynamic>(new TerminalExpression<dynamic>(Num1), new TerminalExpression<dynamic>(Num2));
            Console.WriteLine("\nTerminal Ekspression 1 : " + Num1);
            Console.WriteLine("Terminal Ekspression 2 : " + Num2);
            Console.WriteLine("Hasil SubstractExpression : " + E2.solve());

            MultiplyExpression<dynamic> E3 = new MultiplyExpression<dynamic>(new TerminalExpression<dynamic>(Num1), new TerminalExpression<dynamic>(Num2));
            Console.WriteLine("\nTerminal Ekspression 1 : " + Num1);
            Console.WriteLine("Terminal Ekspression 2 : " + Num2);
            Console.WriteLine("Hasil MultiplyExpression : " + E3.solve());

            DivideExpression<dynamic> E4 = new DivideExpression<dynamic>(new TerminalExpression<dynamic>(Num1), new TerminalExpression<dynamic>(Num2));
            Console.WriteLine("\nTerminal Ekspression 1 : " + Num1);
            Console.WriteLine("Terminal Ekspression 2 : " + Num2);
            Console.WriteLine("Hasil DivideExpression : " + E4.solve());

            NegativeExpression<dynamic> E5 = new NegativeExpression<dynamic>(new TerminalExpression<dynamic>(Num1));
            Console.WriteLine("\nTerminal Ekspression 1 : " + Num1);
            Console.WriteLine("Hasil NegativeExpression : " + E5.solve());

            RootExpression<dynamic> E6 = new RootExpression<dynamic>(new TerminalExpression<dynamic>(Num1));
            Console.WriteLine("\nTerminal Ekspression 1 : " + Num1);
            Console.WriteLine("Hasil RootExpression : " + E6.solve());




            Console.ReadLine();
        }
    }
}
