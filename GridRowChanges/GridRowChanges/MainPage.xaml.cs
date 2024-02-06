using System.ComponentModel;

namespace GridRowChanges
{
    public class ViewModel : INotifyPropertyChanged
    {
        private int gridRow = 1;
        public int GridRow
        {
            get => gridRow;
            set
            {
                if (gridRow != value)
                {
                    gridRow = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GridRow)));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }

    public partial class MainPage : ContentPage
    {
        public ViewModel ViewModel { get; } = new();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ViewModel.GridRow = ViewModel.GridRow == 0 ? 1 : 0;
        }
    }
}
