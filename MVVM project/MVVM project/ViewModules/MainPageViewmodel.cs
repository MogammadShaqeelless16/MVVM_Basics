using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_project.ViewModules
{
    public class MainPageViewmodule : INotifyPropertyChanged
    {
        private string _demoText;

        public string DemoText
        {
            get { return _demoText; }
            set { _demoText = value;
                OnPropertyChanged("demo text");
            }

      
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewmodule()
        {
            // making an instance of a command  to call on a later time 
            TestButtonCommand = new Command(() => testbutton());
        }

        private void OnPropertyChanged(string propertyName)
        {
            var propertyHandler = PropertyChanged;

           if (propertyHandler != null)
            {
                propertyHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //button running in viewmodules 

        public ICommand TestButtonCommand { get; set; }

        private void testbutton()
        {
            DemoText = "bob the builder";
        }

    }
}
