namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        private object? oldFlyoutContent;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (Application.Current?.MainPage is Shell shell)
            {
                object oldFlyoutContent = shell.FlyoutContent;
                shell.FlyoutContent = this.oldFlyoutContent;
                this.oldFlyoutContent = oldFlyoutContent;
            }
        }
    }

}
