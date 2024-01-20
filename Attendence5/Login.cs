using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendence5
{
	public partial class Login : Form
	{
		public bool loginFlag { get; set; }
		public int UserID { get; set; }
		public Login()
		{
			InitializeComponent();
			loginFlag = false;
		}

		private void LoginBtn_Click(object sender, EventArgs e)
		{
			DataSet1TableAdapters.UsersTableAdapter userAda = new DataSet1TableAdapters.UsersTableAdapter();
			DataTable dt = userAda.GetDataByUserAndPass(metroTextBoxUsername.Text, metroTextBoxPass.Text);


			if (dt.Rows.Count > 0)
			{
				MessageBox.Show("Successfully loginned");
				UserID = int.Parse(dt.Rows[0]["UserID"].ToString());
				loginFlag = true;
			}

			else
			{
				MessageBox.Show("Access Denied");
				loginFlag = false;
			}
			Close();
		}

	
	}
}
