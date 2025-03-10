using System.ComponentModel;

namespace ARGUS.ViewModels
{
    public class DatabasesViewModel : INotifyPropertyChanged
    {
        public DatabasesViewModel()
        {
            // Initialize your ViewModel properties and commands here
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}