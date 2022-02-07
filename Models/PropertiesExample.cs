using System;

namespace mather_2.Models
{
    public class PropertiesExample //свойства примера
    { 

        public  int result = 0;
        public  string visibleExpression = "";

        public  void Example(string sign)
        {
            int variableA = 0;
            int variableB = 0;
            Random randomNumber = new Random();
            if (sign == "/")
            {
                result = randomNumber.Next(1, 10);
                variableB = randomNumber.Next(1, 100);
                variableA = result * variableB;
            }
            if (sign == "*")
            {
                variableA = randomNumber.Next(1, 100);
                variableB = randomNumber.Next(1, 11);
                result = variableA * variableB;
            }
            if (sign == "+")
            {
                variableA = randomNumber.Next(100);
                variableB = randomNumber.Next(100);
                result = variableA + variableB;
            }
            if (sign == "-")
            {
                variableA = randomNumber.Next(100);
                variableB = randomNumber.Next(100);
                result = variableA - variableB;
            }
            visibleExpression = $"{variableA} {sign} {variableB} = ";
        }

        public  (string, int) ResultFinite()
        {
            return (visibleExpression, result);
        }
        
    }
}
