namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }



        private void OnCounterClicked(object sender, EventArgs e)
        {
            var myData = new Dictionary<string, object>
            {
                {"username",$"{Username.Text}" },
                {"age",$"{Age.Text}"}
            };

            //Shell.Current.GoToAsync($"{nameof(HomePage)}?username={Username.Text}&age={Age.Text}");
        }
    }

}
