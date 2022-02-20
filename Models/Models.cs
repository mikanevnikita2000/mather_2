using System;

namespace mather_2.Models
{
    public class Models
    {
        Example example = null;
        Example lastExample = null;

        public string correctnessAnswer = "";
        public string sign = "+";

        public string GeneratingAnExample(string _sign)
        {
            example = new Example(_sign);
            return example.VisibleExpression; ;
        }

        public string Back()
        {
            example = lastExample;
            return lastExample.VisibleExpression;
        }

        public string ProcessingAnswer(int answer)
        {
            correctnessAnswer = "";
           
            if (answer == example.ResultFinite)
            {
                correctnessAnswer = "Правильно";
                lastExample = example;
            }
            else
            {
                correctnessAnswer = "Неправильно";
            }
            return correctnessAnswer;
        }

        public string Help()
        {
            return Convert.ToString(example.ResultFinite);
        }

       
    }
}
