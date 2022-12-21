using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreedyChicken
{
    
    
    public partial class GreedyChicken : Form
    {
        private int _goal;
        public GreedyChicken(int goal)
        {
            _goal = goal;
            InitializeComponent();
        }
      
        private void GreedyChicken_Load(object sender, EventArgs e)
        {
            HowManyPlayersPlaying();
            lblTurn.Visible = false;
            btnSave.Enabled = false;
            pictureArrow.Visible = false;
            GameSettings gameSettings = (GameSettings)Application.OpenForms["GameSettings"];
            pnlGamePlayer1.BackColor = gameSettings.btnColor1.BackColor;
            pnlGamePlayer2.BackColor = gameSettings.btnColor2.BackColor;
            pnlGamePlayer3.BackColor = gameSettings.btnColor3.BackColor;
            pnlGamePlayer4.BackColor = gameSettings.btnColor4.BackColor;

            btnRoll.BackColor = pnlGamePlayer1.BackColor;
            btnSave.BackColor = pnlGamePlayer1.BackColor;

            lblGamePlayer1.Text = gameSettings.txtPlayer1.Text;
            lblGamePlayer2.Text = gameSettings.txtPlayer2.Text;
            lblGamePlayer3.Text = gameSettings.txtPlayer3.Text;
            lblGamePlayer4.Text = gameSettings.txtPlayer4.Text;

        }
        private void HowManyPlayersPlaying()
        {
            GameSettings gs1 = (GameSettings)Application.OpenForms["GameSettings"];
            switch (Convert.ToInt32(gs1.txtBoxPlayerNumber.Text))
            {
                case 2:
                    pnlGamePlayer3.Visible = false;
                    pnlGamePlayer4.Visible = false;
                    break;
                case 3:
                    pnlGamePlayer4.Visible = false;
                    break;
            }
          
        }
        private void PlayForP1()
        {
            lblTurn.Visible = true;
            lblTurn.Text = $"Its {lblGamePlayer1.Text}'s Turn";
            int dice;
            int bank = Convert.ToInt32(lblP1Bank.Text);

            Bitmap dice1 = Properties.Resources.dice1;
            Bitmap dice2 = Properties.Resources.dice2;
            Bitmap dice3 = Properties.Resources.dice3;
            Bitmap dice4 = Properties.Resources.dice4;
            Bitmap dice5 = Properties.Resources.dice5;
            Bitmap dice6 = Properties.Resources.dice6;
            Random random = new Random();
            dice = random.Next(1, 7);

            switch (dice)
            {
                case 1:
                    pictureDice.Image = dice1;
                    lblP1Bank.Text = "0";
                    break;
                case 2:
                    pictureDice.Image = dice2;
                    bank += 2;
                    lblP1Bank.Text = bank.ToString();
                    break;
                case 3:
                    pictureDice.Image = dice3;
                    bank += 3;
                    lblP1Bank.Text = bank.ToString();
                    break;
                case 4:
                    pictureDice.Image = dice4;
                    bank += 4;
                    lblP1Bank.Text = bank.ToString();
                    break;
                case 5:
                    pictureDice.Image = dice5;
                    bank += 5;
                    lblP1Bank.Text = bank.ToString();
                    break;
                case 6:
                    pictureDice.Image = dice6;
                    bank += 6;
                    lblP1Bank.Text = bank.ToString();
                    break;
               
            }



        }
        private void PlayForP2()
        {
            
            lblTurn.Visible = true;
            lblTurn.Text = $"Its {lblGamePlayer2.Text}'s Turn";
            int dice;
            int bank = Convert.ToInt32(lblP2Bank.Text);

            Bitmap dice1 = Properties.Resources.dice1;
            Bitmap dice2 = Properties.Resources.dice2;
            Bitmap dice3 = Properties.Resources.dice3;
            Bitmap dice4 = Properties.Resources.dice4;
            Bitmap dice5 = Properties.Resources.dice5;
            Bitmap dice6 = Properties.Resources.dice6;
            Random random = new Random();
            dice = random.Next(1, 7);

            switch (dice)
            {
                case 1:
                    pictureDice.Image = dice1;
                    lblP2Bank.Text = "0";
                    break;
                case 2:
                    pictureDice.Image = dice2;
                    bank += 2;
                    lblP2Bank.Text = bank.ToString();
                    break;
                case 3:
                    pictureDice.Image = dice3;
                    bank += 3;
                    lblP2Bank.Text = bank.ToString();
                    break;
                case 4:
                    pictureDice.Image = dice4;
                    bank += 4;
                    lblP2Bank.Text = bank.ToString();
                    break;
                case 5:
                    pictureDice.Image = dice5;
                    bank += 5;
                    lblP2Bank.Text = bank.ToString();
                    break;
                case 6:
                    pictureDice.Image = dice6;
                    bank += 6;
                    lblP2Bank.Text = bank.ToString();
                    break;

            }




        }
        private void PlayForP3()
        {
            lblTurn.Visible = true;
            lblTurn.Text = $"Its {lblGamePlayer3.Text}'s Turn";
            int dice;
            int bank = Convert.ToInt32(lblP3Bank.Text);

            Bitmap dice1 = Properties.Resources.dice1;
            Bitmap dice2 = Properties.Resources.dice2;
            Bitmap dice3 = Properties.Resources.dice3;
            Bitmap dice4 = Properties.Resources.dice4;
            Bitmap dice5 = Properties.Resources.dice5;
            Bitmap dice6 = Properties.Resources.dice6;
            Random random = new Random();
            dice = random.Next(1, 7);

            switch (dice)
            {
                case 1:
                    pictureDice.Image = dice1;
                    lblP3Bank.Text = "0";
                    break;
                case 2:
                    pictureDice.Image = dice2;
                    bank += 2;
                    lblP3Bank.Text = bank.ToString();
                    break;
                case 3:
                    pictureDice.Image = dice3;
                    bank += 3;
                    lblP3Bank.Text = bank.ToString();
                    break;
                case 4:
                    pictureDice.Image = dice4;
                    bank += 4;
                    lblP3Bank.Text = bank.ToString();
                    break;
                case 5:
                    pictureDice.Image = dice5;
                    bank += 5;
                    lblP3Bank.Text = bank.ToString();
                    break;
                case 6:
                    pictureDice.Image = dice6;
                    bank += 6;
                    lblP3Bank.Text = bank.ToString();
                    break;

            }
        }
        private void PlayForP4()
        {
            lblTurn.Visible = true;
            lblTurn.Text = $"Its {lblGamePlayer4.Text}'s Turn";
            int dice;
            int bank = Convert.ToInt32(lblP4Bank.Text);

            Bitmap dice1 = Properties.Resources.dice1;
            Bitmap dice2 = Properties.Resources.dice2;
            Bitmap dice3 = Properties.Resources.dice3;
            Bitmap dice4 = Properties.Resources.dice4;
            Bitmap dice5 = Properties.Resources.dice5;
            Bitmap dice6 = Properties.Resources.dice6;
            Random random = new Random();
            dice = random.Next(1, 7);

            switch (dice)
            {
                case 1:
                    pictureDice.Image = dice1;
                    lblP4Bank.Text = "0";
                    break;
                case 2:
                    pictureDice.Image = dice2;
                    bank += 2;
                    lblP4Bank.Text = bank.ToString();
                    break;
                case 3:
                    pictureDice.Image = dice3;
                    bank += 3;
                    lblP4Bank.Text = bank.ToString();
                    break;
                case 4:
                    pictureDice.Image = dice4;
                    bank += 4;
                    lblP4Bank.Text = bank.ToString();
                    break;
                case 5:
                    pictureDice.Image = dice5;
                    bank += 5;
                    lblP4Bank.Text = bank.ToString();
                    break;
                case 6:
                    pictureDice.Image = dice6;
                    bank += 6;
                    lblP4Bank.Text = bank.ToString();
                    break;

            }
        }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            
            if (btnRoll.BackColor == pnlGamePlayer1.BackColor)
            {
                pictureArrow.Visible = true;
                btnSave.Enabled = true;
                PlayForP1();
                int bank1 = Convert.ToInt32(lblP1Bank.Text);
                int score1 = Convert.ToInt32(lblP1Score.Text);
                
                if (bank1+score1>=_goal)
                {
                    MessageBox.Show($"{lblGamePlayer1.Text} won!");
                }
            }
            else if (btnRoll.BackColor == pnlGamePlayer2.BackColor)
            {
                PlayForP2();
                int bank2 = Convert.ToInt32(lblP2Bank.Text);
                int score2 = Convert.ToInt32(lblP2Score.Text);

                if (bank2+ score2 >= _goal)
                {
                    MessageBox.Show($"{lblGamePlayer2.Text} won!");
                }
            }
            else if (btnRoll.BackColor == pnlGamePlayer3.BackColor)
            {
                PlayForP3();
                int bank3 = Convert.ToInt32(lblP3Bank.Text);
                int score3 = Convert.ToInt32(lblP3Score.Text);

                if (bank3 + score3 >= _goal)
                {
                    MessageBox.Show($"{lblGamePlayer3.Text} won!");
                }
            }
            else if (btnRoll.BackColor == pnlGamePlayer4.BackColor)
            {
                PlayForP4();
                int bank4 = Convert.ToInt32(lblP4Bank.Text);
                int score4 = Convert.ToInt32(lblP4Score.Text);

                if (bank4 + score4 >= _goal)
                {
                    MessageBox.Show($"{lblGamePlayer4.Text} won!");
                }
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
    
            

            if (btnRoll.BackColor==pnlGamePlayer1.BackColor)
            {
                int bank1 = Convert.ToInt32(lblP1Bank.Text);
                int score1 = Convert.ToInt32(lblP1Score.Text);
                score1+= bank1;
                lblP1Score.Text = score1.ToString();               
                lblP1Bank.Text = "0";
                btnRoll.BackColor = pnlGamePlayer2.BackColor; btnSave.BackColor = pnlGamePlayer2.BackColor;
            }
            else if (btnRoll.BackColor == pnlGamePlayer2.BackColor)
            {
                int bank2 = Convert.ToInt32(lblP2Bank.Text);
                int score2= Convert.ToInt32(lblP2Score.Text);
                score2 += bank2;
                lblP2Score.Text = score2.ToString();
                lblP2Bank.Text = "0";
                btnRoll.BackColor = pnlGamePlayer3.BackColor; btnSave.BackColor = pnlGamePlayer3.BackColor;
            }
            else if (btnRoll.BackColor == pnlGamePlayer3.BackColor)
            {
                int bank3 = Convert.ToInt32(lblP3Bank.Text);
                int score3 = Convert.ToInt32(lblP3Score.Text);
                score3 += bank3;
                lblP3Score.Text = score3.ToString();
                lblP3Bank.Text = "0";
                btnRoll.BackColor = pnlGamePlayer4.BackColor; btnSave.BackColor = pnlGamePlayer4.BackColor;
            }
            else if (btnRoll.BackColor == pnlGamePlayer4.BackColor)
            {
                int bank4 = Convert.ToInt32(lblP4Bank.Text);
                int score4 = Convert.ToInt32(lblP4Score.Text);
                score4 += bank4;
                lblP4Score.Text = score4.ToString();
                lblP4Bank.Text = "0";
                btnRoll.BackColor = pnlGamePlayer1.BackColor; btnSave.BackColor = pnlGamePlayer1.BackColor;
            }
        }

    }
}
