using System.ComponentModel;

namespace ARGUS.ViewModels
{
    public class CaseViewModel : INotifyPropertyChanged
    {
        private string caseTitle;
        public string CaseTitle
        {
            get => caseTitle;
            set
            {
                if (caseTitle != value)
                {
                    caseTitle = value;
                    OnPropertyChanged(nameof(CaseTitle));
                }
            }
        }

        public CaseViewModel()
        {
            // Initialize your ViewModel properties here
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}