namespace Server_HW4
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
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ClientChoice = new System.Windows.Forms.Label();
            this.ServerChoice = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ScissorButton = new System.Windows.Forms.Button();
            this.PapperButton = new System.Windows.Forms.Button();
            this.RockButton = new System.Windows.Forms.Button();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(233, 156);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(108, 20);
            this.ScoreLabel.TabIndex = 23;
            this.ScoreLabel.Text = "Score: 0 : 0";
            // 
            // ClientChoice
            // 
            this.ClientChoice.AutoSize = true;
            this.ClientChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientChoice.ForeColor = System.Drawing.Color.Peru;
            this.ClientChoice.Location = new System.Drawing.Point(327, 106);
            this.ClientChoice.Name = "ClientChoice";
            this.ClientChoice.Size = new System.Drawing.Size(41, 32);
            this.ClientChoice.TabIndex = 22;
            this.ClientChoice.Text = "...";
            // 
            // ServerChoice
            // 
            this.ServerChoice.AutoSize = true;
            this.ServerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServerChoice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ServerChoice.Location = new System.Drawing.Point(327, 73);
            this.ServerChoice.Name = "ServerChoice";
            this.ServerChoice.Size = new System.Drawing.Size(41, 32);
            this.ServerChoice.TabIndex = 21;
            this.ServerChoice.Text = "...";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label2.Location = new System.Drawing.Point(201, 106);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(111, 32);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Client: ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(201, 73);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 32);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Server: ";
            // 
            // ScissorButton
            // 
            this.ScissorButton.Enabled = false;
            this.ScissorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScissorButton.Location = new System.Drawing.Point(17, 150);
            this.ScissorButton.Name = "ScissorButton";
            this.ScissorButton.Size = new System.Drawing.Size(88, 33);
            this.ScissorButton.TabIndex = 18;
            this.ScissorButton.Text = "Scissor";
            this.ScissorButton.UseVisualStyleBackColor = true;
            this.ScissorButton.Click += new System.EventHandler(this.ScissorButton_Click);
            // 
            // PapperButton
            // 
            this.PapperButton.Enabled = false;
            this.PapperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PapperButton.Location = new System.Drawing.Point(17, 111);
            this.PapperButton.Name = "PapperButton";
            this.PapperButton.Size = new System.Drawing.Size(88, 33);
            this.PapperButton.TabIndex = 17;
            this.PapperButton.Text = "Papper";
            this.PapperButton.UseVisualStyleBackColor = true;
            this.PapperButton.Click += new System.EventHandler(this.PapperButton_Click);
            // 
            // RockButton
            // 
            this.RockButton.Enabled = false;
            this.RockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RockButton.Location = new System.Drawing.Point(17, 72);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(88, 33);
            this.RockButton.TabIndex = 16;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoundLabel.Location = new System.Drawing.Point(12, 21);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(122, 25);
            this.RoundLabel.TabIndex = 15;
            this.RoundLabel.Text = "New Round";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 223);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ClientChoice);
            this.Controls.Add(this.ServerChoice);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ScissorButton);
            this.Controls.Add(this.PapperButton);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.RoundLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ClientChoice;
        private System.Windows.Forms.Label ServerChoice;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ScissorButton;
        private System.Windows.Forms.Button PapperButton;
        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Label RoundLabel;
    }
}

