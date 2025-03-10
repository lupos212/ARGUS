using ARGUS.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace ARGUS.Views
{
    public sealed partial class CasePage : Page
    {
        public CasePage()
        {
            this.InitializeComponent();
            this.DataContext = new CaseViewModel();
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