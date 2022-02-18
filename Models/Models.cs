using System;

namespace mather_2.Models
{
    public class Models
    {
        Example example = new Example();

        public string correctnessAnswer = "";
        public string sign = "+";
        public string result_end ="";
        public string visibleExpression = "";
        public int lastResult = 0;
        public string lastVisibleExpression = "";
        public int result = 1;
        public bool isBack = false;
        public int lastresult = 0;
        public string lastvisibleExpression = "";

        //PropertiesExample currentExample= null;
        //PropertiesExample lastExample= null;


        public string GeneratingAnExample(string _sign)
        {
            example.GeneratExample(_sign);
            return example.GetVisibleExpression; ;
        }

        public string Back()
        {
            isBack = true;
            return example.GetVisibleExpression;
        }

        public string ProcessingAnswer(int answer)
        {
            result = example.GetResultFinite;

            correctnessAnswer = "";
           
            if (isBack == true)
            {
                result = example.GetResultFinite;
            }
            if (answer == result)
            {
                correctnessAnswer = "Правильно";
                result_end = Convert.ToString(result);
                GetLastResultFinite = result;
                GetLastVisibleExpression = visibleExpression;
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
            return Convert.ToString(example.GetResultFinite);
        }

        public int GetLastResultFinite
        {
            get => lastresult;
            set => lastresult = value;
        }
        public string GetLastVisibleExpression
        {
            get => lastvisibleExpression;
            set => lastvisibleExpression = value;
        }
    }
}
