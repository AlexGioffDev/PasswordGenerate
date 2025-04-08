namespace PasswordGenerator;

public partial class MainPage : ContentPage
{
	String password = "";

	public MainPage()
	{
		InitializeComponent();
	}


	private void OnGenerate(object sender, EventArgs e)
	{
		password = "";
		String characters = "abcdefghijklmnopqrstuvzyxABCDEFGHIJKLMONPQRSTUVZXY0123456789!()[]{}?";
		for (int i = 0; i < 15; i++)
		{
			Random rand = new();
			int index = rand.Next(characters.Length);
			char value = characters[index];
			password += value;
		}

		PasswordText.Text = password;
		CopyButton.IsEnabled = true;
	}

	private async void OnCopy(object sender, EventArgs e)
	{
		await Clipboard.SetTextAsync(PasswordText.Text);

		PasswordText.Text = "Password copied!";
		password = "";
		CopyButton.IsEnabled = false;

		await Task.Delay(1000);

		PasswordText.Text = "Click to generate a new password";

	}
}

