using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_Tak_Reo
{
    public partial class Form1 : Form
    {
        bool trun=true;
        int coun=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Towle ");
        }


        //exit
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //butto work
        private void btn_click(object sender, EventArgs e)
        {
            Button b =(Button)sender;
            if (trun)
                b.Text = "X";
            else
                b.Text = "O";

            trun = !trun;
            b.Enabled = false;
            checkWiner();
            coun++;
          
        }



        //CheckWinner horizebtal
        private void checkWiner()
        {
            bool is_winner = false;
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

            //diogram

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                is_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                is_winner = true;



            if (is_winner)
            {
                string win = "";
                if (trun)
                    win = "O";
                else
                    win = "X";
                MessageBox.Show(win + " Winner");
            }
            else
            {
                if (coun ==9)
                {
                    MessageBox.Show("Draw");
                }
            }
        }


        private void disBut()
        {
            try
            {
                foreach (Control a in Controls)
                {
                    Button b =(Button)a;
                    b.Enabled = false;
                }
            }
            catch{ }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trun = true;
            coun = 0;
            try
            {
                foreach (Control a in Controls)
                {
                    Button b = (Button)a;
                    b.Enabled = true;
                    b.Text = "";               }
            }
            catch { }
        }
    }
}
