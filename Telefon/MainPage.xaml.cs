namespace Telefon
{
    public partial class MainPage : ContentPage
    {
        private bool IsRoot = true;
        private int Count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOneClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "1";
                IsRoot = false;
            }
            else
                Number.Text += "1";
            Count++;
            if (Count % 3 == 0)
                Number.Text += " ";
            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnTwoClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "2";
                IsRoot = false;
            }
            else
                Number.Text += "2";
            Count++;
            if (Count % 3 == 0)
                Number.Text += " ";
            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnThreeClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "3";
                IsRoot = false;
            }
            else
                Number.Text += "3";
            Count++;
            if (Count % 3 == 0)
                Number.Text += " ";
            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnFourClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "4";
                IsRoot = false;
            }
            else
                Number.Text += "4";
            Count++;
            if (Count % 3 == 0)
                Number.Text += " ";
            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnFiveClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "5";
                IsRoot = false;
            }
            else
                Number.Text += "5";
            Count++;
            if (Count % 3 == 0)
                Number.Text += " ";
            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnSixClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "6";
                IsRoot = false;
            }
            else
                Number.Text += "6";
            Count++;
            if (Count % 3 == 0)
                Number.Text += " ";
            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnSevenClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "7";
                IsRoot = false;
            }
            else
                Number.Text += "7";
            Count++;
            if (Count % 3 == 0)
                Number.Text += " ";
            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnEightClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "8";
                IsRoot = false;
            }
            else
                Number.Text += "8";
            Count++;
            if (Count % 3 == 0)
                Number.Text += " ";
            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnNineClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "9";
                IsRoot = false;
            }
            else
                Number.Text += "9";
            Count++;
 
            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnZeroClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "0";
                IsRoot = false;
            }
            else
                Number.Text += "0";
            Count++;
            if (Count % 3 == 0)
                Number.Text += " ";
            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnDeleteClicked(object sender, EventArgs e)
        {
            if (Number.Text.Length<=1 && !IsRoot)
            {
                Number.Text = "000";
                IsRoot = true;
                Count = 0;
            }
            else if (!IsRoot)
            {
                Number.Text = Number.Text.Remove(Number.Text.Length - 1);
                if (Count % 3 == 0)
                    Number.Text = Number.Text.Remove(Number.Text.Length - 1);
                Count--;
            }

            SemanticScreenReader.Announce(Number.Text);

        }
        private void OnStarClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "*";
                IsRoot = false;
            }
            else
                Number.Text += "*";
            SemanticScreenReader.Announce(Number.Text);
        }
        private void OnHashClicked(object sender, EventArgs e)
        {
            if (IsRoot)
            {
                Number.Text = "#";
                IsRoot = false;
            }
            else
                Number.Text += "#";
            SemanticScreenReader.Announce(Number.Text);
        }
        private async void OnCallClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Dzwonienie", Number.Text, "OK");
        }
    }
}