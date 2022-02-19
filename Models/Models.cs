using System;

namespace mather_2.Models
{
    public class Models
    {
        Example example = new Example();
        LastExample lastExample = new LastExample();

        public string correctnessAnswer = "";
        public string sign = "+";
        //PropertiesExample currentExample= null;
        //PropertiesExample lastExample= null;

        public string GeneratingAnExample(string _sign)
        {
            example.GeneratExample(_sign);
            return example.GetVisibleExpression; ;
        }

        public string Back()
        {
            example.GetResultFinite = lastExample.GetLastResultFinite;
            return lastExample.GetLastVisibleExpression;
        }

        public string ProcessingAnswer(int answer)
        {
            correctnessAnswer = "";
           
            if (answer == example.GetResultFinite)
            {
                correctnessAnswer = "Правильно";
                lastExample.GetLastResultFinite = example.GetResultFinite;
                lastExample.GetLastVisibleExpression = example.GetVisibleExpression;
            }
            else
            {
                correctnessAnswer = "Неправильно";
            }
            return correctnessAnswer;
        }

        public string Help()
        {
            return Convert.ToString(example.GetResultFinite);
        }

       
    }
}
