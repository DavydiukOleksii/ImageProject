using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfClient.View.Infrastructure
{
    public class RelayCommand: ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        #region Constructor
        public RelayCommand(Action<object> execute)
            :this(execute, null)
        { }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null) 
        { 
            if(execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            _execute = execute;
            _canExecute = canExecute;
        }
        #endregion

        //визначає, коли кнопка може бути використана, а коли ні 
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute.Invoke(parameter);
        }

        //виконується, коли міг змінитися стан canExecute, змушує елементи перевіряти стан виконання команди
        public event EventHandler CanExecuteChanged
        {
            add 
            {
                CommandManager.RequerySuggested += value;
            }
            remove 
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        //запускає логіку команди
        public void Execute(object parameter) 
        {
            _execute.Invoke(parameter);
        }
    }
}
