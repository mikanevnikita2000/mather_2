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
        private string znack = "+";
        private string _resultatEnd = "";
        private string _visibleExpressionBack = "";
        int resultat = 0;
        private int variableABack = 0;
        private int variableBBack = 0;
        private string _znackBack = "+";

        public void Start()
        {
            isProgramRuning = true;
            NLogger.NlogInfo(isProgramRuning);
            IsCorrect = "false";
            Random randomNumber = new Random();
            variableA = randomNumber.Next(100);
            variableB = randomNumber.Next(100);
            VisibleExpression = $"{variableA} {znack} {variableB} = ";
            ResultatEnd = "";


        }

        public void Help()
        {
            if (znack == "+")
            {
                resultat = variableA + variableB;
                ResultatEnd = Convert.ToString(resultat);
            }
            if (znack == "-")
            {
                resultat = variableA - variableB;
                ResultatEnd = Convert.ToString(resultat);
            }
            if (znack == "*")
            {
                resultat = variableA * variableB;
                ResultatEnd = Convert.ToString(resultat);
            }
            if (znack == "/")
            {
                resultat = variableA / variableB;
                ResultatEnd = Convert.ToString(resultat);
            }
        }

        public string Slo()
        {
            znack = "+";
            return znack;
        }
        public string Vech()
        {
            znack = "-";
            return znack;
        }
        public string Umno()
        {
            znack = "*";
            return znack;
        }
        public string Del()
        {
            znack = "/";
            return znack;
        }

        public void Back()
        {
            VisibleExpression = VisibleExpressionBack;
            variableA = variableABack;
            variableB = variableBBack;
            znack = _znackBack;
        }

        public void AnswerGetter()
        {
            int answer ;
            
            answer = Convert.ToInt32(Answer);

            if (znack == "+")
            {
                resultat = variableA + variableB;
            }
            if (znack == "-")
            {
                resultat = variableA - variableB;
            }
            if (znack == "*")
            {
                resultat = variableA * variableB;
            }
            if (znack == "/")
            {
                resultat = variableA / variableB;
            }

            if (resultat == answer)
            {
                IsCorrect = "true";
                isProgramRuning = false;
                VisibleExpressionBack = $"{variableA} {znack} {variableB} = ";
                variableABack = variableA;
                variableBBack = variableB;
                _znackBack = znack;          
            }
        }

        public string VariableA
        {
            get => _variableA;
            set => this.RaiseAndSetIfChanged(ref _variableA, value);
        }
        public string ResultatEnd
        {
            get => _resultatEnd;
            set => this.RaiseAndSetIfChanged(ref _resultatEnd, value);
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
