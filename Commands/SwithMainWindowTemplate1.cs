using WpfApplication1.ViewModels;

namespace WpfApplication1.Commands
{
    public class SwithMainWindowTemplate1 : CommandBase
    {
        public MainWindowViewModel SwithMain;
        public override void Execute(object parameter)
        {
            SwithMain.WindowTemplate = "Main";
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}