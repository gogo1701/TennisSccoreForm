using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisScoreApplication
{
    public partial class NewGameForms : Form
    {
        public NewGameForms()
        {
            InitializeComponent();
        }

        public (string, int) FirstPlayer { get; set; }
        public (string, int) SecondPlayer { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstPlayerName = textBoxFirstPlayerName.Text.Trim();
            int firstPlayerPoints = (int)numericUpDownFirstPlayersPoints.Value;

            string secondPlayerName = textBoxSecondPlayerName.Text.Trim();
            int secondPlayerPoints = (int)numericUpDownSecondPlayersPoints.Value;

            FirstPlayer = (firstPlayerName, firstPlayerPoints);
            SecondPlayer = (secondPlayerName, secondPlayerPoints);

            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private bool CheckIfInputsAreValid()
            => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();

        private bool CheckIfPlayerNamesAreEmpty()
            => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);

        private bool CheckIfPlayerNamesAreSame()
            => this.FirstPlayer.Item1 == this.SecondPlayer.Item1;

        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessages(textBox);
                ShowErrorOnSameNames();
            }
        }

        private void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player Name should not be left blank!";

            if(textBox == this.textBoxFirstPlayerName)
            {
                this.firstPlayerErrorProvider.SetError(textBox, errorText);
                this.labelErrorMessageFirstNameTextBox.Text = "First " + errorText;
            }
            else if(textBox == this.textBoxSecondPlayerName)
            {
                this.secondPlayerErrorProvider.SetError(textBox, errorText);
                this.labelErrorMessageSecondNameTextBox.Text = "Second " + errorText;
            }
        }

        private void RemoveErrorMessages(TextBox textBox)
        {

            if (textBox == this.textBoxFirstPlayerName)
            {
                this.firstPlayerErrorProvider.SetError(textBox, "");
                this.labelErrorMessageFirstNameTextBox.Text = string.Empty;
            }
            else if (textBox == this.textBoxSecondPlayerName)
            {
                this.secondPlayerErrorProvider.SetError(textBox, "");
                this.labelErrorMessageSecondNameTextBox.Text = string.Empty;
            }
        }

        private void ShowErrorOnSameNames()
        {
            if (CheckIfPlayerNamesAreSame())
            {
                this.labelSameNamesErrorMessage.Text = "First Player name should not be the same as Second Player name!";
            }
            else
            {
                this.labelSameNamesErrorMessage.Text = string.Empty;
            }
        }
    }
}
