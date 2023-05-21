using System.Data;
using System.Data.SqlClient;
namespace ActivityC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-6JT31SC8;Initial Catalog=Bank;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            register rg=new register();
            rg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("Missing Inputs");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda=new SqlDataAdapter("select count(*) from Account where UserName='"+textBox1.Text+"' and Password='"+textBox2.Text+"'", Con);
                DataTable dataTable= new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString() == "1" )
                {
                    transactions ts= new transactions();
                    ts.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                Con.Close();
            }
        }
    }
}