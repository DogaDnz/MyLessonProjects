namespace Attendence5
{
	partial class AddClass
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
			this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			this.AcceptBtn = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// metroTextBox1
			// 
			this.metroTextBox1.Location = new System.Drawing.Point(77, 88);
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.Size = new System.Drawing.Size(217, 23);
			this.metroTextBox1.TabIndex = 0;
			// 
			// AcceptBtn
			// 
			this.AcceptBtn.Location = new System.Drawing.Point(197, 133);
			this.AcceptBtn.Name = "AcceptBtn";
			this.AcceptBtn.Size = new System.Drawing.Size(97, 28);
			this.AcceptBtn.TabIndex = 1;
			this.AcceptBtn.Text = "Accept";
			this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(77, 46);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(123, 19);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "Enter a Class Name";
			// 
			// AddClass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 230);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.AcceptBtn);
			this.Controls.Add(this.metroTextBox1);
			this.Name = "AddClass";
			this.Text = "AddClass";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox metroTextBox1;
		private MetroFramework.Controls.MetroButton AcceptBtn;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}