using ReactiveUI;
using System;

namespace mather_2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _answer = "0";
        private string _visibleExpression = "0";
        private string _isCorrect = "false";
        private string _variableA = "0";
        private string _variableB = "0";
        private string _result = "";
        private int variableA = 0;
        private int variableB = 0;
        private bool isProgramRuning;
        private string sign = "+";
        private string _resultEnd = "";
        private string _visibleExpressionBack = "";
        int result = 0;
        private int variableABack = 0;
        private int variableBBack = 0;
        private string _signBack = "+";

        public void Start()
        {
            isProgramRuning = true;
            NLogger.NlogInfo(isProgramRuning);
            IsCorrect = "false";
            Random randomNumber = new Random();
            variableA = randomNumber.Next(100);
            variableB = randomNumber.Next(100);
            VisibleExpression = $"{variableA} {sign} {variableB} = ";
            ResultEnd = "";


        }

        public void Help()
        {
            if (sign == "+")
            {
                result = variableA + variableB;
                ResultEnd = Convert.ToString(result);
            }
            if (sign == "-")
            {
                result = variableA - variableB;
                ResultEnd = Convert.ToString(result);
            }
            if (sign == "*")
            {
                result = variableA * variableB;
                ResultEnd = Convert.ToString(result);
            }
            if (sign == "/")
            {
                result = variableA / variableB;
                ResultEnd = Convert.ToString(result);
            }
        }

        public string Addition()
        {
            sign = "+";
            return sign;
        }
        public string Subtraction()
        {
            sign = "-";
            return sign;
        }
        public string Multiplication()
        {
            sign = "*";
            return sign;
        }
        public string Division()
        {
            sign = "/";
            return sign;
        }

        public void Back()
        {
            VisibleExpression = VisibleExpressionBack;
            variableA = variableABack;
            variableB = variableBBack;
            sign = _signBack;
        }

        public void AnswerGetter()
        {
            int answer ;
            
            answer = Convert.ToInt32(Answer);

            if (sign == "+")
            {
                result = variableA + variableB;
            }
            if (sign == "-")
            {
                result = variableA - variableB;
            }
            if (sign == "*")
            {
                result = variableA * variableB;
            }
            if (sign == "/")
            {
                result = variableA / variableB;
            }

            if (result == answer)
            {
                IsCorrect = "true";
                isProgramRuning = false;
                VisibleExpressionBack = $"{variableA} {sign} {variableB} = ";
                variableABack = variableA;
                variableBBack = variableB;
                _signBack = sign;          
            }
        }

        public string VariableA
        {
            get => _variableA;
            set => this.RaiseAndSetIfChanged(ref _variableA, value);
        }
        public string ResultEnd
        {
            get => _resultEnd;
            set => this.RaiseAndSetIfChanged(ref _resultEnd, value);
        }
        public string Result
        {
            get => _result;
            set => this.RaiseAndSetIfChanged(ref _result, value);
        }
        public string VariableB
        {
            get => _variableB;
            set => this.RaiseAndSetIfChanged(ref _variableB, value);
        }
        public string Answer
        {
            get => _answer;
            set => this.RaiseAndSetIfChanged(ref _answer, value);
        }
        public string IsCorrect
        {
            get => _isCorrect;
            set => this.RaiseAndSetIfChanged(ref _isCorrect, value);
        }
        public string VisibleExpressionBack
        {
            get => _visibleExpressionBack;
            set => this.RaiseAndSetIfChanged(ref _visibleExpressionBack, value);
        }
        public string VisibleExpression
        {
            get => _visibleExpression;
            set => this.RaiseAndSetIfChanged(ref _visibleExpression, value);
        }
    }
}