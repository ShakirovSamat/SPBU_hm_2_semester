namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Game game = new Game();

        private void GameStop()
        {
            node0Button.Enabled = false;
            node1Button.Enabled = false;
            node2Button.Enabled = false;
            node3Button.Enabled = false;
            node4Button.Enabled = false;
            node5Button.Enabled = false;
            node6Button.Enabled = false;
            node7Button.Enabled = false;
            node8Button.Enabled = false;
        }

        private void MouseClickNode0Button(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int position);
            if (!game.isSettled(position))
            {
                Color color = player1Label.ForeColor;
                player1Label.ForeColor = player2Label.ForeColor;
                player2Label.ForeColor = color;

                button.Text = game.GetCurrentGameChar().ToString();
                char? gameStatus = game.AddValueToNode(position);
                if (gameStatus == 'X')
                {
                    table.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    table.Text = "Player two one";
                }
                else if (gameStatus == '=')
                {
                    table.Text = "Dead heat";
                }

                if (gameStatus != null)
                {
                    GameStop();
                }
            }
        }

        private void MouseClickNode1Button(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int position);
            if (!game.isSettled(position))
            {
                Color color = player1Label.ForeColor;
                player1Label.ForeColor = player2Label.ForeColor;
                player2Label.ForeColor = color;

                button.Text = game.GetCurrentGameChar().ToString();
                char? gameStatus = game.AddValueToNode(position);
                if (gameStatus == 'X')
                {
                    table.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    table.Text = "Player two one";
                }
                else if (gameStatus == '=')
                {
                    table.Text = "Dead heat";
                }

                if (gameStatus != null)
                {
                    GameStop();
                }
            }
        }

        private void MouseClickNode2Button(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int position);
            if (!game.isSettled(position))
            {
                Color color = player1Label.ForeColor;
                player1Label.ForeColor = player2Label.ForeColor;
                player2Label.ForeColor = color;

                button.Text = game.GetCurrentGameChar().ToString();
                char? gameStatus = game.AddValueToNode(position);
                if (gameStatus == 'X')
                {
                    table.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    table.Text = "Player two one";
                }
                else if (gameStatus == '=')
                {
                    table.Text = "Dead heat";
                }

                if (gameStatus != null)
                {
                    GameStop();
                }
            }
        }

        private void MouseClickNode3Button(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int position);
            if (!game.isSettled(position))
            {
                Color color = player1Label.ForeColor;
                player1Label.ForeColor = player2Label.ForeColor;
                player2Label.ForeColor = color;

                button.Text = game.GetCurrentGameChar().ToString();
                char? gameStatus = game.AddValueToNode(position);
                if (gameStatus == 'X')
                {
                    table.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    table.Text = "Player two one";
                }
                else if (gameStatus == '=')
                {
                    table.Text = "Dead heat";
                }

                if (gameStatus != null)
                {
                    GameStop();
                }
            }
        }

        private void MouseClickNode4Button(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int position);
            if (!game.isSettled(position))
            {
                Color color = player1Label.ForeColor;
                player1Label.ForeColor = player2Label.ForeColor;
                player2Label.ForeColor = color;

                button.Text = game.GetCurrentGameChar().ToString();
                char? gameStatus = game.AddValueToNode(position);
                if (gameStatus == 'X')
                {
                    table.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    table.Text = "Player two one";
                }
                else if (gameStatus == '=')
                {
                    table.Text = "Dead heat";
                }

                if (gameStatus != null)
                {
                    GameStop();
                }
            }
        }

        private void MouseClickNode5Button(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int position);
            if (!game.isSettled(position))
            {
                Color color = player1Label.ForeColor;
                player1Label.ForeColor = player2Label.ForeColor;
                player2Label.ForeColor = color;

                button.Text = game.GetCurrentGameChar().ToString();
                char? gameStatus = game.AddValueToNode(position);
                if (gameStatus == 'X')
                {
                    table.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    table.Text = "Player two one";
                }
                else if (gameStatus == '=')
                {
                    table.Text = "Dead heat";
                }

                if (gameStatus != null)
                {
                    GameStop();
                }
            }
        }

        private void MouseClickNode6Button(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int position);
            if (!game.isSettled(position))
            {
                Color color = player1Label.ForeColor;
                player1Label.ForeColor = player2Label.ForeColor;
                player2Label.ForeColor = color;

                button.Text = game.GetCurrentGameChar().ToString();
                char? gameStatus = game.AddValueToNode(position);
                if (gameStatus == 'X')
                {
                    table.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    table.Text = "Player two one";
                }
                else if (gameStatus == '=')
                {
                    table.Text = "Dead heat";
                }

                if (gameStatus != null)
                {
                    GameStop();
                }
            }
        }

        private void MouseClickNode7Button(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int position);
            if (!game.isSettled(position))
            {
                Color color = player1Label.ForeColor;
                player1Label.ForeColor = player2Label.ForeColor;
                player2Label.ForeColor = color;

                button.Text = game.GetCurrentGameChar().ToString();
                char? gameStatus = game.AddValueToNode(position);
                if (gameStatus == 'X')
                {
                    table.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    table.Text = "Player two one";
                }
                else if (gameStatus == '=')
                {
                    table.Text = "Dead heat";
                }

                if (gameStatus != null)
                {
                    GameStop();
                }
            }
        }

        private void MouseClickNode8Button(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            int.TryParse(button.Name[4].ToString(), out int position);
            if (!game.isSettled(position))
            {
                Color color = player1Label.ForeColor;
                player1Label.ForeColor = player2Label.ForeColor;
                player2Label.ForeColor = color;

                button.Text = game.GetCurrentGameChar().ToString();
                char? gameStatus = game.AddValueToNode(position);
                if (gameStatus == 'X')
                {
                    table.Text = "Player one won";
                }
                else if (gameStatus == 'O')
                {
                    table.Text = "Player two one";
                }
                else if (gameStatus == '=')
                {
                    table.Text = "Dead heat";
                }

                if (gameStatus != null)
                {
                    GameStop();
                }
            }
        }
    }
}