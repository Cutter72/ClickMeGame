namespace DwanascieKontrolek
{
    partial class ClickMeGame
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClickMeGame));
            this.clickMe = new System.Windows.Forms.Button();
            this.radioBtnClickMeColorYellow = new System.Windows.Forms.RadioButton();
            this.inputPlayerName = new System.Windows.Forms.TextBox();
            this.highScoresTable = new System.Windows.Forms.RichTextBox();
            this.progressBarTimer = new System.Windows.Forms.ProgressBar();
            this.trackBarClickMeSizeChange = new System.Windows.Forms.TrackBar();
            this.gameArena = new System.Windows.Forms.GroupBox();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.labelTypeYourName = new System.Windows.Forms.Label();
            this.labelClickMeColorChange = new System.Windows.Forms.Label();
            this.labelClickMeSizeChange = new System.Windows.Forms.Label();
            this.radioBtnClickMeColorNormal = new System.Windows.Forms.RadioButton();
            this.highScoresGroup = new System.Windows.Forms.GroupBox();
            this.howToPlayGroup = new System.Windows.Forms.GroupBox();
            this.howToPlayDescription = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.scoreValue = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClickMeSizeChange)).BeginInit();
            this.gameArena.SuspendLayout();
            this.settingsGroup.SuspendLayout();
            this.highScoresGroup.SuspendLayout();
            this.howToPlayGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickMe
            // 
            this.clickMe.BackColor = System.Drawing.Color.Yellow;
            this.clickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clickMe.Location = new System.Drawing.Point(225, 225);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(40, 40);
            this.clickMe.TabIndex = 0;
            this.clickMe.Text = "Start";
            this.clickMe.UseVisualStyleBackColor = false;
            this.clickMe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickMe_MouseClick);
            // 
            // radioBtnClickMeColorYellow
            // 
            this.radioBtnClickMeColorYellow.AutoSize = true;
            this.radioBtnClickMeColorYellow.Checked = true;
            this.radioBtnClickMeColorYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioBtnClickMeColorYellow.Location = new System.Drawing.Point(9, 71);
            this.radioBtnClickMeColorYellow.Name = "radioBtnClickMeColorYellow";
            this.radioBtnClickMeColorYellow.Size = new System.Drawing.Size(83, 17);
            this.radioBtnClickMeColorYellow.TabIndex = 3;
            this.radioBtnClickMeColorYellow.TabStop = true;
            this.radioBtnClickMeColorYellow.Text = "Yellow (+2p)";
            this.radioBtnClickMeColorYellow.UseVisualStyleBackColor = true;
            this.radioBtnClickMeColorYellow.CheckedChanged += new System.EventHandler(this.radioBtnClickMeColorYellow_CheckedChanged);
            // 
            // inputPlayerName
            // 
            this.inputPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputPlayerName.Location = new System.Drawing.Point(9, 32);
            this.inputPlayerName.MaxLength = 16;
            this.inputPlayerName.Name = "inputPlayerName";
            this.inputPlayerName.Size = new System.Drawing.Size(182, 20);
            this.inputPlayerName.TabIndex = 4;
            this.inputPlayerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputPlayerName_KeyDown);
            // 
            // highScoresTable
            // 
            this.highScoresTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highScoresTable.Location = new System.Drawing.Point(6, 19);
            this.highScoresTable.Name = "highScoresTable";
            this.highScoresTable.ReadOnly = true;
            this.highScoresTable.Size = new System.Drawing.Size(189, 199);
            this.highScoresTable.TabIndex = 5;
            this.highScoresTable.Text = "";
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Location = new System.Drawing.Point(10, 518);
            this.progressBarTimer.Maximum = 1000;
            this.progressBarTimer.Name = "progressBarTimer";
            this.progressBarTimer.Size = new System.Drawing.Size(421, 20);
            this.progressBarTimer.Step = 1;
            this.progressBarTimer.TabIndex = 6;
            this.progressBarTimer.Value = 1000;
            // 
            // trackBarClickMeSizeChange
            // 
            this.trackBarClickMeSizeChange.Location = new System.Drawing.Point(6, 112);
            this.trackBarClickMeSizeChange.Maximum = 3;
            this.trackBarClickMeSizeChange.Name = "trackBarClickMeSizeChange";
            this.trackBarClickMeSizeChange.Size = new System.Drawing.Size(185, 45);
            this.trackBarClickMeSizeChange.TabIndex = 10;
            this.trackBarClickMeSizeChange.Value = 2;
            this.trackBarClickMeSizeChange.Scroll += new System.EventHandler(this.trackBarClickMeSizeChange_Scroll);
            // 
            // gameArena
            // 
            this.gameArena.Controls.Add(this.clickMe);
            this.gameArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameArena.Location = new System.Drawing.Point(10, 10);
            this.gameArena.Name = "gameArena";
            this.gameArena.Size = new System.Drawing.Size(500, 500);
            this.gameArena.TabIndex = 11;
            this.gameArena.TabStop = false;
            this.gameArena.Text = "Game Arena";
            // 
            // settingsGroup
            // 
            this.settingsGroup.Controls.Add(this.inputPlayerName);
            this.settingsGroup.Controls.Add(this.labelTypeYourName);
            this.settingsGroup.Controls.Add(this.labelClickMeColorChange);
            this.settingsGroup.Controls.Add(this.labelClickMeSizeChange);
            this.settingsGroup.Controls.Add(this.trackBarClickMeSizeChange);
            this.settingsGroup.Controls.Add(this.radioBtnClickMeColorNormal);
            this.settingsGroup.Controls.Add(this.radioBtnClickMeColorYellow);
            this.settingsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsGroup.Location = new System.Drawing.Point(516, 118);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(200, 162);
            this.settingsGroup.TabIndex = 12;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Settings";
            // 
            // labelTypeYourName
            // 
            this.labelTypeYourName.AutoSize = true;
            this.labelTypeYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypeYourName.Location = new System.Drawing.Point(3, 16);
            this.labelTypeYourName.Name = "labelTypeYourName";
            this.labelTypeYourName.Size = new System.Drawing.Size(61, 13);
            this.labelTypeYourName.TabIndex = 2;
            this.labelTypeYourName.Text = "Your name:";
            // 
            // labelClickMeColorChange
            // 
            this.labelClickMeColorChange.AutoSize = true;
            this.labelClickMeColorChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClickMeColorChange.Location = new System.Drawing.Point(3, 55);
            this.labelClickMeColorChange.Name = "labelClickMeColorChange";
            this.labelClickMeColorChange.Size = new System.Drawing.Size(116, 13);
            this.labelClickMeColorChange.TabIndex = 2;
            this.labelClickMeColorChange.Text = "\'Click me!\' button color:";
            // 
            // labelClickMeSizeChange
            // 
            this.labelClickMeSizeChange.AutoSize = true;
            this.labelClickMeSizeChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClickMeSizeChange.Location = new System.Drawing.Point(3, 92);
            this.labelClickMeSizeChange.Name = "labelClickMeSizeChange";
            this.labelClickMeSizeChange.Size = new System.Drawing.Size(138, 13);
            this.labelClickMeSizeChange.TabIndex = 2;
            this.labelClickMeSizeChange.Text = "\'Click me!\' button size (+3p):";
            // 
            // radioBtnClickMeColorNormal
            // 
            this.radioBtnClickMeColorNormal.AutoSize = true;
            this.radioBtnClickMeColorNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioBtnClickMeColorNormal.Location = new System.Drawing.Point(101, 71);
            this.radioBtnClickMeColorNormal.Name = "radioBtnClickMeColorNormal";
            this.radioBtnClickMeColorNormal.Size = new System.Drawing.Size(85, 17);
            this.radioBtnClickMeColorNormal.TabIndex = 3;
            this.radioBtnClickMeColorNormal.Text = "Normal (+3p)";
            this.radioBtnClickMeColorNormal.UseVisualStyleBackColor = true;
            this.radioBtnClickMeColorNormal.CheckedChanged += new System.EventHandler(this.radioBtnClickMeColorNormal_CheckedChanged);
            // 
            // highScoresGroup
            // 
            this.highScoresGroup.Controls.Add(this.highScoresTable);
            this.highScoresGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.highScoresGroup.Location = new System.Drawing.Point(516, 286);
            this.highScoresGroup.Name = "highScoresGroup";
            this.highScoresGroup.Size = new System.Drawing.Size(200, 224);
            this.highScoresGroup.TabIndex = 12;
            this.highScoresGroup.TabStop = false;
            this.highScoresGroup.Text = "High Scores";
            // 
            // howToPlayGroup
            // 
            this.howToPlayGroup.Controls.Add(this.howToPlayDescription);
            this.howToPlayGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.howToPlayGroup.Location = new System.Drawing.Point(516, 10);
            this.howToPlayGroup.Name = "howToPlayGroup";
            this.howToPlayGroup.Size = new System.Drawing.Size(200, 102);
            this.howToPlayGroup.TabIndex = 13;
            this.howToPlayGroup.TabStop = false;
            this.howToPlayGroup.Text = "How to play?";
            // 
            // howToPlayDescription
            // 
            this.howToPlayDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.howToPlayDescription.Location = new System.Drawing.Point(9, 16);
            this.howToPlayDescription.Name = "howToPlayDescription";
            this.howToPlayDescription.Size = new System.Drawing.Size(182, 84);
            this.howToPlayDescription.TabIndex = 2;
            this.howToPlayDescription.Text = resources.GetString("howToPlayDescription.Text");
            // 
            // labelTimer
            // 
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(437, 518);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(73, 20);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "10.00 s";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scoreValue
            // 
            this.scoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreValue.Location = new System.Drawing.Point(617, 519);
            this.scoreValue.Name = "scoreValue";
            this.scoreValue.Size = new System.Drawing.Size(99, 20);
            this.scoreValue.TabIndex = 2;
            this.scoreValue.Text = "0 p";
            this.scoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScore.Location = new System.Drawing.Point(521, 518);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(94, 21);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score:";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClickMeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 548);
            this.Controls.Add(this.howToPlayGroup);
            this.Controls.Add(this.scoreValue);
            this.Controls.Add(this.highScoresGroup);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.settingsGroup);
            this.Controls.Add(this.progressBarTimer);
            this.Controls.Add(this.gameArena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClickMeGame";
            this.Text = "Click me! - Game";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarClickMeSizeChange)).EndInit();
            this.gameArena.ResumeLayout(false);
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            this.highScoresGroup.ResumeLayout(false);
            this.howToPlayGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickMe;
        private System.Windows.Forms.RadioButton radioBtnClickMeColorYellow;
        private System.Windows.Forms.TextBox inputPlayerName;
        private System.Windows.Forms.RichTextBox highScoresTable;
        private System.Windows.Forms.ProgressBar progressBarTimer;
        private System.Windows.Forms.TrackBar trackBarClickMeSizeChange;
        private System.Windows.Forms.GroupBox gameArena;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.GroupBox highScoresGroup;
        private System.Windows.Forms.Label labelClickMeColorChange;
        private System.Windows.Forms.Label labelClickMeSizeChange;
        private System.Windows.Forms.RadioButton radioBtnClickMeColorNormal;
        private System.Windows.Forms.Label labelTypeYourName;
        private System.Windows.Forms.GroupBox howToPlayGroup;
        private System.Windows.Forms.Label howToPlayDescription;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label scoreValue;
        private System.Windows.Forms.Label labelScore;
    }
}

