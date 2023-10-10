namespace ShapeResize
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Add(object sender, EventArgs e)
        {
            line.Y2 = Math.Min(400.0, line.Y2 + 50.0);
        }

        private void Button_Clicked_Subtract(object sender, EventArgs e)
        {
            line.Y2 = Math.Max(0.0, line.Y2 - 50.0);
        }
    }
}
