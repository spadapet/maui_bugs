namespace ShellHotReload
{
    public class Person
    {
        public string Name { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.BindingContext = new List<Person>()
            {
                new() { Name = "Person 1" },
                new() { Name = "Person 2" },
                new() { Name = "Person 3" },
                new() { Name = "Person 4" },
                new() { Name = "Person 5" },
            };

            InitializeComponent();
        }
    }
}
