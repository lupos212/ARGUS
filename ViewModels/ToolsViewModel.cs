using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ARGUS.ViewModels
{
    public class ToolsViewModel : INotifyPropertyChanged
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

        public ToolsViewModel()
        {
            WelcomeMessage = "A R G U S   T O O L S";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}