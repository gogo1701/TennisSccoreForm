namespace TennisScoreApplication
{
    partial class PlayerInfoForm
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
            labelPlayerName = new Label();
            labelDraw = new Label();
            listViewDraw = new ListView();
            competitorDraw = new ColumnHeader();
            scoreDraw = new ColumnHeader();
            listViewLosses = new ListView();
            competitorLoses = new ColumnHeader();
            scoreLosses = new ColumnHeader();
            listViewVictories = new ListView();
            competitorVictories = new ColumnHeader();
            scoreVictories = new ColumnHeader();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.Anchor = AnchorStyles.Top;
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 45F);
            labelPlayerName.Location = new Point(210, 9);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(371, 81);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Player Name";
            // 
            // labelDraw
            // 
            labelDraw.Location = new Point(0, 0);
            labelDraw.Name = "labelDraw";
            labelDraw.Size = new Size(100, 23);
            labelDraw.TabIndex = 10;
            // 
            // listViewDraw
            // 
            listViewDraw.Columns.AddRange(new ColumnHeader[] { competitorDraw, scoreDraw });
            listViewDraw.Location = new Point(562, 195);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(211, 224);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // competitorDraw
            // 
            competitorDraw.Text = "Competitor";
            // 
            // scoreDraw
            // 
            scoreDraw.Text = "Score";
            // 
            // listViewLosses
            // 
            listViewLosses.Columns.AddRange(new ColumnHeader[] { competitorLoses, scoreLosses });
            listViewLosses.Location = new Point(296, 195);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(211, 224);
            listViewLosses.TabIndex = 7;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // competitorLoses
            // 
            competitorLoses.Text = "Competitor";
            // 
            // scoreLosses
            // 
            scoreLosses.Text = "Score";
            // 
            // listViewVictories
            // 
            listViewVictories.Columns.AddRange(new ColumnHeader[] { competitorVictories, scoreVictories });
            listViewVictories.Location = new Point(30, 195);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(211, 224);
            listViewVictories.TabIndex = 9;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // competitorVictories
            // 
            competitorVictories.Text = "Competitor";
            // 
            // scoreVictories
            // 
            scoreVictories.Text = "Score";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 45F);
            label1.Location = new Point(48, 111);
            label1.Name = "label1";
            label1.Size = new Size(165, 81);
            label1.TabIndex = 11;
            label1.Text = "Wins";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 45F);
            label4.Location = new Point(296, 111);
            label4.Name = "label4";
            label4.Size = new Size(204, 81);
            label4.TabIndex = 12;
            label4.Text = "Losses";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 45F);
            label5.Location = new Point(586, 111);
            label5.Name = "label5";
            label5.Size = new Size(172, 81);
            label5.TabIndex = 13;
            label5.Text = "Draw";
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(listViewVictories);
            Controls.Add(listViewLosses);
            Controls.Add(listViewDraw);
            Controls.Add(labelDraw);
            Controls.Add(labelPlayerName);
            Name = "PlayerInfoForm";
            Text = "PlayerInfoForm";
            Load += PlayerInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Label label2;
        private Label label3;
        private Label labelDraw;
        private ListView listView2;
        private ListView listViewDraw;
        private ListView listViewLosses;
        private ListView listViewVictories;
        private ColumnHeader competitorDraw;
        private ColumnHeader scoreDraw;
        private ColumnHeader competitorLoses;
        private ColumnHeader scoreLosses;
        private ColumnHeader competitorVictories;
        private ColumnHeader scoreVictories;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}