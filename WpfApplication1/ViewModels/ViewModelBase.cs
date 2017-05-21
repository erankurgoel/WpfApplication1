using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using WpfApplication1.ViewModels.Commands;

namespace WpfApplication1.ViewModels
{
    public class ViewModelBase
    {
        public SimpleCommand SimpleCommand { get; set; }
        public ParameterCommand ParameterCommand { get; set; }
        public ViewModelBase()
        {
            this.SimpleCommand = new SimpleCommand(this);
            this.ParameterCommand = new ParameterCommand(this); 
        }

        public void SimpleMethod()
        {
            Debug.WriteLine("Simple method called.");
            //return "simple method";
        }

        public void ParameterMethod(string person)
        {
            Debug.WriteLine(person);
        }
    }
}
