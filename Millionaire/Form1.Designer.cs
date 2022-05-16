namespace Millionaire
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAnswerA = new System.Windows.Forms.Button();
            this.BtnAnswerD = new System.Windows.Forms.Button();
            this.BtnAnswerB = new System.Windows.Forms.Button();
            this.BtnAnswerC = new System.Windows.Forms.Button();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.ListLevel = new System.Windows.Forms.ListBox();
            this.BtnAskTheAudience = new System.Windows.Forms.Button();
            this.BtnExtraChance = new System.Windows.Forms.Button();
            this.BtnFiftyFifty = new System.Windows.Forms.Button();
            this.BtnFriendCall = new System.Windows.Forms.Button();
            this.BtnChangeQuestion = new System.Windows.Forms.Button();
            this.BtnLeaderboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fireproofLevelLabel = new System.Windows.Forms.Label();
            this.BtnChangePlayerInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Millionaire.Properties.Resources.maxresdefault;
            this.pictureBox1.Location = new System.Drawing.Point(139, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAnswerA
            // 
            this.BtnAnswerA.Location = new System.Drawing.Point(174, 428);
            this.BtnAnswerA.Name = "BtnAnswerA";
            this.BtnAnswerA.Size = new System.Drawing.Size(177, 45);
            this.BtnAnswerA.TabIndex = 1;
            this.BtnAnswerA.Tag = "1";
            this.BtnAnswerA.Text = "Ответ A";
            this.BtnAnswerA.UseVisualStyleBackColor = true;
            this.BtnAnswerA.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // BtnAnswerD
            // 
            this.BtnAnswerD.Location = new System.Drawing.Point(432, 479);
            this.BtnAnswerD.Name = "BtnAnswerD";
            this.BtnAnswerD.Size = new System.Drawing.Size(177, 45);
            this.BtnAnswerD.TabIndex = 2;
            this.BtnAnswerD.Tag = "4";
            this.BtnAnswerD.Text = "Ответ D";
            this.BtnAnswerD.UseVisualStyleBackColor = true;
            this.BtnAnswerD.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // BtnAnswerB
            // 
            this.BtnAnswerB.Location = new System.Drawing.Point(174, 479);
            this.BtnAnswerB.Name = "BtnAnswerB";
            this.BtnAnswerB.Size = new System.Drawing.Size(177, 45);
            this.BtnAnswerB.TabIndex = 3;
            this.BtnAnswerB.Tag = "2";
            this.BtnAnswerB.Text = "Ответ B";
            this.BtnAnswerB.UseVisualStyleBackColor = true;
            this.BtnAnswerB.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // BtnAnswerC
            // 
            this.BtnAnswerC.Location = new System.Drawing.Point(432, 428);
            this.BtnAnswerC.Name = "BtnAnswerC";
            this.BtnAnswerC.Size = new System.Drawing.Size(177, 45);
            this.BtnAnswerC.TabIndex = 4;
            this.BtnAnswerC.Tag = "3";
            this.BtnAnswerC.Text = "Ответ C";
            this.BtnAnswerC.UseVisualStyleBackColor = true;
            this.BtnAnswerC.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // LblQuestion
            // 
            this.LblQuestion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuestion.Location = new System.Drawing.Point(139, 327);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(509, 89);
            this.LblQuestion.TabIndex = 5;
            this.LblQuestion.Text = "Вопрос";
            // 
            // ListLevel
            // 
            this.ListLevel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListLevel.FormattingEnabled = true;
            this.ListLevel.ItemHeight = 22;
            this.ListLevel.Items.AddRange(new object[] {
            "3 000 000",
            "1 500 000",
            "   800 000",
            "   400 000",
            "   200 000",
            "   100 000",
            "     50 000",
            "     25 000",
            "     15 000",
            "     10 000",
            "       5 000",
            "       3 000",
            "       2 000",
            "       1 000",
            "          500"});
            this.ListLevel.Location = new System.Drawing.Point(675, 12);
            this.ListLevel.Name = "ListLevel";
            this.ListLevel.Size = new System.Drawing.Size(102, 334);
            this.ListLevel.TabIndex = 6;
            this.ListLevel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListLevel_MouseClick);
            // 
            // BtnAskTheAudience
            // 
            this.BtnAskTheAudience.Location = new System.Drawing.Point(13, 104);
            this.BtnAskTheAudience.Name = "BtnAskTheAudience";
            this.BtnAskTheAudience.Size = new System.Drawing.Size(107, 51);
            this.BtnAskTheAudience.TabIndex = 7;
            this.BtnAskTheAudience.Text = "Помощь зала";
            this.BtnAskTheAudience.UseVisualStyleBackColor = true;
            this.BtnAskTheAudience.Click += new System.EventHandler(this.BtnAskTheAudience_Click);
            // 
            // BtnExtraChance
            // 
            this.BtnExtraChance.Location = new System.Drawing.Point(13, 218);
            this.BtnExtraChance.Name = "BtnExtraChance";
            this.BtnExtraChance.Size = new System.Drawing.Size(107, 51);
            this.BtnExtraChance.TabIndex = 8;
            this.BtnExtraChance.Text = "Право на ошибку";
            this.BtnExtraChance.UseVisualStyleBackColor = true;
            this.BtnExtraChance.Click += new System.EventHandler(this.BntExtraChance_Click);
            // 
            // BtnFiftyFifty
            // 
            this.BtnFiftyFifty.Location = new System.Drawing.Point(13, 47);
            this.BtnFiftyFifty.Name = "BtnFiftyFifty";
            this.BtnFiftyFifty.Size = new System.Drawing.Size(107, 51);
            this.BtnFiftyFifty.TabIndex = 9;
            this.BtnFiftyFifty.Text = "50 / 50";
            this.BtnFiftyFifty.UseVisualStyleBackColor = true;
            this.BtnFiftyFifty.Click += new System.EventHandler(this.BntFiftyFifty_Click);
            // 
            // BtnFriendCall
            // 
            this.BtnFriendCall.Location = new System.Drawing.Point(13, 161);
            this.BtnFriendCall.Name = "BtnFriendCall";
            this.BtnFriendCall.Size = new System.Drawing.Size(107, 51);
            this.BtnFriendCall.TabIndex = 10;
            this.BtnFriendCall.Text = "Звонок другу";
            this.BtnFriendCall.UseVisualStyleBackColor = true;
            this.BtnFriendCall.Click += new System.EventHandler(this.BtnFriendCall_Click);
            // 
            // BtnChangeQuestion
            // 
            this.BtnChangeQuestion.Location = new System.Drawing.Point(13, 275);
            this.BtnChangeQuestion.Name = "BtnChangeQuestion";
            this.BtnChangeQuestion.Size = new System.Drawing.Size(107, 51);
            this.BtnChangeQuestion.TabIndex = 11;
            this.BtnChangeQuestion.Text = "Замена вопроса";
            this.BtnChangeQuestion.UseVisualStyleBackColor = true;
            this.BtnChangeQuestion.Click += new System.EventHandler(this.BtnChangeQuestion_Click);
            // 
            // BtnLeaderboard
            // 
            this.BtnLeaderboard.Location = new System.Drawing.Point(675, 403);
            this.BtnLeaderboard.Name = "BtnLeaderboard";
            this.BtnLeaderboard.Size = new System.Drawing.Size(102, 57);
            this.BtnLeaderboard.TabIndex = 12;
            this.BtnLeaderboard.Text = "Доска лидеров";
            this.BtnLeaderboard.UseVisualStyleBackColor = true;
            this.BtnLeaderboard.Click += new System.EventHandler(this.BtnLeaderboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Несгораемая сумма:";
            // 
            // fireproofLevelLabel
            // 
            this.fireproofLevelLabel.Location = new System.Drawing.Point(677, 377);
            this.fireproofLevelLabel.Name = "fireproofLevelLabel";
            this.fireproofLevelLabel.Size = new System.Drawing.Size(100, 23);
            this.fireproofLevelLabel.TabIndex = 14;
            this.fireproofLevelLabel.Text = "-";
            this.fireproofLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnChangePlayerInfo
            // 
            this.BtnChangePlayerInfo.Location = new System.Drawing.Point(675, 473);
            this.BtnChangePlayerInfo.Name = "BtnChangePlayerInfo";
            this.BtnChangePlayerInfo.Size = new System.Drawing.Size(102, 57);
            this.BtnChangePlayerInfo.TabIndex = 15;
            this.BtnChangePlayerInfo.Text = "Изменить несгораемую сумму";
            this.BtnChangePlayerInfo.UseVisualStyleBackColor = true;
            this.BtnChangePlayerInfo.Click += new System.EventHandler(this.BtnChangePlayerInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.BtnChangePlayerInfo);
            this.Controls.Add(this.fireproofLevelLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLeaderboard);
            this.Controls.Add(this.BtnChangeQuestion);
            this.Controls.Add(this.BtnFriendCall);
            this.Controls.Add(this.BtnFiftyFifty);
            this.Controls.Add(this.BtnExtraChance);
            this.Controls.Add(this.BtnAskTheAudience);
            this.Controls.Add(this.ListLevel);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.BtnAnswerC);
            this.Controls.Add(this.BtnAnswerB);
            this.Controls.Add(this.BtnAnswerD);
            this.Controls.Add(this.BtnAnswerA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Who wans to be a Millionaire";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnAnswerA;
        private Button BtnAnswerD;
        private Button BtnAnswerB;
        private Button BtnAnswerC;
        private Label LblQuestion;
        private ListBox ListLevel;
        private Button BtnAskTheAudience;
        private Button BtnExtraChance;
        private Button BtnFiftyFifty;
        private Button BtnFriendCall;
        private Button BtnChangeQuestion;
        private Button BtnLeaderboard;
        private Label label1;
        private Label fireproofLevelLabel;
        private Button BtnChangePlayerInfo;
    }
}