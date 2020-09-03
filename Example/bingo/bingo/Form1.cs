using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bingo
{
    public partial class Form1 : Form
    {
        public int turns = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (turns == 0)
            {
                button.Text = "O";
                turns = 1;
            } else
            {
                button.Text = "X";
                turns = 0;
            }

            button.Enabled = false;
            checkWInnder();
        }

        private void checkWInnder()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                MessageBox.Show(button1.Text + "가 이겼습니다.");

            } else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                MessageBox.Show(button1.Text + "가 이겼습니다.");

            } else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                MessageBox.Show(button1.Text + "가 이겼습니다.");

            } else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                MessageBox.Show(button3.Text + "가 이겼습니다.");

            } else if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                MessageBox.Show(button3.Text + "가 이겼습니다.");

            } else if (button9.Text != "" && button9.Text == button8.Text && button8.Text == button7.Text)
            {
                MessageBox.Show(button9.Text + "가 이겼습니다.");

            } else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                MessageBox.Show(button2.Text + "가 이겼습니다.");

            } else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                MessageBox.Show(button4.Text + "가 이겼습니다.");

            } else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("비겼습니다.");
            }
        }
    }
}
