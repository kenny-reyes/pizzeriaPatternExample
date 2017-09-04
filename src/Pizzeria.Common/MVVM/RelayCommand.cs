using System;
using System.Windows.Input;

namespace Pizzeria.Common.MVVM
{
    public class RelayCommand : ICommand
    {
        private readonly Action _methodToExecute;

        public Func<bool> CanExecuteEvaluator { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action methodToExecute, Func<bool> canExecuteEvaluator)
        {
            _methodToExecute = methodToExecute;
            CanExecuteEvaluator = canExecuteEvaluator;
        }

        public RelayCommand(Action methodToExecute)
            : this(methodToExecute, null)
        {
        }

        public bool CanExecute(object parameter)
        {
            if (CanExecuteEvaluator == null)
            {
                return true;
            }
            var result = CanExecuteEvaluator.Invoke();
            return result;
        }

        public void Execute(object parameter)
        {
            _methodToExecute.Invoke();
        }
    }
}