using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacTieVer2
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        string player = "X";
        int draw = 0;
        int count = 60;

        Bitmap x = TicTacTieVipProMax.Properties.Resources.X;
        Bitmap o = TicTacTieVipProMax.Properties.Resources.O;

        private void button_Click(object sender, EventArgs e)
        {
            int t = 60 - Convert.ToInt16(lbTime.Text);
            Button btn = (Button)sender;
            btn.Enabled = false;

            if (player == "X")
            {
                btn.BackgroundImage = x;
                btn.BackColor = Color.Blue;
                player = "O";
                pbTurn.BackgroundImage = o;
            }
            else
            {
                btn.BackgroundImage = o;
                btn.BackColor = Color.Red;
                player = "X";
                pbTurn.BackgroundImage = x;
            }

            if ((btn1.BackColor == Color.Blue && btn2.BackColor == Color.Blue && btn3.BackColor == Color.Blue) ||
                (btn4.BackColor == Color.Blue && btn5.BackColor == Color.Blue && btn6.BackColor == Color.Blue) ||
                (btn7.BackColor == Color.Blue && btn8.BackColor == Color.Blue && btn9.BackColor == Color.Blue) ||
                (btn1.BackColor == Color.Blue && btn4.BackColor == Color.Blue && btn7.BackColor == Color.Blue) ||
                (btn2.BackColor == Color.Blue && btn5.BackColor == Color.Blue && btn8.BackColor == Color.Blue) ||
                (btn3.BackColor == Color.Blue && btn6.BackColor == Color.Blue && btn9.BackColor == Color.Blue) ||
                (btn1.BackColor == Color.Blue && btn5.BackColor == Color.Blue && btn9.BackColor == Color.Blue) ||
                (btn3.BackColor == Color.Blue && btn5.BackColor == Color.Blue && btn7.BackColor == Color.Blue))
            {
                counter.Stop();
                btnPause.Enabled = false;
                btnPlay.Enabled = false;
                tlpBroadChess.Enabled = false;
                MessageBox.Show("Player X Win.\n\nTime : " + t + "s", "Congratulation !!!");
            }
            else if ((btn1.BackColor == Color.Red && btn2.BackColor == Color.Red && btn3.BackColor == Color.Red) ||
                (btn4.BackColor == Color.Red && btn5.BackColor == Color.Red && btn6.BackColor == Color.Red) ||
                (btn7.BackColor == Color.Red && btn8.BackColor == Color.Red && btn9.BackColor == Color.Red) ||
                (btn1.BackColor == Color.Red && btn4.BackColor == Color.Red && btn7.BackColor == Color.Red) ||
                (btn2.BackColor == Color.Red && btn5.BackColor == Color.Red && btn8.BackColor == Color.Red) ||
                (btn3.BackColor == Color.Red && btn6.BackColor == Color.Red && btn9.BackColor == Color.Red) ||
                (btn1.BackColor == Color.Red && btn5.BackColor == Color.Red && btn9.BackColor == Color.Red) ||
                (btn3.BackColor == Color.Red && btn5.BackColor == Color.Red && btn7.BackColor == Color.Red))
            {
                counter.Stop();
                btnPause.Enabled = false;
                btnPlay.Enabled = false;
                tlpBroadChess.Enabled = false;
                MessageBox.Show("Player O Win.\n\nTime : " + t + "s", "Congratulation !!!");
            }
            else if (draw == 8)
            {
                counter.Stop();
                btnPause.Enabled = false;
                btnPlay.Enabled = false;
                tlpBroadChess.Enabled = false;
                MessageBox.Show("Draw !!!.\n\nTime : " + t + "s", "No one win !!!");
            }
            draw++;

            //Cho co ti mau me =)))
            if (player == "X")
            {
                pic1.BackgroundImage = o;
                pic3.BackgroundImage = o;
                pic5.BackgroundImage = o;
                pic7.BackgroundImage = o;
                pic9.BackgroundImage = o;
                pic11.BackgroundImage = o;

                pic2.BackgroundImage = x;
                pic4.BackgroundImage = x;
                pic6.BackgroundImage = x;
                pic8.BackgroundImage = x;
                pic10.BackgroundImage = x;
                pic12.BackgroundImage = x;
            }
            else
            {
                pic1.BackgroundImage = x;
                pic3.BackgroundImage = x;
                pic5.BackgroundImage = x;
                pic7.BackgroundImage = x;
                pic9.BackgroundImage = x;
                pic11.BackgroundImage = x;

                pic2.BackgroundImage = o;
                pic4.BackgroundImage = o;
                pic6.BackgroundImage = o;
                pic8.BackgroundImage = o;
                pic10.BackgroundImage = o;
                pic12.BackgroundImage = o;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            player = "X";
            draw = 0;
            count = 60;
            lbTime.Text = "60";
            pbTurn.BackgroundImage = x;
            counter.Stop();
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btn1.Enabled = true; btn1.BackgroundImage = null; btn1.BackColor = Color.White;
            btn2.Enabled = true; btn2.BackgroundImage = null; btn2.BackColor = Color.White;
            btn3.Enabled = true; btn3.BackgroundImage = null; btn3.BackColor = Color.White;
            btn4.Enabled = true; btn4.BackgroundImage = null; btn4.BackColor = Color.White;
            btn5.Enabled = true; btn5.BackgroundImage = null; btn5.BackColor = Color.White;
            btn6.Enabled = true; btn6.BackgroundImage = null; btn6.BackColor = Color.White;
            btn7.Enabled = true; btn7.BackgroundImage = null; btn7.BackColor = Color.White;
            btn8.Enabled = true; btn8.BackgroundImage = null; btn8.BackColor = Color.White;
            btn9.Enabled = true; btn9.BackgroundImage = null; btn9.BackColor = Color.White;
            tlpBroadChess.Enabled = false;
        }

        private void counter_Tick(object sender, EventArgs e)
        {
            count--;
            lbTime.Text = count.ToString();
            if (count == 0)
            {
                counter.Stop();
                MessageBox.Show("Time out !!!");
                btnPause.Enabled = false;
                btnPlay.Enabled = false;
                tlpBroadChess.Enabled = false;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = true;
            counter.Start();
            tlpBroadChess.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            counter.Stop();
            tlpBroadChess.Enabled = false;
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
            tlpBroadChess.Enabled = false; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

