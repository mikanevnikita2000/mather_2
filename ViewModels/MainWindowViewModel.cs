using Avalonia.Media;
using ReactiveUI;
using System;

namespace mather_2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        Models.Models models = new Models.Models();
        private string _answer = "";
        private int answer ;
        private string _visibleExpression = "";
        private string _variableA = "";
        private string _variableB = "";
        private string _result = "";
        private string sign = "+";
        private string _resultEnd = "";
        private string _visibleExpressionBack = "";
        private string message = "";
        private string _isCorrect = "";
        private IBrush _colourTextboxCorrect;

        public void Start()
        {
            VisibleExpression = models.GeneratingAnExample(sign);
            ResultEnd = "";
            IsCorrect = "";
            Message = "";
        }

        public void Help()
        {
            ResultEnd = models.Help();
        }

        public void Addition()
        {
            sign = "+";
           
        }
        public void Subtraction()
        {
            sign = "-";
        }
        public void Multiplication()
        {
            sign = "*";
        }
        public void Division()
        {
            sign = "/";
        }

        public void Back()
        {
            VisibleExpression = models.Back();
        }

        public void ErrorChecking()
        {
            Message = "";
            try
            {
                answer = Convert.ToInt32(Answer);
            }
            catch (Exception e)
            {
                Message = "Пиши цифрами!";
                IsCorrect = "";
                Console.WriteLine(e.Message);
            }

            CheckingExample();
        }
        
        public void CheckingExample()
        {
            IsCorrect = models.ProcessingAnswer(answer);
            if (IsCorrect == "Правильно")
            {
                ColourTextboxCorrect = Avalonia.Media.Brushes.Green;
            }
            if (IsCorrect == "Неправильно")
            {
                ColourTextboxCorrect = Avalonia.Media.Brushes.Red;
            }
        }

        public string VariableA
        {
            get => _variableA;
            set => this.RaiseAndSetIfChanged(ref _variableA, value);
        }
        public string Message
        {
            get => message;
            set => this.RaiseAndSetIfChanged(ref message, value);
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
        public IBrush ColourTextboxCorrect
        {
            get { return _colourTextboxCorrect; }
            set
            {
                this.RaiseAndSetIfChanged(ref _colourTextboxCorrect, value);
            }
        }
    }
}