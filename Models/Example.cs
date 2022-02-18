using System;

namespace mather_2.Models
{
    public class Example 
    { 
        public  int result = 0;
        public  string visibleExpression = "";
        public int lastresult = 0;
        public string lastvisibleExpression = "";

        public string GetLastVisibleExpression { get; internal set; }

        public  void GeneratExample(string sign)
        {
            int variableA = 0;
            int variableB = 0;
            Random randomNumber = new Random();
            if (sign == "/")
            {
                GetResultFinite = randomNumber.Next(1, 10);
                variableB = randomNumber.Next(1, 100);
                variableA = result * variableB;
            }
            if (sign == "*")
            {
                variableA = randomNumber.Next(1, 100);
                variableB = randomNumber.Next(1, 11);
                GetResultFinite = variableA * variableB;
            }
            if (sign == "+")
            {
                variableA = randomNumber.Next(100);
                variableB = randomNumber.Next(100);
                GetResultFinite = variableA + variableB;
            }
            if (sign == "-")
            {
                variableA = randomNumber.Next(100);
                variableB = randomNumber.Next(100);
                GetResultFinite = variableA - variableB;
            }
            GetVisibleExpression = $"{variableA} {sign} {variableB} = ";
        }
        public string GetVisibleExpression
        {
            get => visibleExpression;
            set => visibleExpression = value;
        }
        public int GetResultFinite
        {
            get => result;
            set => result = value;
        }
        

    }
}
