using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace mather_2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string answer = "0";
        private string _visibleExpression = "0"; 
        private string correct_answer_or_not = "false";
        private string _num1 = "0";
        private string _num2 = "0";


        public void Click()
        {
            int num1 = 0;
            int num2 = 0;
            int answer = 0;
            string visibleExpression = "";
            int resultat = 0;
            bool correct_answer_or_not = false;
            Random g = new Random();
            num1 = g.Next(100);
            num2 = g.Next(100);


            visibleExpression = $"{num1}+{num2}";
            answer = num1 + num2;
            if (resultat == answer)
            {
                correct_answer_or_not = true;
            }
        }

        public string Num
        {
            get => _num1;
            set => this.RaiseAndSetIfChanged(ref _num1, value);
        }


        public string Num2
        {
            get => _num2;
            set => this.RaiseAndSetIfChanged(ref _num2, value);
        }

        public string Answer
        {
            get => answer;
            set => this.RaiseAndSetIfChanged(ref answer, value);
        }
        public string Сorrect_answer_or_not
        {
            get => correct_answer_or_not;
            set => this.RaiseAndSetIfChanged(ref correct_answer_or_not, value);
        }
        public string VisibleExpression
        {
            get => _visibleExpression;
            set => this.RaiseAndSetIfChanged(ref _visibleExpression, value);
        }
    }
    
}
