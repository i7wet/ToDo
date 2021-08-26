using System.Collections.ObjectModel;

namespace WpfApplication1.Commands
{
    public class DelElemCollectionsCommand : CommandBase
    {
        public ObservableCollection<string> one;

        public DelElemCollectionsCommand(ObservableCollection<string> listOne)
        {
            one = listOne;
        }
        public override void Execute(object parameter)
        {
            one.Clear();
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}