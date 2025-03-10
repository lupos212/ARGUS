using System.ComponentModel;

namespace ARGUS.ViewModels
{
    public class ConfidentialInformantViewModel : INotifyPropertyChanged
    {
        private bool isAuthenticated;
        private string correctPassword = "YourSecurePassword"; // Replace with your actual password logic

        public bool IsAuthenticated
        {
            get => isAuthenticated;
            set
            {
                if (isAuthenticated != value)
                {
                    isAuthenticated = value;
                    OnPropertyChanged(nameof(IsAuthenticated));
                }
            }
        }

        public ConfidentialInformantViewModel()
        {
            IsAuthenticated = false;
        }

        public void CheckPassword(string password)
        {
            if (password == correctPassword)
            {
                IsAuthenticated = true;
            }
            else
            {
                // Handle incorrect password logic
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}