using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<int, Color> _colors =
            new Dictionary<int, Color>
            {
                { 0, SystemColors.Control },
                { 1, Color.LimeGreen },
                { 2, Color.Red }
            };

        private readonly Dictionary<int, PictureBox> _pictureBoxes =
            new Dictionary<int, PictureBox>();

        private readonly Dictionary<int, Button> _buttons =
            new Dictionary<int, Button>();

        public Form1()
        {
            InitializeComponent();

            _pictureBoxes.Add(1, picRock);
            _pictureBoxes.Add(2, picPaper);
            _pictureBoxes.Add(3, picScissors);

            _buttons.Add(1, btnRock);
            _buttons.Add(2, btnPaper);
            _buttons.Add(3, btnScissors);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            CheckConditions(2);
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            CheckConditions(1);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            CheckConditions(3);
        }

        private void CheckConditions(int userChoice)
        {
            var x = Program.CompareChoices(userChoice);

            pnlComputer.BackColor = _colors[x];
            ShowComputerChoicePicture();
            ShowUserChoiceButton(userChoice);
        }

        private void ShowUserChoiceButton(int userChoice)
        {
            ChangeUserButtonsEnable(false);
            _buttons[userChoice].Enabled = true;
        }

        private void ChangeUserButtonsEnable(bool isEnable)
        {
            foreach (var buttonsValue in _buttons.Values)
            {
                buttonsValue.Enabled = isEnable;
            }
        }


        private void ShowComputerChoicePicture()
        {
            var computerChoice = Program.GetComputerChoice();

            // Hide all pictures.
            ChangeComputerChoicePictureVisibility(false);

            // Show computer choice picture.
            _pictureBoxes[computerChoice].Visible = true;
        }

        private void ChangeComputerChoicePictureVisibility(bool isVisible)
        {
            foreach (var pictureBox in _pictureBoxes.Values)
            {
                pictureBox.Visible = isVisible;
            }
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Program.InitiateComputerChoice();
            ChangeUserButtonsEnable(true);
            ChangeComputerChoicePictureVisibility(false);
            pnlComputer.BackColor = _colors[0];
        }

    }
}