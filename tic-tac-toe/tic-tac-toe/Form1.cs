namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        Game game = new Game();

        public void gameStop()
        {
            Node0.Enabled = false;
            Node1.Enabled = false;
            Node2.Enabled = false;
            Node3.Enabled = false;
            Node4.Enabled = false;
            Node5.Enabled = false;
            Node6.Enabled = false;
            Node7.Enabled = false;
            Node8.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void MouseOnClickNode0(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int number);
            if (!game.isSettled(number))
            {
                button.Text = game.currentChar.ToString();
                if (game.currentChar == 'X')
                {
                    player2.ForeColor = Color.Red;
                    player1.ForeColor = Color.White;
                }
                else
                {
                    player2.ForeColor = Color.White;
                    player1.ForeColor = Color.Red;
                }

                char? gameStatus = game.AddValueToNode(number);
                if (gameStatus != null)
                {
                    gameStop();
                }

                if (gameStatus == 'X')
                {
                    textBox1.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    textBox1.Text = "Player two won";
                }
                else if (gameStatus == '=')
                {
                    textBox1.Text = "Dead heat";
                }
            }


        }

        private void MouseOnClickNode1(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int number);
            if (!game.isSettled(number))
            {
                button.Text = game.currentChar.ToString();

                if (game.currentChar == 'X')
                {
                    player2.ForeColor = Color.Red;
                    player1.ForeColor = Color.White;
                }
                else
                {
                    player2.ForeColor = Color.White;
                    player1.ForeColor = Color.Red;
                }

                char? gameStatus = game.AddValueToNode(number);
                if (gameStatus != null)
                {
                    gameStop();
                }

                if (gameStatus == 'X')
                {
                    textBox1.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    textBox1.Text = "Player two won";
                }
                else if (gameStatus == '=')
                {
                    textBox1.Text = "Dead heat";
                }
            }
        }

        private void MouseOnClickNode2(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int number);
            if (!game.isSettled(number))
            {
                button.Text = game.currentChar.ToString();

                if (game.currentChar == 'X')
                {
                    player2.ForeColor = Color.Red;
                    player1.ForeColor = Color.White;
                }
                else
                {
                    player2.ForeColor = Color.White;
                    player1.ForeColor = Color.Red;
                }

                char? gameStatus = game.AddValueToNode(number);
                if (gameStatus != null)
                {
                    gameStop();
                }

                if (gameStatus == 'X')
                {
                    textBox1.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    textBox1.Text = "Player two won";
                }
                else if (gameStatus == '=')
                {
                    textBox1.Text = "Dead heat";
                }
            }
        }

        private void MouseOnClickNode3(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int number);
            if (!game.isSettled(number))
            {
                button.Text = game.currentChar.ToString();

                if (game.currentChar == 'X')
                {
                    player2.ForeColor = Color.Red;
                    player1.ForeColor = Color.White;
                }
                else
                {
                    player2.ForeColor = Color.White;
                    player1.ForeColor = Color.Red;
                }

                char? gameStatus = game.AddValueToNode(number);
                if (gameStatus != null)
                {
                    gameStop();
                }

                if (gameStatus == 'X')
                {
                    textBox1.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    textBox1.Text = "Player two won";
                }
                else if (gameStatus == '=')
                {
                    textBox1.Text = "Dead heat";
                }
            }
        }

        private void MouseOnClickNode4(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int number);
            if (!game.isSettled(number))
            {
                button.Text = game.currentChar.ToString();

                if (game.currentChar == 'X')
                {
                    player2.ForeColor = Color.Red;
                    player1.ForeColor = Color.White;
                }
                else
                {
                    player2.ForeColor = Color.White;
                    player1.ForeColor = Color.Red;
                }

                char? gameStatus = game.AddValueToNode(number);
                if (gameStatus != null)
                {
                    gameStop();
                }

                if (gameStatus == 'X')
                {
                    textBox1.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    textBox1.Text = "Player two won";
                }
                else if (gameStatus == '=')
                {
                    textBox1.Text = "Dead heat";
                }
            }
        }

        private void MouseOnClickNode5(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int number);
            if (!game.isSettled(number))
            {
                button.Text = game.currentChar.ToString();

                if (game.currentChar == 'X')
                {
                    player2.ForeColor = Color.Red;
                    player1.ForeColor = Color.White;
                }
                else
                {
                    player2.ForeColor = Color.White;
                    player1.ForeColor = Color.Red;
                }

                char? gameStatus = game.AddValueToNode(number);
                if (gameStatus != null)
                {
                    gameStop();
                }

                if (gameStatus == 'X')
                {
                    textBox1.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    textBox1.Text = "Player two won";
                }
                else if (gameStatus == '=')
                {
                    textBox1.Text = "Dead heat";
                }
            }
        }

        private void MouseOnClickNode6(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int number);

            if (game.currentChar == 'X')
            {
                player2.ForeColor = Color.Red;
                player1.ForeColor = Color.White;
            }
            else
            {
                player2.ForeColor = Color.White;
                player1.ForeColor = Color.Red;
            }

            if (!game.isSettled(number))
            {
                button.Text = game.currentChar.ToString();
                char? gameStatus = game.AddValueToNode(number);
                if (gameStatus != null)
                {
                    gameStop();
                }

                if (gameStatus == 'X')
                {
                    textBox1.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    textBox1.Text = "Player two won";
                }
                else if (gameStatus == '=')
                {
                    textBox1.Text = "Dead heat";
                }
            }
        }

        private void MouseOnClickNode7(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int number);
            if (!game.isSettled(number))
            {
                button.Text = game.currentChar.ToString();

                if (game.currentChar == 'X')
                {
                    player2.ForeColor = Color.Red;
                    player1.ForeColor = Color.White;
                }
                else
                {
                    player2.ForeColor = Color.White;
                    player1.ForeColor = Color.Red;
                }

                char? gameStatus = game.AddValueToNode(number);
                if (gameStatus != null)
                {
                    gameStop();
                }

                if (gameStatus == 'X')
                {
                    textBox1.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    textBox1.Text = "Player two won";
                }
                else if (gameStatus == '=')
                {
                    textBox1.Text = "Dead heat";
                }
            }
        }

        private void MouseOnClickNode8(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int number);
            if (!game.isSettled(number))
            {
                button.Text = game.currentChar.ToString();

                if (game.currentChar == 'X')
                {
                    player2.ForeColor = Color.Red;
                    player1.ForeColor = Color.White;
                }
                else
                {
                    player2.ForeColor = Color.White;
                    player1.ForeColor = Color.Red;
                }

                char? gameStatus = game.AddValueToNode(number);
                if (gameStatus != null)
                {
                    gameStop();
                }

                if (gameStatus == 'X')
                {
                    textBox1.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    textBox1.Text = "Player two won";
                }
                else if (gameStatus == '=')
                {
                    textBox1.Text = "Dead heat";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}