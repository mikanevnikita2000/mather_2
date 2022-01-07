using System;

namespace mather_2
{
    public class Models
    {
        public static string isCorrectTrue = "";
        public static string isCorrectFalse = "";
        public static string visibleExpression = "";
        public static int variableA;
        public static int variableB;
        public static int answer;
        public static int result = 0;
        public static string sing = "+";
        public static string result_end = "";
        public static int variableABack = 0;
        public static int variableBBack = 0;
        public static string signBack = "";
        public static string VisibleExpressionBack = "";
        public static Random randomNumber = new Random();

        public static string Start(string sang)
        {
            sing = sang;
            isCorrectTrue = "";
            isCorrectFalse = "";
            if (sing == "/")
            {
                result = randomNumber.Next(1, 11);
                variableB = randomNumber.Next(1, 100);
                variableA = result * variableB;
                visibleExpression = $"{variableA} / {variableB} = ";
            }
            if (sing == "*")
            {
                variableA = randomNumber.Next(1, 100);
                variableB = randomNumber.Next(1, 11);
                visibleExpression = $"{variableA} * {variableB} = ";
            }
            else
            {
                variableA = randomNumber.Next(100);
                variableB = randomNumber.Next(100);
                visibleExpression = $"{variableA} {sing} {variableB} = ";
            }
            return visibleExpression;
        }

        public static string Back()
        {
            visibleExpression = VisibleExpressionBack;
            variableA = variableABack;
            variableB = variableBBack;
            sing = signBack;
            return visibleExpression;
        }

        public static (string, string) AnswerGetter(int answer)
        {
            isCorrectTrue = "";
            isCorrectFalse = "";
            if (sing == "+")
            {
                result = variableA + variableB;
            }
            if (sing == "-")
            {
                result = variableA - variableB;
            }
            if (sing == "*")
            {
                result = variableA * variableB;
            }
            


            if (answer == result)
            {
                isCorrectTrue = "Правильно";
                VisibleExpressionBack = $"{variableA} {sing} {variableB} = ";
                variableABack = variableA;
                variableBBack = variableB;
                signBack = sing;
                result_end = "";
            }
            else
            {
                isCorrectFalse = "Неправильно";
            }
            return (isCorrectTrue, isCorrectFalse);
        }

        public static string Help()
        {
            if (sing == "+")
            {
                result = variableA + variableB;
                result_end = Convert.ToString(result);          
            }
            if (sing == "-")
            {
                result = variableA - variableB;
                result_end = Convert.ToString(result);
            }
            if (sing == "*")
            {
                result = variableA * variableB;
                result_end = Convert.ToString(result);
            }
            if (sing == "/")
            {
                result_end = Convert.ToString(result);
            }
            return result_end;
        }
    }
}
