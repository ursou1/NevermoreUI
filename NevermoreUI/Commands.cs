
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NevermoreUI
{
    public class Commands : ICommand
    {
        Action action;
        public event EventHandler CanExecuteChanged;

        public Commands(Action action)
        {
            this.action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}

