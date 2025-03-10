using Microsoft.UI.Xaml.Controls;
using ARGUS.ViewModels;

namespace ARGUS.Views
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
            this.DataContext = new HomePageViewModel();
        }
    }
}