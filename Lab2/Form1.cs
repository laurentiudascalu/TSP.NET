using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string calcul;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void b7_click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");

        }

        private void b8_click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void b9_click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void b4_click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void b5_click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void b6_click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void b1_click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void b2_click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void b3_click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void b0_click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void impartire_click(object sender, EventArgs e)
        {
            textBox1.AppendText("/");
        }

        private void punct_click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void inmultit_click(object sender, EventArgs e)
        {
            textBox1.AppendText("*");
        }

        private void minus_click(object sender, EventArgs e)
        {
            textBox1.AppendText("-");
        }

        private void plus_click(object sender, EventArgs e)
        {
            textBox1.AppendText("+");
        }
        public float doCalcule(string calcul)
        {
            float rez = 0;
            if (calcul.IndexOf("--") != -1)
            {
                string[] stringSeparators = new string[] { "--" };
                string[] exploded = calcul.Split(stringSeparators, StringSplitOptions.None);
                rez = doCalcule(exploded[0]);
                for (int i = 1; i < exploded.Length; i++)
                {
                    rez += doCalcule(exploded[i]);
                }
                return rez;
            }
            else if (calcul.IndexOf("+-") != -1)
            {
                string[] stringSeparators = new string[] { "+-" };
                string[] exploded = calcul.Split(stringSeparators, StringSplitOptions.None);
                rez = doCalcule(exploded[0]);
                for (int i = 1; i < exploded.Length; i++)
                {
                    rez -= doCalcule(exploded[i]);
                }
                return rez;
            }
            else if (calcul.IndexOf("*-") != -1)
            {
                string[] stringSeparators = new string[] { "*-" };
                string[] exploded = calcul.Split(stringSeparators, StringSplitOptions.None);
                rez = doCalcule(exploded[0]);
                for (int i = 1; i < exploded.Length; i++)
                {
                    rez *= -1 * doCalcule(exploded[i]);
                }
                return rez;
            }
            else if (calcul.IndexOf("/-") != -1)
            {
                string[] stringSeparators = new string[] { "/-" };
                string[] exploded = calcul.Split(stringSeparators, StringSplitOptions.None);
                rez = doCalcule(exploded[0]);
                for (int i = 1; i < exploded.Length; i++)
                {
                    rez /= -1 * doCalcule(exploded[i]);
                }
                return rez;
            }
            else if (calcul.IndexOf("-") != -1)
            {
                string[] exploded = calcul.Split('-');
                rez = doCalcule(exploded[0]);
                for (int i=1; i<exploded.Length; i++)
                {
                    rez -= doCalcule(exploded[i]);
                }
                return rez;
            }
            else if (calcul.IndexOf("+") != -1)
            {
                string[] exploded = calcul.Split('+');
                rez = doCalcule(exploded[0]);
                for (int i = 1; i < exploded.Length; i++)
                {
                    rez += doCalcule(exploded[i]);
                }
                return rez;
            }
            else if (calcul.IndexOf("/") != -1)
            {
                string[] exploded = calcul.Split('/');
                rez = doCalcule(exploded[0]);
                for (int i = 1; i < exploded.Length; i++)
                {
                    rez /= doCalcule(exploded[i]);
                }
                return rez;
            }
            else if (calcul.IndexOf("*") != -1)
            {
                string[] exploded = calcul.Split('*');
                rez = doCalcule(exploded[0]);
                for (int i = 1; i < exploded.Length; i++)
                {
                    rez *= doCalcule(exploded[i]);
                }
                return rez;
            }
            else if (calcul == "")
            {
                return rez;
            }
            else
            {
                return float.Parse(calcul);
            }
        }
        private void egal_click(object sender, EventArgs e)
        {
            float rez = 0;
            calcul = textBox1.Text;
            rez = doCalcule(calcul);
            textBox1.AppendText("=" + rez.ToString());
        }

        private void del_click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }
    }
}
