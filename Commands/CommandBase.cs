using System;
using System.Windows.Input;

namespace WpfApplication1.Commands
{
    public abstract class CommandBase :ICommand
    {
        public virtual bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }
        public virtual void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value;}
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}