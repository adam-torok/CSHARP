using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonTorles.Text = Char.ConvertFromUtf32(8592);
            MaximizeBox = false;
            KeyPreview = true;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void buttonOsszead_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Replace("\n", string.Empty);
                textBox1.Text += Environment.NewLine + " + ";
            }
        }

        private void buttonKivon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Replace("\n", string.Empty);
                textBox1.Text += Environment.NewLine + " - ";
            }
        }

        private void buttonSzorzas_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Replace("\n", string.Empty);
                textBox1.Text += Environment.NewLine + " * ";
            }
        }

        private void buttonOsztas_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Replace("\n", string.Empty);
                textBox1.Text += Environment.NewLine + " / ";
            }

        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void buttonegyenlo_Click(object sender, EventArgs e)
        {
            var eredmenyText = textBox1.Text;
            string[] textTomb = textBox1.Text.Split(' ');
            float eredmeny = float.Parse(textTomb[0]);
            for (int i = 1; i < textTomb.Length; i++)
            {
                float kovi;

                switch (textTomb[i])
                {
                    case "+":
                        float.TryParse(textTomb[i + 1],out kovi);
                        eredmeny += kovi;
                        break;

                    case "-":
                        float.TryParse(textTomb[i + 1], out kovi);
                        eredmeny -= kovi;
                        break;
                    case "*":
                        float.TryParse(textTomb[i + 1], out kovi);
                        eredmeny = eredmeny * kovi;
                        break;
                    case "/":
                        float.TryParse(textTomb[i + 1], out kovi);
                        eredmeny = eredmeny / kovi;
                        break;
                    default:
                        break;
                }
                textBox1.Text = Convert.ToString(eredmeny);
            }
        }
    }
}
