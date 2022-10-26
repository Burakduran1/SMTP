using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace şifre
{
    public partial class sendCode : Form
    {
        string randomCode;
        public static string to;
        public sendCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message= new MailMessage();
        to = (txtEmail.Text).ToString();
            from = "burakduran12491@gmail.com";
            pass = "owarikfkpnwdrxji";
            messageBody = "Sifre sifirlama kodunuz: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "sifre sifirlama kodu:";
            SmtpClient smtp=new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Kod gondermesi basarili");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerCode.Text).ToString()) 
            {
                to = txtEmail.Text;
                ResetPassword rp = new ResetPassword();
                this.Hide();
                rp.Show();
            }
            else 
            {
                MessageBox.Show("yanlis kod.");
            }
            
               
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
