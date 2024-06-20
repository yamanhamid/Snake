namespace Yaman_Faisal_Hamid___Snake
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this._textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._buttonResume = new System.Windows.Forms.Button();
            this._buttonStart = new System.Windows.Forms.Button();
            this._labelScore = new System.Windows.Forms.Label();
            this._labelHighScore = new System.Windows.Forms.Label();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this._labelDifficulty = new System.Windows.Forms.Label();
            this._buttonPause = new System.Windows.Forms.Button();
            this._buttonReset = new System.Windows.Forms.Button();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _textBoxPlayerName
            // 
            this._textBoxPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this._textBoxPlayerName.Location = new System.Drawing.Point(778, 196);
            this._textBoxPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxPlayerName.Name = "_textBoxPlayerName";
            this._textBoxPlayerName.Size = new System.Drawing.Size(163, 23);
            this._textBoxPlayerName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(631, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Player Name";
            // 
            // _buttonResume
            // 
            this._buttonResume.BackColor = System.Drawing.Color.DeepSkyBlue;
            this._buttonResume.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this._buttonResume.Location = new System.Drawing.Point(631, 451);
            this._buttonResume.Margin = new System.Windows.Forms.Padding(4);
            this._buttonResume.Name = "_buttonResume";
            this._buttonResume.Size = new System.Drawing.Size(310, 110);
            this._buttonResume.TabIndex = 33;
            this._buttonResume.Text = "RESUME";
            this._buttonResume.UseVisualStyleBackColor = false;
            this._buttonResume.Click += new System.EventHandler(this.ButtonResumeClick);
            // 
            // _buttonStart
            // 
            this._buttonStart.BackColor = System.Drawing.Color.LimeGreen;
            this._buttonStart.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this._buttonStart.Location = new System.Drawing.Point(631, 59);
            this._buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this._buttonStart.Name = "_buttonStart";
            this._buttonStart.Size = new System.Drawing.Size(310, 110);
            this._buttonStart.TabIndex = 32;
            this._buttonStart.Text = "START";
            this._buttonStart.UseVisualStyleBackColor = false;
            this._buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
            // 
            // _labelScore
            // 
            this._labelScore.AutoSize = true;
            this._labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this._labelScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._labelScore.Location = new System.Drawing.Point(631, 242);
            this._labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelScore.Name = "_labelScore";
            this._labelScore.Size = new System.Drawing.Size(93, 26);
            this._labelScore.TabIndex = 31;
            this._labelScore.Text = "Score: 0";
            // 
            // _labelHighScore
            // 
            this._labelHighScore.AutoSize = true;
            this._labelHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this._labelHighScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._labelHighScore.Location = new System.Drawing.Point(632, 268);
            this._labelHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelHighScore.Name = "_labelHighScore";
            this._labelHighScore.Size = new System.Drawing.Size(144, 26);
            this._labelHighScore.TabIndex = 30;
            this._labelHighScore.Text = "High Score: 0";
            // 
            // _comboBox
            // 
            this._comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(748, 13);
            this._comboBox.Margin = new System.Windows.Forms.Padding(4);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(193, 21);
            this._comboBox.TabIndex = 29;
            // 
            // _labelDifficulty
            // 
            this._labelDifficulty.AutoSize = true;
            this._labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this._labelDifficulty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._labelDifficulty.Location = new System.Drawing.Point(632, 13);
            this._labelDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelDifficulty.Name = "_labelDifficulty";
            this._labelDifficulty.Size = new System.Drawing.Size(95, 26);
            this._labelDifficulty.TabIndex = 28;
            this._labelDifficulty.Text = "Difficulty";
            // 
            // _buttonPause
            // 
            this._buttonPause.BackColor = System.Drawing.Color.Gold;
            this._buttonPause.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this._buttonPause.Location = new System.Drawing.Point(631, 322);
            this._buttonPause.Margin = new System.Windows.Forms.Padding(4);
            this._buttonPause.Name = "_buttonPause";
            this._buttonPause.Size = new System.Drawing.Size(310, 110);
            this._buttonPause.TabIndex = 27;
            this._buttonPause.Text = "PAUSE";
            this._buttonPause.UseVisualStyleBackColor = false;
            this._buttonPause.Click += new System.EventHandler(this.ButtonPauseClick);
            // 
            // _buttonReset
            // 
            this._buttonReset.BackColor = System.Drawing.Color.Red;
            this._buttonReset.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this._buttonReset.Location = new System.Drawing.Point(631, 582);
            this._buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this._buttonReset.Name = "_buttonReset";
            this._buttonReset.Size = new System.Drawing.Size(310, 110);
            this._buttonReset.TabIndex = 26;
            this._buttonReset.Text = "RESET";
            this._buttonReset.UseVisualStyleBackColor = false;
            this._buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(598, 196);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(98, 20);
            this.txtHighScore.TabIndex = 24;
            this.txtHighScore.Text = "High Score";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(598, 158);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(76, 20);
            this.txtScore.TabIndex = 25;
            this.txtScore.Text = "Score: 0";
            // 
            // _pictureBox
            // 
            this._pictureBox.BackColor = System.Drawing.Color.White;
            this._pictureBox.Location = new System.Drawing.Point(12, 12);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(580, 680);
            this._pictureBox.TabIndex = 23;
            this._pictureBox.TabStop = false;
            this._pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxPaint);
            // 
            // _gameTimer
            // 
            this._gameTimer.Tick += new System.EventHandler(this.GameTimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(956, 705);
            this.Controls.Add(this._textBoxPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonResume);
            this.Controls.Add(this._buttonStart);
            this.Controls.Add(this._labelScore);
            this.Controls.Add(this._labelHighScore);
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._labelDifficulty);
            this.Controls.Add(this._buttonPause);
            this.Controls.Add(this._buttonReset);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this._pictureBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _buttonResume;
        private System.Windows.Forms.Button _buttonStart;
        private System.Windows.Forms.Label _labelScore;
        private System.Windows.Forms.Label _labelHighScore;
        private System.Windows.Forms.ComboBox _comboBox;
        private System.Windows.Forms.Label _labelDifficulty;
        private System.Windows.Forms.Button _buttonPause;
        private System.Windows.Forms.Button _buttonReset;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Timer _gameTimer;
    }
}

