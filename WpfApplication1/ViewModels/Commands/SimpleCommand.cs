using System;
using System.Windows.Input;

namespace WpfApplication1.ViewModels.Commands
{
    public class SimpleCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ViewModelBase ViewModel { get; set; }
        public SimpleCommand(ViewModelBase viewModelBase)
        {
            this.ViewModel = viewModelBase;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.SimpleMethod();         
        }
    }
}
