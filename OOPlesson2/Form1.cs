using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPlesson2
{
	public partial class Form1 : Form
	{
		public Form1()
		{

			InitializeComponent();
		}
		int num1, num2, num3, result;

		private void button1_Click(object sender, EventArgs e)
		{
			if (num1 > num2 && num1 > num3) 
			{

				result = num1;
				result = Convert.ToInt32(result);
				textBox3.Text = num1.ToString();
		    }
			else if(num2 > num1 && num2 > num3)
			{
				result = num2;
				result = Convert.ToInt32(result);
				textBox3.Text = num2.ToString();

			}
			else  {
				result = num3;
				result = Convert.ToInt32(result);
				textBox3.Text = num3.ToString();

			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (num1 < num2 && num1 < num3)
			{

				result = num1;
				result = Convert.ToInt32(result);
				textBox3.Text = num1.ToString();
			}
			else if (num2 < num1 && num2 < num3)
			{
				result = num2;
				result = Convert.ToInt32(result);
				textBox3.Text = num2.ToString();

			}
			else
			{
				result = num3;
				result = Convert.ToInt32(result);
				textBox3.Text = num3.ToString();

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			result = (num1 + num2 + num3) / 3;
			result = Convert.ToInt32(result);
			textBox3.Text = result.ToString();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			num3 = Convert.ToInt32(textBox2.Text);
			textBox2.Text = num3.ToString();
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			num2 = Convert.ToInt32(textBox4.Text);
			textBox4.Text = num2.ToString();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			num1 = Convert.ToInt32(textBox1.Text);
			textBox1.Text = num1.ToString();

		}
	}
}
