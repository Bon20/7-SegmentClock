using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_SegmentClock
{
    public partial class Form1 : Form
    {
        public DateTime t;
        public string hr, min, sec, hr01, hr02, min01, min02, sec01, sec02;
        public Color timeColor = Color.Red, backColor = Color.Black;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button[] buttonDot = new Button[4] { S1, S2, S3, S4 };
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    timeColor = Color.Red;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 1:
                    timeColor = Color.Blue;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 2:
                    timeColor = Color.White;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 3:
                    timeColor = Color.Green;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 4:
                    timeColor = Color.Pink;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 5:
                    timeColor = Color.Yellow;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
                case 6:
                    timeColor = Color.Purple;
                    backColor = Color.Black;
                    this.BackColor = backColor;
                    break;
            }
            foreach (Button but in buttonDot)
            {
                but.BackColor = timeColor;
            }
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Tick_Clock();
        }

        public Button[] button1, button2, button3, button4, button5, button6;


        private void Form1_Load(object sender, EventArgs e)
        {
            button1 = new Button[7] { aa1, aa2, aa3, aa4, aa5, aa6, aa7 };
            button2 = new Button[7] { bb1, bb2, bb3, bb4, bb5, bb6, bb7 };
            button3 = new Button[7] { cc1, cc2, cc3, cc4, cc5, cc6, cc7 };
            button4 = new Button[7] { dd1, dd2, dd3, dd4, dd5, dd6, dd7 };
            button5 = new Button[7] { ee1, ee2, ee3, ee4, ee5, ee6, ee7 };
            button6 = new Button[7] { ff1, ff2, ff3, ff4, ff5, ff6, ff7 };
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Clock_Update (Button[] buttons, string number)
        {
            switch (number)
            {
                case "0":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = backColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "1":
                    buttons[0].BackColor = backColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = backColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = backColor;
                    break;
                case "2":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = backColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "3":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "4":
                    buttons[0].BackColor = backColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = backColor;
                    break;
                case "5":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = backColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "6":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = backColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "7":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = backColor;
                    buttons[3].BackColor = backColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = backColor;
                    break;
                case "8":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = timeColor;
                    buttons[6].BackColor = timeColor;
                    break;
                case "9":
                    buttons[0].BackColor = timeColor;
                    buttons[1].BackColor = timeColor;
                    buttons[2].BackColor = timeColor;
                    buttons[3].BackColor = timeColor;
                    buttons[4].BackColor = timeColor;
                    buttons[5].BackColor = backColor;
                    buttons[6].BackColor = timeColor;
                    break;
            }
        }

        public void Tick_Clock()
        {
            t = DateTime.Now;
            hr = $"{t:hh}";
            min = $"{t:mm}";
            sec = $"{t:ss}";
            hr01 = hr.Substring(0, 1);
            hr02 = hr.Substring(1, 1);
            min01 = min.Substring(0, 1);
            min02 = min.Substring(1, 1);
            sec01 = sec.Substring(0, 1);
            sec02 = sec.Substring(1, 1);
            Clock_Update(button1, hr01);
            Clock_Update(button2, hr02);
            Clock_Update(button3, min01);
            Clock_Update(button4, min02);
            Clock_Update(button5, sec01);
            Clock_Update(button6, sec02);
        }

    }
}
