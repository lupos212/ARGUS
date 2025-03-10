using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using ARGUS.Views;

namespace ARGUS
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(HomePage)); // Default page
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItemContainer != null)
            {
                var selectedItem = (NavigationViewItem)args.SelectedItemContainer;
                switch (selectedItem.Tag)
                {
                    case "HomePage":
                        ContentFrame.Navigate(typeof(HomePage));
                        break;
                    case "ToolsPage":
                        ContentFrame.Navigate(typeof(ToolsPage));
                        break;
                    case "DatabasesPage":
                        ContentFrame.Navigate(typeof(DatabasesPage));
                        break;
                    case "DataEntryPage":
                        ContentFrame.Navigate(typeof(DataEntryPage));
                        break;
                    case "ReportsPage":
                        ContentFrame.Navigate(typeof(ReportsPage));
                        break;
                    case "SettingsPage":
                        ContentFrame.Navigate(typeof(SettingsPage));
                        break;
                }
            }
        }
    }
}