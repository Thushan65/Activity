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
using System.Linq.Expressions;

namespace ActivityC
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            DisplayAccount();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-6JT31SC8;Initial Catalog=Bank;Integrated Security=True");

        private void DisplayAccount()
        {
            Con.Open();
            string Query = "Select * from Account";
            SqlDataAdapter sda= new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder= new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            if(textBoxname.Text=="" || textBoxnic.Text=="" || textBoxdob.Text=="" || textBoxusername.Text=="" || textBoxpassword.Text=="" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                { 
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Account(Name,NIC,DOB,UserName,Password,Balance,Type)values(@AN,@ANIC,@ADOB,@AUN,@APW,@AB,@AT)", Con);
                    cmd.Parameters.AddWithValue("@AN",textBoxname.Text);
                    cmd.Parameters.AddWithValue("@ANIC",textBoxnic.Text);
                    cmd.Parameters.AddWithValue("@ADOB",textBoxdob.Text);
                    cmd.Parameters.AddWithValue("@AUN",textBoxusername.Text);
                    cmd.Parameters.AddWithValue("@APW",textBoxpassword.Text);
                    cmd.Parameters.AddWithValue("@AB",0);
                    cmd.Parameters.AddWithValue("@AT",comboBox1.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created!");
                    Con.Close();
                    DisplayAccount();
                }
                catch (Exception Ex) 
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            textBoxname.Text = "";
            textBoxnic.Text = "";
            textBoxdob.Text = "";
            textBoxusername.Text = "";
            textBoxpassword.Text = "";
            comboBox1.SelectedIndex= -1;
        }
    }
}
