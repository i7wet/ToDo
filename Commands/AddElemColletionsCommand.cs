using System.Collections.ObjectModel;

namespace WpfApplication1.Commands 
{
    public class AddElemToMassiveCommand : CommandBase
    {
        public ObservableCollection<string> one;
         public AddElemToMassiveCommand(ObservableCollection<string> listOne)
        {
            one = listOne;
        }
        public override void Execute(object parameter)
        {
            one.Add("asa") ;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }                                                
    }
}