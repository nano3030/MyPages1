namespace MyPages1.Views;

public partial class ChipsPage : ContentPage
{
	public ChipsPage()
	{
		InitializeComponent();
	}

    private void BtnMainRecipePage_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"//{nameof(MainRecipePage)}");

	}
}