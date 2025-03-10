using ARGUS.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace ARGUS.Views
{
    public sealed partial class ConfidentialInformantPage : Page
    {
        public ConfidentialInformantPage()
        {
            this.InitializeComponent();
            this.DataContext = new ConfidentialInformantViewModel();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }
    }
}