/*
 * Created by SharpDevelop.
 * User: Diak
 * Date: 2019. 01. 22.
 * Time: 10:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace scam
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox username;
		private System.Windows.Forms.RichTextBox password;
		private System.Windows.Forms.Button Login;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.username = new System.Windows.Forms.RichTextBox();
			this.password = new System.Windows.Forms.RichTextBox();
			this.Login = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(113, 196);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(177, 23);
			this.username.TabIndex = 0;
			this.username.Text = "";
			this.username.TextChanged += new System.EventHandler(this.RichTextBox1TextChanged);
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(454, 196);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(177, 23);
			this.password.TabIndex = 1;
			this.password.Text = "";
			// 
			// Login
			// 
			this.Login.Cursor = System.Windows.Forms.Cursors.Cross;
			this.Login.Location = new System.Drawing.Point(343, 347);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(75, 23);
			this.Login.TabIndex = 2;
			this.Login.Text = "Hack";
			this.Login.UseVisualStyleBackColor = true;
			this.Login.Click += new System.EventHandler(this.Button1Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(257, 290);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(248, 23);
			this.progressBar1.TabIndex = 3;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 199);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 30);
			this.label1.TabIndex = 4;
			this.label1.Text = "Felhasználónév";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.Login);
			this.Controls.Add(this.password);
			this.Controls.Add(this.username);
			this.Name = "MainForm";
			this.Text = "scam";
			this.ResumeLayout(false);

		}
	}
}
