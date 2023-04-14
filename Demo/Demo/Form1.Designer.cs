namespace Demo
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
            mainButton = new Button();
            SuspendLayout();
            // 
            // mainButton
            // 
            mainButton.BackColor = Color.Tomato;
            mainButton.Font = new Font("Death Note Font", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mainButton.Location = new Point(403, 260);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(368, 137);
            mainButton.TabIndex = 0;
            mainButton.Text = "Click on me ";
            mainButton.UseVisualStyleBackColor = false;
            mainButton.Click += MainButtonClick;
            mainButton.MouseLeave += MainButtonMouseLeave;
            mainButton.MouseMove += mainButton_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1280, 720);
            Controls.Add(mainButton);
            Name = "Form1";
            Text = "SuperAplication";
            ResumeLayout(false);
        }

        #endregion

        private Button mainButton;
    }
}