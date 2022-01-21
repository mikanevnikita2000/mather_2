using System;

namespace mather_2.Models
{
    public class Models
    {
        public static string CorrectTrue = "";
        public static string CorrectFalse = "";
        public static string sing = "+";
        public static string result_end = "";

        public static string Start(string sang)
        {
            sing = sang;
            CorrectTrue = "";
            CorrectFalse = "";
            int variableA=0;
            int variableB=0;
            int result = 0;
            string outputExample = "";
            Random randomNumber = new Random();
            if (sing == "/")
            {
                result = randomNumber.Next(1, 11);
                variableB = randomNumber.Next(1, 100);
                variableA = result * variableB;
            }
            if (sing == "*")
            {
                variableA = randomNumber.Next(1, 100);
                variableB = randomNumber.Next(1, 11);
                result = variableA * variableB;
            }
            if (sing == "+")
            {
                variableA = randomNumber.Next(100);
                variableB = randomNumber.Next(100);
                result = variableA + variableB;
            }
            if (sing == "-")
            {
               
                variableA = randomNumber.Next(100);
                variableB = randomNumber.Next(100);
                result = variableA - variableB;
                
            }
            outputExample = $"{variableA} {sing} {variableB} = ";
            mather_2.Models.FeaturesExample.Example(outputExample, result); 
            return outputExample;
        }

        public static string Back()
        {
            string outputExample = "";
            (outputExample) = mather_2.Models.FeaturesExample.Back();
            return outputExample;
        }

        public static (string, string) AnswerGetter(int answer)
        {
            int result = 0;
            CorrectTrue = "";
            CorrectFalse = "";
            result = mather_2.Models.FeaturesExample.Answer();

            if (answer == result)
            {
                CorrectTrue = "Правильно";
                mather_2.Models.FeaturesExample.Back();
                result_end = "";
            }
            else
            {
                CorrectFalse = "Неправильно";
            }
            return (CorrectTrue, CorrectFalse);
        }

        public static string Help()
        {
            result_end = Convert.ToString(mather_2.Models.FeaturesExample.Answer());
            return result_end;
        }
    }
}
