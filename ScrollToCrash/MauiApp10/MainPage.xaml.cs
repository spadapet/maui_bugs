using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp10
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<string> Items { get; } = [ "Foo", "Bar", "Baz", "Goo" ];

        private string selectedItem = string.Empty;
        public string SelectedItem
        {
            get => selectedItem;
            set
            {
                if (this.selectedItem != value)
                {
                    this.selectedItem = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedItem)));
                }
            }
        }
    }

    public partial class MainPage : ContentPage
    {
        public ViewModel ViewModel { get; } = new();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (!Stack.Remove(ItemList))
            {
                Stack.Add(ItemList);
            }

            ItemList.ScrollTo(ViewModel.SelectedItem);
        }
    }
}
