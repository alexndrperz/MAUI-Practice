namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            miLabel.Text = $" Ha clickeado {count} veces";

            SemanticScreenReader.Announce(miLabel.Text);
        }
    }

}
