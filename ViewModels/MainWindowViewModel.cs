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
        private string _correct_answer_or_not = "false";
        private string _num1 = "0";
        private string _num2 = "0";
        private string _resultat = "";

        public void Start()
        {
            int num1 = 0;
            int num2 = 0;
            Random g = new Random();
            num1 = g.Next(100);
            num2 = g.Next(100);
            int pressing = 0;
            string visibleExpression = "";
            visibleExpression = $"{num1}+{num2}";
            VisibleExpression = visibleExpression.ToString();
            
            pressing = Click();
            
            if (pressing==2)
            {
                Click1(num1, num2);
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
        public void Click1(int num1, int num2)
        {
            int answer = 0;
            int resultat = 0;
            Random g = new Random();
            answer = Convert.ToInt32(Answer);
            resultat = num1 + num2;
            if (resultat == answer)
            {
                Сorrect_answer_or_not = "true";
            }

            Сorrect_answer_or_not = "привет";
        }

        public string Num
        {
            get => _num1;
            set => this.RaiseAndSetIfChanged(ref _num1, value);
        }

        public string Resultat
        {
            get => _resultat;
            set => this.RaiseAndSetIfChanged(ref _resultat, value);
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
            get => _correct_answer_or_not;
            set => this.RaiseAndSetIfChanged(ref _correct_answer_or_not, value);
        }
        public string VisibleExpression
        {
            get => _visibleExpression;
            set => this.RaiseAndSetIfChanged(ref _visibleExpression, value);
        }
    }
    
}
