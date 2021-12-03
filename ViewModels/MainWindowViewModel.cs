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

        public void Start()
        {
            int variableA = 0;
            int variableB = 0;
            Random number = new Random();
            variableA = number.Next(100);
            variableB = number.Next(100);
            int pressing = 0;
            VisibleExpression = $"{variableA}+{variableB}";
            
            pressing = Click();
            
            if (pressing==2)
            {
                Click1(variableA, variableB);
            }
        }
        public int Click()
        {

            int pressing = 0;
            if (pressing==2)
            {
                pressing = 0;
            }
            pressing = pressing + 1;
            
            return pressing;
        }
        public void Click1(int variableA, int variableB)
        {
            int answer = 0;
            int resultat = 0;
            answer = Convert.ToInt32(Answer);
            resultat = variableA + variableB;
            if (resultat == answer)
            {
                IsCorrect = "true";
            }
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
