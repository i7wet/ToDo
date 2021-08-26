using WpfApplication1.ViewModels;

namespace WpfApplication1.Commands
{
    public class SwithTemplate2 :CommandBase
    {
        public MainWindowViewModel Swith;
        public override void Execute(object parameter)
        {
            Swith.SomeProp = "Template2";
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}