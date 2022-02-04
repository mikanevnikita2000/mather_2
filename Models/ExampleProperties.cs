using System;

namespace mather_2.Models
{
    public class ExampleProperties //свойства примера
    { 

        public  int result = 0;
        public  string outputExample = "";
        

        public  void Example(string sing)
        {
            
            string singExample = sing;
            int variableA = 0;
            int variableB = 0;
            Random randomNumber = new Random();
            if (singExample == "/")
            {
                result = randomNumber.Next(1, 10);
                variableB = randomNumber.Next(1, 100);
                variableA = result * variableB;
            }
            if (singExample == "*")
            {
                variableA = randomNumber.Next(1, 100);
                variableB = randomNumber.Next(1, 11);
                result = variableA * variableB;
            }
            if (singExample == "+")
            {
                variableA = randomNumber.Next(100);
                variableB = randomNumber.Next(100);
                result = variableA + variableB;
            }
            if (singExample == "-")
            {
                variableA = randomNumber.Next(100);
                variableB = randomNumber.Next(100);
                result = variableA - variableB;
            }
            outputExample = $"{variableA} {singExample} {variableB} = ";
        }

        public  (string, int) Result_finite()
        {
            return (outputExample, result);
        }
    }
}
