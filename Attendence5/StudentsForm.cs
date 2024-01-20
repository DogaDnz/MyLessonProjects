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
	public partial class StudentsForm : Form
	{
		public int classID { get; set; }
		public string className{ get; set; }
		public StudentsForm()
		{
			InitializeComponent();
		}

		private void StudentsForm_Load(object sender, EventArgs e)
		{
            // TODO: Bu kod satırı 'dataSet1.StudentsTBL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentsTBLTableAdapter.Fill(this.dataSet1.StudentsTBL);

			metroLabelID.Text = classID.ToString();
			metroLabelClass.Text = className.ToString();

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			this.studentsTBLBindingSource.EndEdit();
			this.studentsTBLTableAdapter.Update(dataSet1.StudentsTBL);
		}
	}
}
