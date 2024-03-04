namespace MyPages1.Views;

public partial class MainRecipePage : ContentPage
{
	public MainRecipePage()
	{
		InitializeComponent();
	}

    private void BtnSalsa_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(SalsaPage));

    }

    private void BtnChips_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ChipsPage));
    }
}