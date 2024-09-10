namespace _5MSwitch
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void onSwitchToggled(object sender, EventArgs e)
        {
            if (swSwitch1.IsToggled)
                lblStan.Text = "switch ON";
            else
                lblStan.Text = "switch off";

        }
        private void onSw2ON(object sender, EventArgs e)
        {
            swSwitch2.IsToggled = true;
        }
        private void onSw2OFF(object sender, EventArgs e)
        {
            swSwitch2.IsToggled = false;
        }
    }
}
