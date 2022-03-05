using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Only_Self
{
    public partial class Form1 : Form
    {
        bool turn = false;
        int cout=0;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_click(object sender, EventArgs e)
        {
           Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";
           
            btn.Enabled = false;
            turn = !turn;
            cout++;
            CheckWiner();
        }

        private void CheckWiner()
        {
            bool is_winner = false;

            //Horizental
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                is_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                is_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                is_winner = true;


            //vertical

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                is_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                is_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                is_winner = true;

            //IS dhaaf

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                is_winner = true;
            else if ((A3.Text == C2.Text) && (C2.Text == C1.Text) && (!C1.Enabled))
                is_winner = true;



            if (is_winner)
            {
                string win = "";
                if (turn)
                    win = "O";
                else
                    win = "X";
                MessageBox.Show(win + " Winner");

            }
            else
            {
                if (cout == 9)
                    MessageBox.Show("Draw!");

            }
              
        }

        private void dis_but()
        {
            try
            {
                foreach (Control a in Controls)
                {
                    Button b = (Button)a;
                    b.Enabled = false;
                }
            }
            catch { }
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cout=0;
            turn=false;
            try
            {
                foreach (Control a in Controls)
                {
                    Button b = (Button)a;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Game Design By Towle ! From Youtube lol");
        }
    }
}
