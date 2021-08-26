using WpfApplication1.ViewModels;

namespace WpfApplication1.Commands
{
    public class SwithTemplate1 : CommandBase
    {
        public MainWindowViewModel Swith;
        public override void Execute(object parameter)
        {
            Swith.SomeProp = "Template1";
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}