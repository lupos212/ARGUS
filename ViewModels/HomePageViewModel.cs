using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ARGUS.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        private string welcomeMessage;

        public string WelcomeMessage
        {
            get => welcomeMessage;
            set
            {
                welcomeMessage = value;
                OnPropertyChanged();
            }
        }

        public HomePageViewModel()
        {
            WelcomeMessage = "Welcome to ARGUS";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}