namespace TennisScoreApplication
{
    partial class NewGameForms
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
            components = new System.ComponentModel.Container();
            labelNewGame = new Label();
            textBoxFirstPlayerName = new TextBox();
            textBoxSecondPlayerName = new TextBox();
            numericUpDownFirstPlayersPoints = new NumericUpDown();
            labelFirstPlayerName = new Label();
            labelSecondPlayerName = new Label();
            buttonSaveGame = new Button();
            labelFirstPlayerPoints = new Label();
            labelSecondPlayerPoints = new Label();
            numericUpDownSecondPlayersPoints = new NumericUpDown();
            firstPlayerErrorProvider = new ErrorProvider(components);
            secondPlayerErrorProvider = new ErrorProvider(components);
            labelErrorMessageFirstNameTextBox = new Label();
            labelErrorMessageSecondNameTextBox = new Label();
            labelSameNamesErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayersPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayersPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstPlayerErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondPlayerErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // labelNewGame
            // 
            labelNewGame.AutoSize = true;
            labelNewGame.Font = new Font("Segoe UI", 20F);
            labelNewGame.Location = new Point(172, 5);
            labelNewGame.Name = "labelNewGame";
            labelNewGame.Size = new Size(148, 37);
            labelNewGame.TabIndex = 0;
            labelNewGame.Text = "New Game";
            // 
            // textBoxFirstPlayerName
            // 
            textBoxFirstPlayerName.Location = new Point(12, 45);
            textBoxFirstPlayerName.Name = "textBoxFirstPlayerName";
            textBoxFirstPlayerName.Size = new Size(171, 23);
            textBoxFirstPlayerName.TabIndex = 1;
            textBoxFirstPlayerName.Validating += ValidatePlayerName;
            // 
            // textBoxSecondPlayerName
            // 
            textBoxSecondPlayerName.Location = new Point(310, 45);
            textBoxSecondPlayerName.Name = "textBoxSecondPlayerName";
            textBoxSecondPlayerName.Size = new Size(222, 23);
            textBoxSecondPlayerName.TabIndex = 2;
            textBoxSecondPlayerName.Validating += ValidatePlayerName;
            // 
            // numericUpDownFirstPlayersPoints
            // 
            numericUpDownFirstPlayersPoints.Location = new Point(143, 89);
            numericUpDownFirstPlayersPoints.Name = "numericUpDownFirstPlayersPoints";
            numericUpDownFirstPlayersPoints.Size = new Size(40, 23);
            numericUpDownFirstPlayersPoints.TabIndex = 3;
            // 
            // labelFirstPlayerName
            // 
            labelFirstPlayerName.AutoSize = true;
            labelFirstPlayerName.Location = new Point(12, 27);
            labelFirstPlayerName.Name = "labelFirstPlayerName";
            labelFirstPlayerName.Size = new Size(48, 15);
            labelFirstPlayerName.TabIndex = 5;
            labelFirstPlayerName.Text = "Player 1";
            // 
            // labelSecondPlayerName
            // 
            labelSecondPlayerName.AutoSize = true;
            labelSecondPlayerName.Location = new Point(484, 27);
            labelSecondPlayerName.Name = "labelSecondPlayerName";
            labelSecondPlayerName.Size = new Size(48, 15);
            labelSecondPlayerName.TabIndex = 6;
            labelSecondPlayerName.Text = "Player 2";
            // 
            // buttonSaveGame
            // 
            buttonSaveGame.Font = new Font("Segoe UI", 15F);
            buttonSaveGame.Location = new Point(209, 44);
            buttonSaveGame.Name = "buttonSaveGame";
            buttonSaveGame.Size = new Size(75, 67);
            buttonSaveGame.TabIndex = 7;
            buttonSaveGame.Text = "Save";
            buttonSaveGame.UseVisualStyleBackColor = true;
            buttonSaveGame.Click += button1_Click;
            // 
            // labelFirstPlayerPoints
            // 
            labelFirstPlayerPoints.AutoSize = true;
            labelFirstPlayerPoints.Location = new Point(143, 71);
            labelFirstPlayerPoints.Name = "labelFirstPlayerPoints";
            labelFirstPlayerPoints.Size = new Size(40, 15);
            labelFirstPlayerPoints.TabIndex = 8;
            labelFirstPlayerPoints.Text = "Points";
            // 
            // labelSecondPlayerPoints
            // 
            labelSecondPlayerPoints.AutoSize = true;
            labelSecondPlayerPoints.Location = new Point(310, 71);
            labelSecondPlayerPoints.Name = "labelSecondPlayerPoints";
            labelSecondPlayerPoints.Size = new Size(40, 15);
            labelSecondPlayerPoints.TabIndex = 10;
            labelSecondPlayerPoints.Text = "Points";
            // 
            // numericUpDownSecondPlayersPoints
            // 
            numericUpDownSecondPlayersPoints.Location = new Point(310, 89);
            numericUpDownSecondPlayersPoints.Name = "numericUpDownSecondPlayersPoints";
            numericUpDownSecondPlayersPoints.Size = new Size(40, 23);
            numericUpDownSecondPlayersPoints.TabIndex = 9;
            // 
            // firstPlayerErrorProvider
            // 
            firstPlayerErrorProvider.ContainerControl = this;
            // 
            // secondPlayerErrorProvider
            // 
            secondPlayerErrorProvider.ContainerControl = this;
            // 
            // labelErrorMessageFirstNameTextBox
            // 
            labelErrorMessageFirstNameTextBox.AutoSize = true;
            labelErrorMessageFirstNameTextBox.Location = new Point(12, 71);
            labelErrorMessageFirstNameTextBox.Name = "labelErrorMessageFirstNameTextBox";
            labelErrorMessageFirstNameTextBox.Size = new Size(0, 15);
            labelErrorMessageFirstNameTextBox.TabIndex = 11;
            // 
            // labelErrorMessageSecondNameTextBox
            // 
            labelErrorMessageSecondNameTextBox.AutoSize = true;
            labelErrorMessageSecondNameTextBox.Location = new Point(356, 71);
            labelErrorMessageSecondNameTextBox.Name = "labelErrorMessageSecondNameTextBox";
            labelErrorMessageSecondNameTextBox.Size = new Size(0, 15);
            labelErrorMessageSecondNameTextBox.TabIndex = 12;
            // 
            // labelSameNamesErrorMessage
            // 
            labelSameNamesErrorMessage.AutoSize = true;
            labelSameNamesErrorMessage.Location = new Point(134, 115);
            labelSameNamesErrorMessage.Name = "labelSameNamesErrorMessage";
            labelSameNamesErrorMessage.Size = new Size(0, 15);
            labelSameNamesErrorMessage.TabIndex = 13;
            // 
            // NewGameForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 139);
            Controls.Add(labelSameNamesErrorMessage);
            Controls.Add(labelErrorMessageSecondNameTextBox);
            Controls.Add(labelErrorMessageFirstNameTextBox);
            Controls.Add(labelSecondPlayerPoints);
            Controls.Add(numericUpDownSecondPlayersPoints);
            Controls.Add(labelFirstPlayerPoints);
            Controls.Add(buttonSaveGame);
            Controls.Add(labelSecondPlayerName);
            Controls.Add(labelFirstPlayerName);
            Controls.Add(numericUpDownFirstPlayersPoints);
            Controls.Add(textBoxSecondPlayerName);
            Controls.Add(textBoxFirstPlayerName);
            Controls.Add(labelNewGame);
            Name = "NewGameForms";
            Text = "NewGameForms";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayersPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayersPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstPlayerErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondPlayerErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNewGame;
        private TextBox textBoxFirstPlayerName;
        private TextBox textBoxSecondPlayerName;
        private NumericUpDown numericUpDownFirstPlayersPoints;
        private Label labelFirstPlayerName;
        private Label labelSecondPlayerName;
        private Button buttonSaveGame;
        private Label labelFirstPlayerPoints;
        private Label labelSecondPlayerPoints;
        private NumericUpDown numericUpDownSecondPlayersPoints;
        private ErrorProvider firstPlayerErrorProvider;
        private ErrorProvider secondPlayerErrorProvider;
        private Label labelErrorMessageSecondNameTextBox;
        private Label labelErrorMessageFirstNameTextBox;
        private Label labelSameNamesErrorMessage;
    }
}