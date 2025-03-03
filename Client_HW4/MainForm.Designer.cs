namespace Client_HW4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ClientChoice = new System.Windows.Forms.Label();
            this.ServerChoice = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ScissorButton = new System.Windows.Forms.Button();
            this.PapperButton = new System.Windows.Forms.Button();
            this.RockButton = new System.Windows.Forms.Button();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.autobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(16, 194);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(102, 26);
            this.ConnectButton.TabIndex = 27;
            this.ConnectButton.Text = "connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Enabled = false;
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameButton.Location = new System.Drawing.Point(387, 6);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(88, 33);
            this.StartGameButton.TabIndex = 26;
            this.StartGameButton.Text = "Start";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(188, 177);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(108, 20);
            this.ScoreLabel.TabIndex = 25;
            this.ScoreLabel.Text = "Score: 0 : 0";
            // 
            // ClientChoice
            // 
            this.ClientChoice.AutoSize = true;
            this.ClientChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientChoice.ForeColor = System.Drawing.Color.Peru;
            this.ClientChoice.Location = new System.Drawing.Point(296, 103);
            this.ClientChoice.Name = "ClientChoice";
            this.ClientChoice.Size = new System.Drawing.Size(41, 32);
            this.ClientChoice.TabIndex = 24;
            this.ClientChoice.Text = "...";
            // 
            // ServerChoice
            // 
            this.ServerChoice.AutoSize = true;
            this.ServerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerChoice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ServerChoice.Location = new System.Drawing.Point(296, 70);
            this.ServerChoice.Name = "ServerChoice";
            this.ServerChoice.Size = new System.Drawing.Size(41, 32);
            this.ServerChoice.TabIndex = 23;
            this.ServerChoice.Text = "...";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(179, 103);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(111, 32);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Client: ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(179, 70);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 32);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Server: ";
            // 
            // ScissorButton
            // 
            this.ScissorButton.Enabled = false;
            this.ScissorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScissorButton.Location = new System.Drawing.Point(21, 144);
            this.ScissorButton.Name = "ScissorButton";
            this.ScissorButton.Size = new System.Drawing.Size(88, 33);
            this.ScissorButton.TabIndex = 20;
            this.ScissorButton.Text = "Scissor";
            this.ScissorButton.UseVisualStyleBackColor = true;
            this.ScissorButton.Click += new System.EventHandler(this.ScissorButton_Click);
            // 
            // PapperButton
            // 
            this.PapperButton.Enabled = false;
            this.PapperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PapperButton.Location = new System.Drawing.Point(21, 105);
            this.PapperButton.Name = "PapperButton";
            this.PapperButton.Size = new System.Drawing.Size(88, 33);
            this.PapperButton.TabIndex = 19;
            this.PapperButton.Text = "Papper";
            this.PapperButton.UseVisualStyleBackColor = true;
            this.PapperButton.Click += new System.EventHandler(this.PapperButton_Click);
            // 
            // RockButton
            // 
            this.RockButton.Enabled = false;
            this.RockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RockButton.Location = new System.Drawing.Point(21, 66);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(88, 33);
            this.RockButton.TabIndex = 18;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeLabel.Location = new System.Drawing.Point(20, 15);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(73, 25);
            this.ModeLabel.TabIndex = 17;
            this.ModeLabel.Text = "Mode:";
            // 
            // autobutton
            // 
            this.autobutton.Location = new System.Drawing.Point(99, 16);
            this.autobutton.Name = "autobutton";
            this.autobutton.Size = new System.Drawing.Size(75, 23);
            this.autobutton.TabIndex = 28;
            this.autobutton.Text = "auto";
            this.autobutton.UseVisualStyleBackColor = true;
            this.autobutton.Click += new System.EventHandler(this.autobutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 261);
            this.Controls.Add(this.autobutton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ClientChoice);
            this.Controls.Add(this.ServerChoice);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ScissorButton);
            this.Controls.Add(this.PapperButton);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.ModeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ClientChoice;
        private System.Windows.Forms.Label ServerChoice;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ScissorButton;
        private System.Windows.Forms.Button PapperButton;
        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Button autobutton;
    }
}

