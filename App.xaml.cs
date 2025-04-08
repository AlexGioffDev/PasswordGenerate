namespace PasswordGenerator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		var window = new Window(new MainPage());

		window.Height = window.MinimumHeight = window.MaximumHeight = 350;
		window.Width = window.MinimumWidth = window.MaximumWidth = 800;

		return window;
	}
}