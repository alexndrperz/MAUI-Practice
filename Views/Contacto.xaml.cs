
using MauiApp1.Models;
using System.Collections.ObjectModel;

namespace MauiApp1.Views;

public partial class Contacto : ContentPage
{
	public Contacto()
	{
		InitializeComponent();
	
		List<ContactInfo> contacts = ContactRepository.GetContacts();

		biografiaDeKevin.ItemsSource =  contacts;

	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		List<ContactInfo> contacts = ContactRepository.GetContacts();
		biografiaDeKevin.ItemsSource = new ObservableCollection<ContactInfo>(contacts);	
    }

    private async void biografiaDeKevin_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if(biografiaDeKevin.SelectedItem != null)
		{
			await Shell.Current.GoToAsync($"{nameof(EditContacto)}?Id={((ContactInfo)biografiaDeKevin.SelectedItem).Id}");
		}
		
    }

    private void biografiaDeKevin_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        biografiaDeKevin.SelectedItem = null;
    }
}


