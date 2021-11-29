using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace mather_2.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _otvet = "0";
        private string _visibleExpression = "0"; 
        private string torf = "false";
        private string _num1 = "0";
        private string _num2 = "0";


        public void Click()
        {
            int num1 = 0;
            int num2 = 0;
            int otvet = 0;
            string visibleExpression = "";
            int resultat = 0;
            bool rorf = false;
            Random g = new Random();
            num1 = g.Next(100);
            num2 = g.Next(100);


            visibleExpression = $"{num1}+{num2}";
            otvet = num1 + num2;
            if (resultat == otvet)
            {
                rorf = true;
            }
            Torf = rorf.ToString();
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

        public string Otvet
        {
            get => _otvet;
            set => this.RaiseAndSetIfChanged(ref _otvet, value);
        }
        public string Torf
        {
            get => torf;
            set => this.RaiseAndSetIfChanged(ref torf, value);
        }
        public string VisibleExpression
        {
            get => _visibleExpression;
            set => this.RaiseAndSetIfChanged(ref _visibleExpression, value);
        }
    }
    
}
