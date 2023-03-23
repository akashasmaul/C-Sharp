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

namespace Lab_Week_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Insert button //
        {
            SqlConnection con = new SqlConnection("Data Source=;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=123qwe");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Member values (@ID, @Name, @Age)", con);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void button2_Click(object sender, EventArgs e) // Update button //
        {
            SqlConnection con = new SqlConnection("Data Source=;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=123qwe");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Member set Name = @Name, Age = @Age where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button3_Click(object sender, EventArgs e) // Delete button //
        {
            SqlConnection con = new SqlConnection("Data Source=;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=123qwe");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Member where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", (textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void button4_Click(object sender, EventArgs e) // Search button //
        {
            SqlConnection con = new SqlConnection("Data Source=;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=123qwe");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Member where ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", (textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=123qwe");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Member", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
          //  da.Fill(dt);
            dataGridView1.DataSource = dt;
            

            
        }
    }
}
