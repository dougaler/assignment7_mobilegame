using System.Xml.Linq;

namespace assignment6;

public partial class ContactsPage : ContentPage
{
	public List<ContactsGroup> Contact = new List<ContactsGroup>();
	public ContactsPage()
	{
		InitializeComponent();
		// programmers note: credit to chatgpt for the names and descriptions
		Contact.Add(new ContactsGroup("A", new List<Contacts>
		{
			new Contacts(){ Name="Aidan", ImageName="pic1.PNG", Email="Aidan@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Friend, met during a cooking class for beginners."},
			new Contacts(){ Name="Archer", ImageName="pic3.PNG", Email="Archer@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Family, cousin on my father’s side."},
		}));
		Contact.Add(new ContactsGroup("D", new List<Contacts>
		{
			new Contacts(){ Name="Dakota", ImageName="pic2.PNG", Email="Dakota@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Coworker, we both work as programmers at a tech startup."},
			new Contacts(){ Name="Demi", ImageName="pic2.PNG", Email="Demi@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Friend, met at a local farmer’s market."},
			new Contacts(){ Name="Dylan", ImageName="pic3.PNG", Email="Dylan@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Coworker, works as head of marketing at tech startup."}

		}));
		Contact.Add(new ContactsGroup("J", new List<Contacts>
		{
			new Contacts(){ Name="Jamie", ImageName="pic4.PNG", Email="Jamie@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Friend, met at a music festival last summer."},
			new Contacts(){ Name="Jasper", ImageName="pic1.PNG", Email="Jasper@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Friend, met at a friend’s birthday party a couple of years ago."},
			new Contacts(){ Name="Julia", ImageName="pic4.PNG", Email="Julia@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Family, my aunt on my mother’s side."},
			new Contacts(){ Name="Julian", ImageName="pic1.PNG", Email="Julian@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Coworker, met at a tech conference a year ago."}
		}));
		Contact.Add(new ContactsGroup("K", new List<Contacts>
		{
			new Contacts(){ Name="Kai", ImageName="pic3.PNG", Email="Kai@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Coworker, we both work as programmers at a tech startup."},
			new Contacts(){ Name="Kara", ImageName="pic4.PNG", Email="Kara@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Friend, met at a bookstore café one rainy afternoon."}
		}));
		Contact.Add(new ContactsGroup("S", new List<Contacts>
		{
			new Contacts(){ Name="Sierra", ImageName="pic2.PNG", Email="Sierra@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Family, my sister."},
			new Contacts(){ Name="Sophie", ImageName="pic2.PNG", Email="Sophie@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Friend, met at an art gallery opening downtown."},
			new Contacts(){ Name="Soren", ImageName="pic3.PNG", Email="Soren@fakeemail.com", PhoneNumber="xxx-xxx-xxxx", Description="Coworker, is my boss at tech startup"}

		}));
		LVContacts.ItemsSource = Contact;
	}


	private void LVContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var selectedItems = e.CurrentSelection.FirstOrDefault() as Contacts;
		if (selectedItems == null) return;
		Navigation.PushAsync(new ContactsDetailsPage(selectedItems));
		((CollectionView)sender).SelectedItems = null;
	}
}