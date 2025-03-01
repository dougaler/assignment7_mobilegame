namespace assignment6;

public partial class ContactsDetailsPage : ContentPage
{
	public ContactsDetailsPage(Contacts item)
	{
		InitializeComponent();
		ContactsImage.Source = item.ImageName;
		LblName.Text = item.Name;
		LblEmail.Text = item.Email;
		LblPhoneNumber.Text = item.PhoneNumber;
		LblDsc.Text = item.Description;
	}
}