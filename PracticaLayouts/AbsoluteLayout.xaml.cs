namespace PracticaLayouts;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
        InitializeComponent();
	}
    private void GoToHomeButton(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}