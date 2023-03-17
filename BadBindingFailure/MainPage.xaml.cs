namespace BadBindingFailure;

public class Person
{
	public string Name { get; set; }
}

public class Company
{
	public List<Person> People { get; } = new()
	{
		new() { Name = "First Person" },
		new() { Name = "Second Person" },
		new() { Name = "Third Person" },
		new() { Name = "Fourth Person" },
    };
}

public partial class MainPage : ContentPage
{
	public Company Model { get; } = new();

	public MainPage()
	{
		InitializeComponent();
	}
}
