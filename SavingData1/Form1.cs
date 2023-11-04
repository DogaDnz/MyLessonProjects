using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SavingData1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection("Data Source=DESKTOP-0IHLFH6;Initial Catalog=Project2;Integrated Security=True");

		private void ShowData() { 
		con.Open();
			SqlCommand com = new SqlCommand("Select *from Table1",con);
			SqlDataReader red = com.ExecuteReader();

			while (red.Read())
			{
				ListViewItem ad = new ListViewItem();

				ad.Text = red["Names"].ToString();
				ad.SubItems.Add(red["Company"].ToString());
				ad.SubItems.Add(red["PhoneNumber"].ToString());
				ad.SubItems.Add(red["Gender"].ToString());

				listView1.Items.Add(ad);
			}
			con.Close();
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			ShowData();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand com = new SqlCommand("Insert Into Table1 (Names,Company,PhoneNumber,Gender) Values('" + textBox1.Text.ToString() + "' , '" + textBox2.Text.ToString() + "' , '" +textBox3.Text.ToString()+ "','" + comboBox1.Text.ToString() + "')", con);
			com.ExecuteNonQuery();
			con.Close();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			comboBox1.Items.Clear();


		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
