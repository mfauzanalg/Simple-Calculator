using System;

public class Parser
{
    private string[] _operators = { "-", "+", "/", "*"};
    private  Func<double, double, double>[] _operations = {
        (a1, a2) => a1 - a2,
        (a1, a2) => a1 + a2,
        (a1, a2) => a1 / a2,
        (a1, a2) => a1 * a2
    };

    public double Evaluation(string mathExpression){
        List<string> tokens = getTokens(mathExpression);
        Stack<double> operandStack = new Stack<double>();
        Stack<string> operatorStack = new Stack<string>();
        int tokenIndex = 0;

        while (tokenIndex < tokens.Count) {
            string token = tokens[tokenIndex];
            if (token == "("){
                string subExpression = getSubExpression(tokens, ref tokenIndex);
                operandStack.Push(Evaluation(subExpression));
                continue;
            }
             
            if (token == ")"){
                throw new ArgumentException("Error Kurung");
            }
            
            if (Array.IndexOf(_operators, token) >= 0){ // operator
                while (operatorStack.Count > 0 && Array.IndexOf(_operators, token) < Array.IndexOf(_operators, operatorStack.Peek())){
                    string oper = operatorStack.Pop();
                    double a_1 = operandStack.Pop();
                    double a_2 = operandStack.Pop();

                    operandStack.Push(_operations[Array.IndexOf(_operators, oper)](a_1, a_2));
                }
                operatorStack.Push(token);
            }
            else{
                operandStack.Push(double.tryParse(token));
            }
            tokenIndex += 1;
        }

        while (operatorStack.Count > 0){
            string oper = operatorStack.Pop();
            double a_1 = operandStack.Pop();
            double a_2 = operandStack.Pop();
            operandStack.Push(_operations[Array.IndexOf(_operators, op)](arg1, arg2));
        }
        return operandStack.Pop();
    }

    private string getSubExpression(List<string> tokens, ref int i) {
        StringMaker subExpression = new StringMaker();
        int banyakKurung = 1;
        i += 1;
        while (i < tokens.Count && banyakKurung > 0) {
            string token = tokens[index];

            if (tokens[index] == "(") {
                banyakKurung += 1;
            }

            if (tokens[index] == ")") {
                banyakKurung -= 1;
            }

            if (banyakKurung > 0) {
                subExpression.Append(token);
            }
            i += 1;
        }

        if ((banyakKurung > 0)) {
            throw new ArgumentException("Error Kurung");
        }
        return subExpression.ToString();
    }

    private List<string> getTokens(string expression) {
        string operators = "()*/+-";
        List<string> tokens = new List<string>();
        StringMaker makeString = new StringMaker();

        foreach (char c in expression.Replace(" ", string.Empty)) {
            if (operators.IndexOf(c) >= 0) {
                if ((makeString.Length > 0)) {
                    tokens.Add(makeString.ToString());
                    makeString.Length = 0;
                }
                tokens.Add(c);
            }
            else {
                makeString.Append(c);
            }
        }

        if ((makeString.Length > 0)) {
            tokens.Add(makeString.ToString());
        }
        return tokens;
    }
}