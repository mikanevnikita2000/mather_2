using System;

namespace mather_2.Models
{
    public class Models
    {
        ExampleProperties exampleProperties = new ExampleProperties();

        public  string CorrectTrue = "";
        public  string CorrectFalse = "";
        public  string sing = "+";
        public  string result_end ="";
        public  string outputExample = "";
        public int lastResult = 0;
        public string lastOutPutExample = "";
        public int result = 0;

        public  string Start(string _sing)
        {
            sing = _sing;
            exampleProperties.Example(sing);
            (outputExample, result) = exampleProperties.Result_finite();
            return outputExample;
        }

        public  string Back()
        {
            result = lastResult;
            return lastOutPutExample;
        }

        public  (string, string) ProcessingAnswer(int answer)
        {
            (outputExample, result) = exampleProperties.Result_finite();
            CorrectTrue = "";
            CorrectFalse = "";

            if (answer == result)
            {
                CorrectTrue = "Правильно";
                result_end = Convert.ToString(result);
                lastResult = result;
                lastOutPutExample = outputExample;
            }
            else
            {
                CorrectFalse = "Неправильно";
            }
            return (CorrectTrue, CorrectFalse);
        }

        public  string Help()
        {
            (outputExample, result) = exampleProperties.Result_finite();
            result_end = Convert.ToString(result);
            return result_end;
        }
    }
}
