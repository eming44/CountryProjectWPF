﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CountryWPF
{
    public class MyICommand : ICommand
    {

        Action _TargetExecuteMethod;
        Func<bool> _TargetCanExecuteMethod;
        public event EventHandler CanExecuteChanged = delegate { };

        public MyICommand(Action executeMethod)
        {
            _TargetExecuteMethod = executeMethod;
        }
        public MyICommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            _TargetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
        bool ICommand.CanExecute(object parameter)
        {

            if (_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod();
            }

            if (_TargetExecuteMethod != null)
            {
                return true;
            }

            return false;
        }
        void ICommand.Execute(object parameter)
        {
            if (_TargetExecuteMethod != null)
            {
                _TargetExecuteMethod();
            }
        }
    }
}
