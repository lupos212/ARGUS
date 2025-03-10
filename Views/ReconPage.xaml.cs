using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using ARGUS.ViewModels;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ARGUS.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReconPage : Page
    {
        public ReconPage()
        {
            this.InitializeComponent();
            this.DataContext = new ReconViewModel();
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
