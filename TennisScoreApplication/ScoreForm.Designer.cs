namespace TennisScoreApplication
{
    partial class ScoreForm
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
            labelTennisScore = new Label();
            listViewRanking = new ListView();
            playerNameColumn = new ColumnHeader();
            scoreColumn = new ColumnHeader();
            labelRanking = new Label();
            labelLatestGames = new Label();
            listViewLatestGames = new ListView();
            firstPlayerColumn = new ColumnHeader();
            secondPlayerColumn = new ColumnHeader();
            winnerColumn = new ColumnHeader();
            totalScoreColumn = new ColumnHeader();
            buttonAddNewGame = new Button();
            SuspendLayout();
            // 
            // labelTennisScore
            // 
            labelTennisScore.Anchor = AnchorStyles.Top;
            labelTennisScore.AutoSize = true;
            labelTennisScore.Font = new Font("Segoe UI", 40F);
            labelTennisScore.Location = new Point(134, 12);
            labelTennisScore.Name = "labelTennisScore";
            labelTennisScore.Size = new Size(613, 72);
            labelTennisScore.TabIndex = 0;
            labelTennisScore.Text = "Tennis Score Application";
            // 
            // listViewRanking
            // 
            listViewRanking.Anchor = AnchorStyles.Top;
            listViewRanking.Columns.AddRange(new ColumnHeader[] { playerNameColumn, scoreColumn });
            listViewRanking.Location = new Point(107, 137);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(664, 97);
            listViewRanking.TabIndex = 1;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            listViewRanking.DoubleClick += listViewRanking_DoubleClick;
            listViewRanking.Resize += listViewRanking_Resize;
            // 
            // playerNameColumn
            // 
            playerNameColumn.Text = "Player";
            // 
            // scoreColumn
            // 
            scoreColumn.Text = "Score";
            // 
            // labelRanking
            // 
            labelRanking.Anchor = AnchorStyles.Top;
            labelRanking.AutoSize = true;
            labelRanking.Font = new Font("Segoe UI", 15F);
            labelRanking.Location = new Point(107, 106);
            labelRanking.Name = "labelRanking";
            labelRanking.Size = new Size(83, 28);
            labelRanking.TabIndex = 2;
            labelRanking.Text = "Ranking";
            // 
            // labelLatestGames
            // 
            labelLatestGames.Anchor = AnchorStyles.Top;
            labelLatestGames.AutoSize = true;
            labelLatestGames.Font = new Font("Segoe UI", 15F);
            labelLatestGames.Location = new Point(107, 288);
            labelLatestGames.Name = "labelLatestGames";
            labelLatestGames.Size = new Size(127, 28);
            labelLatestGames.TabIndex = 4;
            labelLatestGames.Text = "Latest Games";
            // 
            // listViewLatestGames
            // 
            listViewLatestGames.Anchor = AnchorStyles.Top;
            listViewLatestGames.Columns.AddRange(new ColumnHeader[] { firstPlayerColumn, secondPlayerColumn, winnerColumn, totalScoreColumn });
            listViewLatestGames.Location = new Point(107, 319);
            listViewLatestGames.Name = "listViewLatestGames";
            listViewLatestGames.Size = new Size(664, 97);
            listViewLatestGames.TabIndex = 3;
            listViewLatestGames.UseCompatibleStateImageBehavior = false;
            listViewLatestGames.View = View.Details;
            // 
            // firstPlayerColumn
            // 
            firstPlayerColumn.Text = "First Player";
            // 
            // secondPlayerColumn
            // 
            secondPlayerColumn.Text = "Second Player";
            // 
            // winnerColumn
            // 
            winnerColumn.Text = "Winner";
            // 
            // totalScoreColumn
            // 
            totalScoreColumn.Text = "Score";
            // 
            // buttonAddNewGame
            // 
            buttonAddNewGame.Anchor = AnchorStyles.Top;
            buttonAddNewGame.Font = new Font("Segoe UI", 15F);
            buttonAddNewGame.Location = new Point(593, 279);
            buttonAddNewGame.Name = "buttonAddNewGame";
            buttonAddNewGame.Size = new Size(178, 37);
            buttonAddNewGame.TabIndex = 5;
            buttonAddNewGame.Text = "Add new game";
            buttonAddNewGame.UseVisualStyleBackColor = true;
            buttonAddNewGame.Click += buttonAddNewGame_Click;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 450);
            Controls.Add(buttonAddNewGame);
            Controls.Add(labelLatestGames);
            Controls.Add(listViewLatestGames);
            Controls.Add(labelRanking);
            Controls.Add(listViewRanking);
            Controls.Add(labelTennisScore);
            Name = "ScoreForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTennisScore;
        private ListView listViewRanking;
        private ColumnHeader playerNameColumn;
        private ColumnHeader scoreColumn;
        private Label labelRanking;
        private Label labelLatestGames;
        private ListView listViewLatestGames;
        private Button buttonAddNewGame;
        private ColumnHeader firstPlayerColumn;
        private ColumnHeader secondPlayerColumn;
        private ColumnHeader winnerColumn;
        private ColumnHeader totalScoreColumn;
    }
}
