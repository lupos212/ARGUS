using Microsoft.UI.Xaml.Controls;
using ARGUS.ViewModels;

namespace ARGUS.Views
{
    public sealed partial class ToolsPage : Page
    {
        public ToolsPage()
        {
            this.InitializeComponent();
            this.DataContext = new ToolsViewModel();
        }
    }
}