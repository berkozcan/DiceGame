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
    public partial class GameSettings : Form
    {
        private int _goal;
        public GameSettings()
        {
            InitializeComponent();
        }
        

        private void btnColor1_Click(object sender, EventArgs e)
        {
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor1.BackColor = clrDialog.Color;
            }

        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor2.BackColor = clrDialog.Color;
            }
        }

        private void btnColor3_Click(object sender, EventArgs e)
        {
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor3.BackColor = clrDialog.Color;
            }
        }

        private void btnColor4_Click(object sender, EventArgs e)
        {
            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor4.BackColor = clrDialog.Color;
            }
        }

        private void PlayerNumberControl()
        {

            if (Convert.ToInt32(txtBoxPlayerNumber.Text) == 2)
            {
                grpBoxNames.Enabled = true;
                grpPlayer1.Enabled = true;
                grpPlayer2.Enabled = true;
                grpPlayer3.Enabled = false;
                grpPlayer4.Enabled = false;
            }
            else if (Convert.ToInt32(txtBoxPlayerNumber.Text) == 3)
            {
                grpBoxNames.Enabled = true;
                grpPlayer1.Enabled = true;
                grpPlayer2.Enabled = true;
                grpPlayer3.Enabled = true;
                grpPlayer4.Enabled = false;
            }
            else if (Convert.ToInt32(txtBoxPlayerNumber.Text) == 4)
            {
                grpBoxNames.Enabled = true;
                grpPlayer1.Enabled = true;
                grpPlayer2.Enabled = true;
                grpPlayer3.Enabled = true;
                grpPlayer4.Enabled = true;
            }


        }

        private void GameSettings_Load(object sender, EventArgs e)
        {
            grpBoxNames.Enabled = false;
            btnStart.Enabled = false;

        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _goal = Convert.ToInt32(txtBoxGoal.Text);
            btnStart.Enabled = true;
            if (Convert.ToInt32(txtBoxPlayerNumber.Text) > 4 || Convert.ToInt32(txtBoxPlayerNumber.Text) < 2)
            {
                MessageBox.Show("You can play the game with 2-4 players", "Error | WoundedWarriors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Convert.ToInt32(txtBoxGoal.Text) < 10 || Convert.ToInt32(txtBoxGoal.Text) > 1000)
            {
                MessageBox.Show("You can enter a goal between 10-1000", "Error | WoundedWarriors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { PlayerNumberControl(); 
            }


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GreedyChicken greedyChicken = new GreedyChicken(_goal);
            greedyChicken.ShowDialog();
        }


    }
}
