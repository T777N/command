using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp14.Command
{
    public class MessageCommand : ICommand
    {
        //public event EventHandler CanExecuteChanged;

        //private Action _action;

        //public MessageCommand(Action action)
        //{
        //    _action = action;
        //}

        //public bool CanExecute(object parameter)
        //{
        //    MessageBox.Show("a");
        //    return true;
        //}

        //public void Execute(object parameter)
        //{
        //    _action.Invoke();
        //}
        public event EventHandler CanExecuteChanged;
        private Action _action;

        public MessageCommand(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action.Invoke();
        }
    }
}
