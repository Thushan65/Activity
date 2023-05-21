using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityC
{
    public partial class transactions : Form
    {
        public transactions()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-6JT31SC8;Initial Catalog=Bank;Integrated Security=True");

        private void checkBalance()
        {
            Con.Open();
            string Query = "select * from Account where Account_Number='"+ textBoxcb+"'";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt= new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                labelcb.Text= dr["Balance"].ToString();
            }
            Con.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxcb.Text == "")
            {
                MessageBox.Show("Enter your Account Number");
            }
            else
            {
                checkBalance();
            }
        }
    }
}
