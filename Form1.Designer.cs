namespace Comp60Ass2
{
    partial class Form1
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.playerOneNameInput = new System.Windows.Forms.TextBox();
            this.playerTwoNameLabel = new System.Windows.Forms.Label();
            this.playerTwoNameInput = new System.Windows.Forms.TextBox();
            this.guessInputLabel = new System.Windows.Forms.Label();
            this.showTargetGuess = new System.Windows.Forms.TextBox();
            this.showTargetGuessLabel = new System.Windows.Forms.Label();
            this.wheel = new System.Windows.Forms.PictureBox();
            this.startGame = new System.Windows.Forms.Button();
            this.newGuess = new System.Windows.Forms.Button();
            this.playerOneScore = new System.Windows.Forms.TextBox();
            this.playerOneScoreLabel = new System.Windows.Forms.Label();
            this.playerTwoScoreLabel = new System.Windows.Forms.Label();
            this.playerTwoScore = new System.Windows.Forms.TextBox();
            this.showPlayerOneName = new System.Windows.Forms.TextBox();
            this.showPlayerTwoName = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.instruction = new System.Windows.Forms.Button();
            this.rankingPrint = new System.Windows.Forms.TextBox();
            this.top10 = new System.Windows.Forms.Label();
            this.maskedGuessInput = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wheel)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Modern No. 20", 18.2F);
            this.firstNameLabel.Location = new System.Drawing.Point(166, 151);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(256, 32);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "Player One Name： ";
            // 
            // playerOneNameInput
            // 
            this.playerOneNameInput.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneNameInput.Location = new System.Drawing.Point(449, 151);
            this.playerOneNameInput.Name = "playerOneNameInput";
            this.playerOneNameInput.Size = new System.Drawing.Size(184, 41);
            this.playerOneNameInput.TabIndex = 1;
            // 
            // playerTwoNameLabel
            // 
            this.playerTwoNameLabel.AutoSize = true;
            this.playerTwoNameLabel.Font = new System.Drawing.Font("Modern No. 20", 18.2F);
            this.playerTwoNameLabel.Location = new System.Drawing.Point(169, 218);
            this.playerTwoNameLabel.Name = "playerTwoNameLabel";
            this.playerTwoNameLabel.Size = new System.Drawing.Size(253, 32);
            this.playerTwoNameLabel.TabIndex = 2;
            this.playerTwoNameLabel.Text = "Player Two Name: ";
            // 
            // playerTwoNameInput
            // 
            this.playerTwoNameInput.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoNameInput.Location = new System.Drawing.Point(450, 218);
            this.playerTwoNameInput.Name = "playerTwoNameInput";
            this.playerTwoNameInput.Size = new System.Drawing.Size(183, 41);
            this.playerTwoNameInput.TabIndex = 3;
            // 
            // guessInputLabel
            // 
            this.guessInputLabel.AutoSize = true;
            this.guessInputLabel.Font = new System.Drawing.Font("Modern No. 20", 18.2F);
            this.guessInputLabel.Location = new System.Drawing.Point(201, 289);
            this.guessInputLabel.Name = "guessInputLabel";
            this.guessInputLabel.Size = new System.Drawing.Size(239, 32);
            this.guessInputLabel.TabIndex = 4;
            this.guessInputLabel.Text = "Enter your guess: ";
            // 
            // showTargetGuess
            // 
            this.showTargetGuess.Font = new System.Drawing.Font("SimSun", 18.2F);
            this.showTargetGuess.Location = new System.Drawing.Point(419, 360);
            this.showTargetGuess.Name = "showTargetGuess";
            this.showTargetGuess.ReadOnly = true;
            this.showTargetGuess.Size = new System.Drawing.Size(339, 42);
            this.showTargetGuess.TabIndex = 6;
            // 
            // showTargetGuessLabel
            // 
            this.showTargetGuessLabel.AutoSize = true;
            this.showTargetGuessLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTargetGuessLabel.Location = new System.Drawing.Point(192, 364);
            this.showTargetGuessLabel.Name = "showTargetGuessLabel";
            this.showTargetGuessLabel.Size = new System.Drawing.Size(201, 31);
            this.showTargetGuessLabel.TabIndex = 7;
            this.showTargetGuessLabel.Text = "Target guess is: ";
            // 
            // wheel
            // 
            this.wheel.Image = global::Comp60Ass2.Properties.Resources.wheel;
            this.wheel.Location = new System.Drawing.Point(782, 119);
            this.wheel.Name = "wheel";
            this.wheel.Size = new System.Drawing.Size(254, 251);
            this.wheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wheel.TabIndex = 8;
            this.wheel.TabStop = false;
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.ForeColor = System.Drawing.SystemColors.Highlight;
            this.startGame.Location = new System.Drawing.Point(652, 157);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(106, 39);
            this.startGame.TabIndex = 9;
            this.startGame.Text = "Start";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // newGuess
            // 
            this.newGuess.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGuess.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newGuess.Location = new System.Drawing.Point(652, 289);
            this.newGuess.Name = "newGuess";
            this.newGuess.Size = new System.Drawing.Size(98, 41);
            this.newGuess.TabIndex = 10;
            this.newGuess.Text = "Submit";
            this.newGuess.UseVisualStyleBackColor = true;
            this.newGuess.Click += new System.EventHandler(this.newGuess_Click);
            // 
            // playerOneScore
            // 
            this.playerOneScore.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneScore.ForeColor = System.Drawing.Color.Blue;
            this.playerOneScore.Location = new System.Drawing.Point(1228, 143);
            this.playerOneScore.Name = "playerOneScore";
            this.playerOneScore.ReadOnly = true;
            this.playerOneScore.Size = new System.Drawing.Size(63, 41);
            this.playerOneScore.TabIndex = 11;
            // 
            // playerOneScoreLabel
            // 
            this.playerOneScoreLabel.AutoSize = true;
            this.playerOneScoreLabel.Font = new System.Drawing.Font("Sitka Display", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneScoreLabel.Location = new System.Drawing.Point(1134, 143);
            this.playerOneScoreLabel.Name = "playerOneScoreLabel";
            this.playerOneScoreLabel.Size = new System.Drawing.Size(88, 40);
            this.playerOneScoreLabel.TabIndex = 12;
            this.playerOneScoreLabel.Text = "Score ";
            // 
            // playerTwoScoreLabel
            // 
            this.playerTwoScoreLabel.AutoSize = true;
            this.playerTwoScoreLabel.Font = new System.Drawing.Font("Sitka Display", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoScoreLabel.Location = new System.Drawing.Point(1134, 189);
            this.playerTwoScoreLabel.Name = "playerTwoScoreLabel";
            this.playerTwoScoreLabel.Size = new System.Drawing.Size(81, 40);
            this.playerTwoScoreLabel.TabIndex = 13;
            this.playerTwoScoreLabel.Text = "Score";
            // 
            // playerTwoScore
            // 
            this.playerTwoScore.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoScore.ForeColor = System.Drawing.Color.Lime;
            this.playerTwoScore.Location = new System.Drawing.Point(1228, 188);
            this.playerTwoScore.Name = "playerTwoScore";
            this.playerTwoScore.ReadOnly = true;
            this.playerTwoScore.Size = new System.Drawing.Size(63, 41);
            this.playerTwoScore.TabIndex = 14;
            // 
            // showPlayerOneName
            // 
            this.showPlayerOneName.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPlayerOneName.Location = new System.Drawing.Point(1042, 145);
            this.showPlayerOneName.Name = "showPlayerOneName";
            this.showPlayerOneName.ReadOnly = true;
            this.showPlayerOneName.Size = new System.Drawing.Size(86, 41);
            this.showPlayerOneName.TabIndex = 16;
            // 
            // showPlayerTwoName
            // 
            this.showPlayerTwoName.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPlayerTwoName.Location = new System.Drawing.Point(1042, 189);
            this.showPlayerTwoName.Name = "showPlayerTwoName";
            this.showPlayerTwoName.ReadOnly = true;
            this.showPlayerTwoName.Size = new System.Drawing.Size(86, 41);
            this.showPlayerTwoName.TabIndex = 17;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.reset.Location = new System.Drawing.Point(940, 416);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(96, 45);
            this.reset.TabIndex = 18;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // instruction
            // 
            this.instruction.Font = new System.Drawing.Font("Sitka Display", 12.2F, System.Drawing.FontStyle.Bold);
            this.instruction.ForeColor = System.Drawing.SystemColors.Highlight;
            this.instruction.Location = new System.Drawing.Point(767, 416);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(155, 45);
            this.instruction.TabIndex = 19;
            this.instruction.Text = "How to play?";
            this.instruction.UseVisualStyleBackColor = true;
            this.instruction.Click += new System.EventHandler(this.instruction_Click);
            // 
            // rankingPrint
            // 
            this.rankingPrint.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankingPrint.ForeColor = System.Drawing.Color.Red;
            this.rankingPrint.Location = new System.Drawing.Point(1059, 319);
            this.rankingPrint.Multiline = true;
            this.rankingPrint.Name = "rankingPrint";
            this.rankingPrint.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rankingPrint.Size = new System.Drawing.Size(305, 236);
            this.rankingPrint.TabIndex = 20;
            // 
            // top10
            // 
            this.top10.AutoSize = true;
            this.top10.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top10.Location = new System.Drawing.Point(1144, 286);
            this.top10.Name = "top10";
            this.top10.Size = new System.Drawing.Size(88, 30);
            this.top10.TabIndex = 21;
            this.top10.Text = "Top10";
            // 
            // maskedGuessInput
            // 
            this.maskedGuessInput.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedGuessInput.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.maskedGuessInput.Location = new System.Drawing.Point(450, 286);
            this.maskedGuessInput.Mask = "L";
            this.maskedGuessInput.Name = "maskedGuessInput";
            this.maskedGuessInput.PromptChar = '-';
            this.maskedGuessInput.Size = new System.Drawing.Size(183, 41);
            this.maskedGuessInput.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Comp60Ass2.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 594);
            this.Controls.Add(this.maskedGuessInput);
            this.Controls.Add(this.top10);
            this.Controls.Add(this.rankingPrint);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.showPlayerTwoName);
            this.Controls.Add(this.showPlayerOneName);
            this.Controls.Add(this.playerTwoScore);
            this.Controls.Add(this.playerTwoScoreLabel);
            this.Controls.Add(this.playerOneScoreLabel);
            this.Controls.Add(this.playerOneScore);
            this.Controls.Add(this.newGuess);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.wheel);
            this.Controls.Add(this.showTargetGuessLabel);
            this.Controls.Add(this.showTargetGuess);
            this.Controls.Add(this.guessInputLabel);
            this.Controls.Add(this.playerTwoNameInput);
            this.Controls.Add(this.playerTwoNameLabel);
            this.Controls.Add(this.playerOneNameInput);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.wheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox playerOneNameInput;
        private System.Windows.Forms.Label playerTwoNameLabel;
        private System.Windows.Forms.TextBox playerTwoNameInput;
        private System.Windows.Forms.Label guessInputLabel;
        private System.Windows.Forms.TextBox showTargetGuess;
        private System.Windows.Forms.Label showTargetGuessLabel;
        private System.Windows.Forms.PictureBox wheel;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button newGuess;
        private System.Windows.Forms.TextBox playerOneScore;
        private System.Windows.Forms.Label playerOneScoreLabel;
        private System.Windows.Forms.Label playerTwoScoreLabel;
        private System.Windows.Forms.TextBox playerTwoScore;
        private System.Windows.Forms.TextBox showPlayerOneName;
        private System.Windows.Forms.TextBox showPlayerTwoName;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button instruction;
        private System.Windows.Forms.TextBox rankingPrint;
        private System.Windows.Forms.Label top10;
        private System.Windows.Forms.MaskedTextBox maskedGuessInput;
    }
}

