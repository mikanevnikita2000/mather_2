using Avalonia.Media;
using ReactiveUI;
using System;

namespace mather_2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        Models.Models ki = new Models.Models();
        private string _answer = "";
        private int answer ;
        private string _outputExample = "";
        private string _variableA = "";
        private string _variableB = "";
        private string _result = "";
        private string sign = "+";
        private string _resultEnd = "";
        private string _visibleExpressionBack = "";
        private string message = "";
        private string _isCorrectTrue = "";
        private string _isCorrectFalse = "";

        public void Start()
        {
            OutputExample = ki.Start(sign);
            ResultEnd = "";
            IsCorrectTrue = "";
            IsCorrectFalse = "";
            Message = "";
        }

        public void Help()
        {
            ResultEnd = ki.Help();
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
            OutputExample = ki.Back();
        }

        public void ProcessingAnswer()
        {
            Message = "";
            try
            {
                answer = Convert.ToInt32(Answer);
            }
            catch (Exception e)
            {
                Message = "Пиши цифрами!"; 
                IsCorrectTrue = "";
                Console.WriteLine(e.Message);
            }
            (IsCorrectTrue, IsCorrectFalse)  = ki.ProcessingAnswer(answer);
            MainModel();
        }
        private IBrush _textbox3Foreground;
        public IBrush Textbox3Foreground
        {
            get { return _textbox3Foreground; }
            set
            {
                this.RaiseAndSetIfChanged(ref _textbox3Foreground, value);
            }
        }

        public void MainModel()
        {
            if (IsCorrectTrue == "Правильно")
            {
                Textbox3Foreground = Avalonia.Media.Brushes.Green;
            }
            if (IsCorrectFalse == "Неправильно")
            {
                Textbox3Foreground = Avalonia.Media.Brushes.Red;
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
        public string IsCorrectTrue
        {
            get => _isCorrectTrue;
            set => this.RaiseAndSetIfChanged(ref _isCorrectTrue, value);
        }
        public string IsCorrectFalse
        {
            get => _isCorrectFalse;
            set => this.RaiseAndSetIfChanged(ref _isCorrectFalse, value);
        }
        public string VisibleExpressionBack
        {
            get => _visibleExpressionBack;
            set => this.RaiseAndSetIfChanged(ref _visibleExpressionBack, value);
        }
        public string OutputExample
        {
            get => _outputExample;
            set => this.RaiseAndSetIfChanged(ref _outputExample, value);
        }
    }
}