using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyckohjulet
{
    public partial class Lyckohjulet : Form
    {
        public Lyckohjulet()
        {
            InitializeComponent();
        }

        public List<int> selectedNumbers = new List<int>();

        private void buttonSnurraHjulet_Click(object sender, EventArgs e)
        {
            // nollställ textfälten
            resetTextBoxes();
            //spela Lyckohjulet
            Game game = new Game();
            GameResult result = game.playLyckohjulet(selectedNumbers);
            // hur gick spelet?
            int winningNumber = result.winningNumber;
            String medal = result.medal;
            String message = result.message;
            //Visa vinstnummer och placering i messageTextBoxar
            presentTheWinner(winningNumber, medal);
            publishMessage(message);

        // TODO Ändra färg på knappen för vinnande nummer
        }

      


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 1;
            checkBoxChangeStatus(checkBox1, buttonNo);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 2;
            checkBoxChangeStatus(checkBox2, buttonNo);
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 3;
            checkBoxChangeStatus(checkBox3, buttonNo);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 4;
            checkBoxChangeStatus(checkBox4, buttonNo);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 5;
            checkBoxChangeStatus(checkBox5, buttonNo);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 6;
            checkBoxChangeStatus(checkBox6, buttonNo);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 7;
            checkBoxChangeStatus(checkBox7, buttonNo);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 8;
            checkBoxChangeStatus(checkBox8, buttonNo);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 9;
            checkBoxChangeStatus(checkBox9, buttonNo);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 10;
            checkBoxChangeStatus(checkBox10, buttonNo);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 11;
            checkBoxChangeStatus(checkBox11, buttonNo);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 12;
            checkBoxChangeStatus(checkBox12, buttonNo);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 13;
            checkBoxChangeStatus(checkBox13, buttonNo);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 14;
            checkBoxChangeStatus(checkBox14, buttonNo);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 15;
            checkBoxChangeStatus(checkBox15, buttonNo);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 16;
            checkBoxChangeStatus(checkBox16, buttonNo);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 17;
            checkBoxChangeStatus(checkBox17, buttonNo);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 18;
            checkBoxChangeStatus(checkBox18, buttonNo);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 19;
            checkBoxChangeStatus(checkBox19, buttonNo);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            int buttonNo = 20;
            checkBoxChangeStatus(checkBox20, buttonNo);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Not used here
        }

        
        /// <summary>
        /// set button as selected
        /// </summary>
        /// <returns></returns>
        private bool selectedNumber()
        {
            return true;
        }

        private void checkBoxChangeStatus(CheckBox checkBox, int buttonNo)
        {
            if (checkBox.Checked)
            {
                checkBox.BackColor = Color.Yellow;
                selectedNumbers.Add(buttonNo);
            }
            else
            {
                checkBox.BackColor = Color.LightYellow;
                selectedNumbers.Remove(buttonNo);
            }
        }

        

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {      
            //Not used
        }


        public void presentTheWinner(int winningNumber, String medal)
        {
            vinnandeNrTextBox.Text = $"{winningNumber}";
            medalTextBox.Text = $"{medal}";
        }

        private void resetTextBoxes()
        {
            vinnandeNrTextBox.Text = "";
            medalTextBox.Text = "";
            messageTextBox.Text = "";
        }

        public void publishMessage(string message)
        {
            messageTextBox.Text = message;
        }

    }
}
