namespace MauiApp1;
[QueryProperty(nameof(User_Name), "username")]
[QueryProperty(nameof(Age), "age")]
public partial class HomePage : ContentPage
{
	public string User_Name { get; set; }
	public string Age { get; set; }
	public HomePage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		LblUserName.Text = $"Username: {User_Name}";
		LblAge.Text = $"Age: {Age}";
	}

	private void Button_clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync("..");
		//Shell.Current.GoToAsync("../AnotherPage");
	}

}