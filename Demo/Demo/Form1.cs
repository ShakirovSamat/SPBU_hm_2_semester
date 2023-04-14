using Microsoft.Win32;

namespace Demo
{
    public partial class Form1 : Form
    {
        Color buttonColor;
        public Form1()
        {
            InitializeComponent();
        }

        private void MainButtonClick(object sender, EventArgs e)
        {
            buttonColor = mainButton.BackColor;
            mainButton.BackColor = Color.Violet;

        }

        private void MainButtonMouseLeave(object sender, EventArgs e)
        {
            mainButton.BackColor = buttonColor;
        }

        private void mainButton_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            mainButton.Location = new Point(random.Next(0, 1280), random.Next(0, 720));
            mainButton.Text = mainButton.BackColor.ToString();
        }
    }
}