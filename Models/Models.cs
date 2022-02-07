using System;

namespace mather_2.Models
{
    public class Models
    {
        PropertiesExample propertiesExample = new PropertiesExample();

        public string isCorrect = "";
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
            (visibleExpression, result) = propertiesExample.ResultFinite();
            return visibleExpression;
        }

        public string Back()
        {
            isBack = true;
            return lastVisibleExpression;
        }

        public string ProcessingAnswer(int answer)
        {
            (visibleExpression, result) = propertiesExample.ResultFinite();

            isCorrect = "";
           
            if (isBack == true)
            {
                result = lastResult;
            }
            if (answer == result)
            {
                isCorrect = "Правильно";
                result_end = Convert.ToString(result);
                lastResult = result;
                lastVisibleExpression = visibleExpression;
                isBack = false;
            }
            else
            {
                isCorrect = "Неправильно";
            }
            return isCorrect;
        }

        public string Help()
        {
            (visibleExpression, result) = propertiesExample.ResultFinite();
            result_end = Convert.ToString(result);
            return result_end;
        }
    }
}
