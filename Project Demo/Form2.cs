using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crrud
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-RLEUU0O;Initial Catalog=USER_TABLEE;User ID=sa;Password=123456;Pooling=False");


            string query = "Select * from member where ID='" + textBox3.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (dtbl.Rows.Count == 1)
                {
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.Show();
                }

                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
            
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Please Enter your User Name !");
            }
            else
            {
                errorProvider1.SetError(textBox3, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please Enter your Password !");
            }
            else
            {
                errorProvider2.SetError(textBox2, null);
            }
        }
    }
}
