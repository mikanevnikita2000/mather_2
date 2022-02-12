using System;

namespace mather_2.Models
{
    public class Models
    {
        PropertiesExample propertiesExample = new PropertiesExample();

        public string correctnessAnswer = "";
        public string sign = "+";
        public string result_end ="";
        public string visibleExpression = "";
        public int lastResult = 0;
        public string lastVisibleExpression = "";
        public int result = 1;
        public bool isBack = false;

        //PropertiesExample currentExample= null;
        //PropertiesExample lastExample= null;


        public string GeneratingAnExample(string _sign)
        {
            propertiesExample.Example(_sign);
            return propertiesExample.VisibleExpression; ;
        }

        public string Back()
        {
            isBack = true;
            return lastVisibleExpression;
        }

        public string ProcessingAnswer(int answer)
        {
            result = propertiesExample.ResultFinite;

            correctnessAnswer = "";
           
            if (isBack == true)
            {
                result = lastResult;
            }
            if (answer == result)
            {
                correctnessAnswer = "Правильно";
                result_end = Convert.ToString(result);
                lastResult = result;
                lastVisibleExpression = visibleExpression;
                isBack = false;
            }
            else
            {
                correctnessAnswer = "Неправильно";
            }
            return correctnessAnswer;
        }

        public string Help()
        {
            return Convert.ToString(propertiesExample.ResultFinite);
        }
    }
}
