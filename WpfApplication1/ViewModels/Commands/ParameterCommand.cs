using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication1.ViewModels.Commands
{
    public class ParameterCommand : ICommand

    {
        public event EventHandler CanExecuteChanged;
        public ViewModelBase ViewModel { get; set; }
        public ParameterCommand(ViewModelBase viewModel)
        {
            this.ViewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                var s = parameter as string;
                if (String.IsNullOrEmpty(s.Trim()))
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.ParameterMethod(parameter as string);
        }
    }
}
