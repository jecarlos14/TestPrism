using System;
using Prism.Commands;
using Prism.Mvvm;

namespace TestPrism
{
    public class MainPageViewModel : BindableBase
    {
        private int firstValue;
        public int FirstValue
        {
            get => firstValue;
            set => SetProperty(ref firstValue, value);
        }

        private int secondValue;
        public int SecondValue
        {
            get => secondValue;
            set => SetProperty(ref secondValue, value);
        }

        private int result;
        public int Result
        {
            get => result;
            set => SetProperty(ref result, value);
        }

        public DelegateCommand CalculeResultCommand { get; }

        public MainPageViewModel()
        {
            CalculeResultCommand = new DelegateCommand(() => Result = firstValue+secondValue);
        }
    }
}
