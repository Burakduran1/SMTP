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
    public partial class ResetPassword : Form
    {
        string username = sendCode.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetPassVer.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=BURAK\\SQLEXPRESS;Initial Catalog=forgetPassword;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[forgotPassword]\r\n SET \r\n      ,[password] = '"+txtResetPass.Text+"'WHERE username='"+username+"'",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("yenileme basarili");

            }
            else
            {
                MessageBox.Show("the new password  do not  match so enter  same password");            }
        }
    }
}
