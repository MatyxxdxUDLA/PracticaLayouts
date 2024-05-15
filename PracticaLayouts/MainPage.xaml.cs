namespace PracticaLayouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnInitialButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayout());
        }
    }

}
