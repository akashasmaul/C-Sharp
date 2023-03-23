using System;
using System.Windows.Forms;

namespace _27_March
{
    public partial class Form1 : Form
    {
        public double num1;
        public int count;
        public double ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num1 = num1 / 100;
            textBox1.Text = num1.ToString();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            count = 0;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            // textBox1.Clear();            
            textBox1.Focus();
            count = 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - double.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + double.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                 case 3:
                    ans = num1 * double.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / double.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                
                case 7:
                    if (num1 > double.Parse(textBox1.Text))
                    {
                        ans = num1 - double.Parse(textBox1.Text);
                        textBox1.Text = ans.ToString();
                        break;
                    }
                    else if (num1 < double.Parse(textBox1.Text))
                    {
                        ans = num1 + double.Parse(textBox1.Text);
                        textBox1.Text = ans.ToString();
                        break;
                    }
                    break;

                default:
                    break;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            ans = num1 * num1;
            textBox1.Focus();
            textBox1.Text = ans.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            ans = 1 / num1;            
            textBox1.Text = ans.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            ans = Math.Sqrt(num1);
            textBox1.Text = ans.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Under Construction";
            f2.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Under Construction";
            f2.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Under Construction";
            f2.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Under Construction";
            f2.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Under Construction";
            f2.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Under Construction";
            f2.ShowDialog();
        }   
        private void button31_Click(object sender, EventArgs e)
        {            
            f2.ShowDialog();            
        }
        threeDot f2 = new threeDot();
    }
}