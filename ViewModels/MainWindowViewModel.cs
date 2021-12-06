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
        private string _resultat = "";
        private int variableA = 0;
        private int variableB = 0;
        private bool isProgramRuning;

        public void Start()
        {
            isProgramRuning = true;
            NLogger.NlogInfo(isProgramRuning);
            IsCorrect = "false";
            Random randomNumber = new Random();
            variableA = randomNumber.Next(100);
            variableB = randomNumber.Next(100);
            VisibleExpression = $"{variableA}+{variableB}";
           
            
        }

        public void AnswerGetter()
        {
            int answer = 0;
            int resultat = 0;
            answer = Convert.ToInt32(Answer);
            resultat = variableA + variableB;
            if (resultat == answer)
            {
                IsCorrect = "true";
                isProgramRuning = false;
                NLogger.NlogInfo(isProgramRuning);
            }
            NLogger.NlogWarnAnswer(IsCorrect,VisibleExpression, answer);
        }

        public string VariableA
        {
            get => _variableA;
            set => this.RaiseAndSetIfChanged(ref _variableA, value);
        }

        public string Resultat
        {
            get => _resultat;
            set => this.RaiseAndSetIfChanged(ref _resultat, value);
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
        public string VisibleExpression
        {
            get => _visibleExpression;
            set => this.RaiseAndSetIfChanged(ref _visibleExpression, value);
        }

        
    }
    
}
