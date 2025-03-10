using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using ARGUS.ViewModels;

namespace ARGUS.Views
{
    public sealed partial class DatabasesPage : Page
    {
        public DatabasesPage()
        {
            this.InitializeComponent();
            this.DataContext = new DatabasesViewModel();
        }

        private void DatabasesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DatabasesListView.SelectedItem is ListViewItem selectedItem)
            {
                string selectedTag = selectedItem.Tag.ToString();
                var viewModel = (DatabasesViewModel)this.DataContext;
                viewModel.NavigateToPageCommand.Execute(selectedTag);
            }
        }
    }
}