using WpfApplication1.ViewModels;

namespace WpfApplication1.Commands
{
    public class SwithMainWindowTemplate2 :CommandBase
    {
        public MainWindowViewModel SwithMain;
        public override void Execute(object parameter)
        {
            SwithMain.WindowTemplate = "second";
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}