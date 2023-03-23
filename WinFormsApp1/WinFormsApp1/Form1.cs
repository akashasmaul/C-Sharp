using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
         //   BackColor = Color.Cyan;
            button1.BackColor = Color.Green;
            button1.Text = "Yes";
            button2.Text = "No";
            button3.BackColor = Color.DarkCyan;
            button3.Text = "I'm DONE playing this game.";
            button4.BackColor = Color.Yellow;
            button4.Text = "Submit";
         //   groupBox1.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.OrangeRed;
            MessageBox.Show("I knew it!");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chill,bro");
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = checkBox1.Checked;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkRed;
            DialogResult res = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("How do you define dumb?");
                // this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Look at your confidence, haha");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
