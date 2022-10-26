using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data; 
using System.Data.SqlClient;
namespace şifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            sendCode sc=new sendCode();
            this.Hide();
            sc.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=BURAK\\SQLEXPRESS;Initial Catalog=forgetPassword;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from forgotPassword where username='" + textUser.Text + "' and password='" + textPass.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("giris basarili.");

            }else
            {
                MessageBox.Show("Hatali giris.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
