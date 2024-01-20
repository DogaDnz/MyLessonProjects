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
	public partial class AddClass : Form
	{
		public int UserID { get; set; }
		public AddClass()
		{
			InitializeComponent();
		}

		private void AcceptBtn_Click(object sender, EventArgs e)
		{
			DataSet1TableAdapters.ClassesTableAdapter ada = new DataSet1TableAdapters.ClassesTableAdapter();
			ada.AddClass(metroTextBox1.Text, UserID);
			Close();
		}
	}
}
