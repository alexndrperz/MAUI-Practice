using MauiApp1.Models;

namespace MauiApp1.Views;

[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContacto : ContentPage
{
	private ContactInfo? _contact; 
	public EditContacto()
	{
		InitializeComponent();
	}


	public string ContactId
	{
		set
		{
			_contact = ContactRepository.GetContactById(int.Parse(value));

			if(_contact != null)
			{
				entryName.Text = _contact.Name;
				entryEmail.Text = _contact.Email;
				entryPhone.Text = _contact.Phone;
				entryDirection.Text = _contact.Direction;
				
			}

        }
	}




    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }

    private  void btnUpdate_Clicked(object sender, EventArgs e)
    {
		if(nameValid.IsNotValid)
		{
			DisplayAlert("Error", "Nombre es requerido", "Ok");
			return;
		}

		if(emailValidator.IsNotValid)
		{
			foreach(var error in emailValidator.Errors)
			{
				DisplayAlert("Error", error.ToString(), "Ok");
			}
			return;


		}
		if(_contact != null)
		{
			_contact.Name = entryName.Text;
			_contact.Email = entryEmail.Text;
			_contact.Direction = entryDirection.Text;
			_contact.Phone = entryPhone.Text;

        } else
		{
			return;
		}
		ContactRepository.UpdateContact(_contact?.Id ?? 0, _contact);
		 Shell.Current.GoToAsync("..");
    }
}