using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

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
        private bool startOrStopProgram;

        public void Start()
        {
            startOrStopProgram = true;
            NLogger.NlogInfo(startOrStopProgram);
            IsCorrect = "false";
            Random number = new Random();
            variableA = number.Next(100);
            variableB = number.Next(100);
            VisibleExpression = $"{variableA}+{variableB}";
           
            
        }

        public void Answerbutton()
        {
            int answer = 0;
            int resultat = 0;
            answer = Convert.ToInt32(Answer);
            resultat = variableA + variableB;
            if (resultat == answer)
            {
                IsCorrect = "true"; 
                startOrStopProgram = false;
                NLogger.NlogInfo(startOrStopProgram);
            }
            NLogger.NlogWarnAnswer(IsCorrect,VisibleExpression, answer);
        }

        public string A
        {
            get => _variableA;
            set => this.RaiseAndSetIfChanged(ref _variableA, value);
        }

        public string Resultat
        {
            get => _resultat;
            set => this.RaiseAndSetIfChanged(ref _resultat, value);
        }


        public string B
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
