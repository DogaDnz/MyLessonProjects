using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labsheet4
{
	public partial class Form1 : Form
	{
		private string[] mothers = new string[1];
		private string[][] children = new string[1][];
		public Form1()
		{
			InitializeComponent();
		}

		
		private void AddChildDataToList(List<string> childData, string childName, string childAge)
		{
			if (!string.IsNullOrWhiteSpace(childName))
			{
				childData.Add(childName);
				childData.Add(childAge);
			}
		}

	

		private void button1_Click_1(object sender, EventArgs e)
		{
			mothers[0] = mothername1.Text;

			List<string> childData = new List<string>();


			AddChildDataToList(childData, textBox2.Text, age2.Text);
			AddChildDataToList(childData, textBox3.Text, age3.Text);
			AddChildDataToList(childData, textBox4.Text, age4.Text);
			AddChildDataToList(childData, textBox5.Text, age5.Text);
			AddChildDataToList(childData, textBox5.Text, age6.Text);

			children[0] = childData.ToArray();

			mothername1.Text = "";
			textBox1.Text = "";
			age2.Text = "";
			textBox2.Text = "";
			age3.Text = "";
			textBox3.Text = "";
			age4.Text = "";
			textBox4.Text = "";
			age5.Text = "";
			textBox5.Text = "";
			age6.Text = "";
		}

		private void search_Click_1(object sender, EventArgs e)
		{

			string searchName = mothername2.Text;


			int index = Array.IndexOf(mothers, searchName);

			if (index != -1)
			{

				string[] childData = children[index];


				listBox1.Items.Clear();

				for (int i = 0; i < childData.Length; i += 2)
				{
					string childName = childData[i];
					string childAge = childData[i + 1];
					listBox1.Items.Add($"Child: {childName}, Age: {childAge}");
				}
			}
			else
			{
				listBox1.Items.Clear();
				MessageBox.Show("Mother's name not found.");
			}

			mothername2.Text = "";
		}
	}
}