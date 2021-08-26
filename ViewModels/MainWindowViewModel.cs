using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows;
using WpfApplication1.Commands;
using Timer = System.Threading.Timer;

namespace WpfApplication1.ViewModels
{
    public class MainWindowViewModel : Base.ViewModels
    {
        private MainWindowViewModel testVM ;
        private string windowTemplate;
        private string someProp;
        private string timerValue;
        public SwithTemplate1 swithTemplate1;
        public SwithTemplate2 swithTemplate2;
        public SwithMainWindowTemplate1 swithMainWindowTemplate1;
        public SwithMainWindowTemplate2 swithMainWindowTemplate2;        
        public CommandBase addElemCommand; 
        public CommandBase delElemCommand;
        ObservableCollection<string> listOne;
        
        #region Публичные свойства

        public SwithMainWindowTemplate1 SwithMainWindowTemplate1
        {
            get
            {
                return swithMainWindowTemplate1;
            }
            set
            {
                swithMainWindowTemplate1 = value;
            }
        }

        public SwithMainWindowTemplate2 SwithMainWindowTemplate2
        {
            get
            {
                return swithMainWindowTemplate2;
            }
            set
            {
                swithMainWindowTemplate2 = value;
            }
        }

        public MainWindowViewModel TestVM
        {
            get
            {
                return testVM;
            }
            set
            {
                testVM = value;
                OnPropertyChanged();
            }
        }

        public string WindowTemplate
        {
            get
            {
                return windowTemplate;
            }
            set
            {
                windowTemplate = value;
                OnPropertyChanged();
            }
        }
        
        
        public string SomeProp
        {
            get
            {
                return someProp;
            }
            set
            {
                someProp = value;
                OnPropertyChanged();
            }
        }
      
        public SwithTemplate1 SwithTemplate1
        {
            get
            {
                return swithTemplate1;
            }
            set
            {
                swithTemplate1 = value;
            }
        }
       
        public SwithTemplate2 SwithTemplate2
        {
            get
            {
                return swithTemplate2;
            }
            set
            {
                swithTemplate2 = value;
            }
        }

        public ObservableCollection<string> ListOne
        {
            get
            {
                return listOne;
            }
            set
            {
                listOne = value;
                
            }
        }
        
        public CommandBase AddElemCommand
        {
            get
            {
                return addElemCommand;
            }
            set
            {
                addElemCommand = value;
            }
        }
        
        public CommandBase DelElemCommand
        {
            get
            {
                return delElemCommand;
            }
            set
            {
                delElemCommand = value;
            }
        }
        public string TimerValue
        {
            get => timerValue;
            set
            {
                if (Equals(timerValue, value)) return;
                timerValue = value;
                OnPropertyChanged();
                Set(ref timerValue, value);
            }
            //get
            //{
            //  return timerValue;
            //}
            // set => Set(ref timerValue,value);
            // set
            // {
            // timerValue = value;
            // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TimerValue"));
            // }
        }
        #endregion
        
        #region Methods
        private void Callback(object state)
        {
            TimerValue = DateTime.Now.ToString();
        }
        
        #endregion
        public MainWindowViewModel()
        {
            TestVM = this;
            swithTemplate1 = new SwithTemplate1();
            swithTemplate2 = new SwithTemplate2();
            swithTemplate1.Swith = this;
            swithTemplate2.Swith = this;
            
            swithMainWindowTemplate1 = new SwithMainWindowTemplate1();
            swithMainWindowTemplate2 = new SwithMainWindowTemplate2();
            swithMainWindowTemplate1.SwithMain = this;
            swithMainWindowTemplate2.SwithMain = this;

            ListOne = new ObservableCollection<string> {"asa", "aaa", "a","asaa"};
            addElemCommand = new AddElemToMassiveCommand(ListOne);
            delElemCommand = new DelElemCollectionsCommand(ListOne);
            
            TimerValue = null;
            var g = TimerValue;
            new Timer(Callback,null,0,300);
        }
    }
}

