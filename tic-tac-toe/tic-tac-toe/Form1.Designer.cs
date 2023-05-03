namespace tic_tac_toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            node0Button = new Button();
            node1Button = new Button();
            node2Button = new Button();
            node3Button = new Button();
            node4Button = new Button();
            node5Button = new Button();
            node6Button = new Button();
            node7Button = new Button();
            node8Button = new Button();
            player1Label = new Label();
            player2Label = new Label();
            table = new Label();
            SuspendLayout();
            // 
            // node0Button
            // 
            node0Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            node0Button.Location = new Point(500, 100);
            node0Button.Margin = new Padding(5);
            node0Button.MaximumSize = new Size(80, 80);
            node0Button.MinimumSize = new Size(50, 50);
            node0Button.Name = "node0Button";
            node0Button.Size = new Size(70, 70);
            node0Button.TabIndex = 0;
            node0Button.UseVisualStyleBackColor = true;
            node0Button.MouseClick += MouseClickNode0Button;
            // 
            // node1Button
            // 
            node1Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            node1Button.Location = new Point(580, 100);
            node1Button.Margin = new Padding(5);
            node1Button.MaximumSize = new Size(80, 80);
            node1Button.MinimumSize = new Size(50, 50);
            node1Button.Name = "node1Button";
            node1Button.Size = new Size(70, 70);
            node1Button.TabIndex = 1;
            node1Button.UseVisualStyleBackColor = true;
            node1Button.MouseClick += MouseClickNode1Button;
            // 
            // node2Button
            // 
            node2Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            node2Button.Location = new Point(660, 100);
            node2Button.Margin = new Padding(5);
            node2Button.MaximumSize = new Size(80, 80);
            node2Button.MinimumSize = new Size(50, 50);
            node2Button.Name = "node2Button";
            node2Button.Size = new Size(70, 70);
            node2Button.TabIndex = 2;
            node2Button.UseVisualStyleBackColor = true;
            node2Button.MouseClick += MouseClickNode2Button;
            // 
            // node3Button
            // 
            node3Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            node3Button.Location = new Point(500, 180);
            node3Button.Margin = new Padding(5);
            node3Button.MaximumSize = new Size(80, 80);
            node3Button.MinimumSize = new Size(50, 50);
            node3Button.Name = "node3Button";
            node3Button.Size = new Size(70, 70);
            node3Button.TabIndex = 3;
            node3Button.UseVisualStyleBackColor = true;
            node3Button.MouseClick += MouseClickNode3Button;
            // 
            // node4Button
            // 
            node4Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            node4Button.Location = new Point(580, 180);
            node4Button.Margin = new Padding(5);
            node4Button.MaximumSize = new Size(80, 80);
            node4Button.MinimumSize = new Size(50, 50);
            node4Button.Name = "node4Button";
            node4Button.Size = new Size(70, 70);
            node4Button.TabIndex = 4;
            node4Button.UseVisualStyleBackColor = true;
            node4Button.MouseClick += MouseClickNode4Button;
            // 
            // node5Button
            // 
            node5Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            node5Button.Location = new Point(660, 180);
            node5Button.Margin = new Padding(5);
            node5Button.MaximumSize = new Size(80, 80);
            node5Button.MinimumSize = new Size(50, 50);
            node5Button.Name = "node5Button";
            node5Button.Size = new Size(70, 70);
            node5Button.TabIndex = 5;
            node5Button.UseVisualStyleBackColor = true;
            node5Button.MouseClick += MouseClickNode5Button;
            // 
            // node6Button
            // 
            node6Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            node6Button.Location = new Point(500, 260);
            node6Button.Margin = new Padding(5);
            node6Button.MaximumSize = new Size(80, 80);
            node6Button.MinimumSize = new Size(50, 50);
            node6Button.Name = "node6Button";
            node6Button.Size = new Size(70, 70);
            node6Button.TabIndex = 6;
            node6Button.UseVisualStyleBackColor = true;
            node6Button.MouseClick += MouseClickNode6Button;
            // 
            // node7Button
            // 
            node7Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            node7Button.Location = new Point(580, 260);
            node7Button.Margin = new Padding(5);
            node7Button.MaximumSize = new Size(80, 80);
            node7Button.MinimumSize = new Size(50, 50);
            node7Button.Name = "node7Button";
            node7Button.Size = new Size(70, 70);
            node7Button.TabIndex = 7;
            node7Button.UseVisualStyleBackColor = true;
            node7Button.MouseClick += MouseClickNode7Button;
            // 
            // node8Button
            // 
            node8Button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            node8Button.Location = new Point(660, 260);
            node8Button.Margin = new Padding(5);
            node8Button.MaximumSize = new Size(80, 80);
            node8Button.MinimumSize = new Size(50, 50);
            node8Button.Name = "node8Button";
            node8Button.Size = new Size(70, 70);
            node8Button.TabIndex = 8;
            node8Button.UseVisualStyleBackColor = true;
            node8Button.MouseClick += MouseClickNode8Button;
            // 
            // player1Label
            // 
            player1Label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            player1Label.AutoSize = true;
            player1Label.BackColor = Color.White;
            player1Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            player1Label.ForeColor = Color.Green;
            player1Label.Location = new Point(868, 180);
            player1Label.Name = "player1Label";
            player1Label.Size = new Size(79, 25);
            player1Label.TabIndex = 9;
            player1Label.Text = "Player 1";
            // 
            // player2Label
            // 
            player2Label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            player2Label.AutoSize = true;
            player2Label.BackColor = Color.White;
            player2Label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            player2Label.ForeColor = Color.White;
            player2Label.Location = new Point(868, 239);
            player2Label.Name = "player2Label";
            player2Label.Size = new Size(79, 25);
            player2Label.TabIndex = 10;
            player2Label.Text = "Player 2";
            // 
            // table
            // 
            table.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            table.AutoSize = true;
            table.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            table.Location = new Point(566, 385);
            table.Name = "table";
            table.Size = new Size(0, 25);
            table.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1262, 673);
            Controls.Add(table);
            Controls.Add(player2Label);
            Controls.Add(player1Label);
            Controls.Add(node8Button);
            Controls.Add(node7Button);
            Controls.Add(node6Button);
            Controls.Add(node5Button);
            Controls.Add(node4Button);
            Controls.Add(node3Button);
            Controls.Add(node2Button);
            Controls.Add(node1Button);
            Controls.Add(node0Button);
            Name = "Form1";
            Text = "Tic-tac-toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button node0Button;
        private Button node1Button;
        private Button node2Button;
        private Button node3Button;
        private Button node4Button;
        private Button node5Button;
        private Button node6Button;
        private Button node7Button;
        private Button node8Button;
        private Label player1Label;
        private Label player2Label;
        private Label table;
    }
}