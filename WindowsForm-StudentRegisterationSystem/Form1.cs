using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{

			ListViewItem newItem;
			if (comboBox1.Text == "Male")
			{
				newItem = new ListViewItem(textBox1.Text + " {M}");
			}
			else if (comboBox1.Text == "Female")
			{
				newItem = new ListViewItem(textBox1.Text + " {F}");
			}
			else
			{
				newItem = new ListViewItem(textBox1.Text);
			}

			newItem.SubItems.Add(textBox2.Text);
			newItem.SubItems.Add(textBox3.Text);
			if (checkBox1.Checked)
			{
				newItem.SubItems.Add(checkBox1.Text);
			}
			else
			{
				newItem.SubItems.Add("NotRegistered");
			}
			listView1.Items.Add(newItem);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count > 0)
			{
				listView1.Items.Remove(listView1.SelectedItems[0]);
			}
		}

		
		}
	}

