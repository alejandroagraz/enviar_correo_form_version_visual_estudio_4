using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Net;


namespace EnvioCorreos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //==============>> button1_Click <<============

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //SmtpClient server = new SmtpClient("smtp.gmail.com", 587);
                //server.Credentials = new System.Net.NetworkCredential("alejandroagraz@gmail.com", "439665425");

                string servidor = Convert.ToString(textBox1.Text.ToString().Trim());
                int puerto = Convert.ToInt32(textBox2.Text.ToString().Trim());
                string usuario = Convert.ToString(textBox3.Text.ToString().Trim());
                string credencial = Convert.ToString(textBox4.Text.ToString().Trim());
                string destinatario = Convert.ToString(textBox5.Text.ToString().Trim());
                Boolean Ssl = Convert.ToBoolean(textBox7.Text.ToString().Trim());

                MailMessage mnsj = new MailMessage();
                mnsj.To.Add(new MailAddress(destinatario));
                mnsj.CC.Add(new MailAddress("joseagraz29@gmail.com;aylo1309@gmail.com"));
                mnsj.From = new MailAddress(usuario+"@diebold-oltp.com.ve", "Mensaje de prueba");
                mnsj.Subject = "Mensaje de prueba.";
                mnsj.Body = "Este es el cuerpo del mensaje de prueba desde el boton enviar.";

                SmtpClient server = new SmtpClient();
                server.Host = servidor;
                server.Port = puerto;
                server.UseDefaultCredentials = false;
                server.DeliveryMethod = SmtpDeliveryMethod.Network;
                server.Credentials = new System.Net.NetworkCredential(usuario, credencial);
                server.EnableSsl = Ssl;
                server.Send(mnsj);
                MessageBox.Show("200");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

