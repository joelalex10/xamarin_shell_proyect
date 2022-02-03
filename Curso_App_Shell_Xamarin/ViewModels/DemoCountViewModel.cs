using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Curso_App_Shell_Xamarin.ViewModels
{
    public class DemoCountViewModel: BaseViewModel
    {
        private int _numberIncrement;

        public Command IncrementCommand { get; set; }
        public int NumberIncrement
        {
            get => _numberIncrement;
            set
            {
                _numberIncrement = value;
                OnPropertyChanged();
            }
        }

        public DemoCountViewModel()
        {
            IncrementCommand = new Command(() =>
            {
                NumberIncrement++;
            });
        }
    }
}
