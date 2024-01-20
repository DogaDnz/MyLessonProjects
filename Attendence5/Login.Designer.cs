namespace Attendence5
{
	partial class Login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LoginBtn = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroTextBoxUsername = new MetroFramework.Controls.MetroTextBox();
			this.metroTextBoxPass = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// LoginBtn
			// 
			this.LoginBtn.Location = new System.Drawing.Point(191, 352);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(114, 46);
			this.LoginBtn.TabIndex = 0;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new System.Drawing.Point(97, 157);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(93, 25);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Username:";
			// 
			// metroTextBoxUsername
			// 
			this.metroTextBoxUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.metroTextBoxUsername.Location = new System.Drawing.Point(97, 194);
			this.metroTextBoxUsername.Name = "metroTextBoxUsername";
			this.metroTextBoxUsername.Size = new System.Drawing.Size(171, 23);
			this.metroTextBoxUsername.TabIndex = 2;
			// 
			// metroTextBoxPass
			// 
			this.metroTextBoxPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.metroTextBoxPass.Location = new System.Drawing.Point(97, 281);
			this.metroTextBoxPass.Name = "metroTextBoxPass";
			this.metroTextBoxPass.Size = new System.Drawing.Size(171, 23);
			this.metroTextBoxPass.TabIndex = 4;
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel2.Location = new System.Drawing.Point(97, 244);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(86, 25);
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "Password:";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 465);
			this.Controls.Add(this.metroTextBoxPass);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroTextBoxUsername);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.LoginBtn);
			this.Name = "Login";
			this.Text = "Login";
			
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton LoginBtn;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox metroTextBoxUsername;
		private MetroFramework.Controls.MetroTextBox metroTextBoxPass;
		private MetroFramework.Controls.MetroLabel metroLabel2;
	}
}