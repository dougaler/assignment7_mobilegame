namespace MauiApp1;
[QueryProperty(nameof(User_Name), "username")]
[QueryProperty(nameof(Email), "email")]
[QueryProperty(nameof(Password), "password")]

public partial class UserPage : ContentPage
{
	public string User_Name { get; set; }
	public string Email { get; set; }
	public string Password { get; set; }
	public UserPage()
	{
		InitializeComponent();
		ContactsImage.Source = "defaultava.jpg";
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		LblUserName.Text = $"Username: {User_Name}";
		LblEmail.Text = $"Email: {Email}";
		LblPassword.Text = $"Password: {Password}";
	}

}
