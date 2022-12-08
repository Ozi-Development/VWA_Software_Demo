using VWA_Software_Demo.Core;

namespace VWA_Software_Demo.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public SelectionViewModel SelectionVM { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            SelectionVM = new SelectionViewModel();
        }
    }
}
