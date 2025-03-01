using System.Net.Sockets;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
		public MainPage()
		{
			InitializeComponent();
		}



		private void OnClicked(object sender, EventArgs e)
		{
			bool isEmail = Email.Text.Contains(".com");
			if (Username.Text == null || Username.Text == "")
			{
				DisplayAlert("Empty Entry", "Username cannot remain empty", "ok");
			}
			else if (Email.Text == null || Email.Text == "")
			{
				DisplayAlert("Empty Entry", "Email cannot remain empty", "ok");
			}
			else if (Password.Text == null || Password.Text == "")
			{
				DisplayAlert("Empty Entry", "Password cannot remain empty", "ok");
			}
			else if (ConfPassword.Text == null || ConfPassword.Text == "")
			{
				DisplayAlert("Empty Entry", "Password Confirmation cannot remain empty", "ok");
			}
			else if (!isEmail)
			{
				DisplayAlert("Invalid Email", "Email must be a valid email address", "ok");
			}else if (Password.Text != ConfPassword.Text)
			{
				DisplayAlert("Password Mismatch", "The passwords do not match", "ok");
			}
				
			var myData = new Dictionary<string, object>
			{
				{"username",$"{Username.Text}" },
				{"email",$"{Email.Text}"},
				{"password",$"{Password.Text}"}
			};

			Shell.Current.GoToAsync($"{nameof(UserPage)}?username={Username.Text}&email={Email.Text}&password={Password.Text}");
			
		}
	}

}
