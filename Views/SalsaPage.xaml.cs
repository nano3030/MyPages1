namespace MyPages1.Views;

public partial class SalsaPage : ContentPage
{
	public SalsaPage()
	{
		InitializeComponent();
	}

    private void BtnMainRecipePage_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}