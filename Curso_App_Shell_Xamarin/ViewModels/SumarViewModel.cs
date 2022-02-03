using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Curso_App_Shell_Xamarin.ViewModels
{
    public class SumarViewModel:BaseViewModel
    {
        private int _resultado;

        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
        public Command SumarCommand { get; set; }
        public int Resultado
        {
            get => _resultado;
            set
            {
                _resultado = value;
                OnPropertyChanged();
            }
        }
        public SumarViewModel()
        {
            SumarCommand = new Command(SumarValores);
        }
        public void SumarValores()
        {
            Resultado = Valor1 + Valor2;
        }
    }
}
