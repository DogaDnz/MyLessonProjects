using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IceCreamProject
{
	public partial class Form1 : Form
	{


		public Form1()
		{
			InitializeComponent();


			listView2.Columns[0].Width = -2;
			textBox1.Enabled = false;
			textBox2.Enabled = false;

			groupBox2.Enabled = false;
			groupBox3.Enabled = false;
			groupBox6.Enabled = false;
			groupBox7.Enabled = false;



			button1.Enabled = false;
			button2.Enabled = false;



			this.KeyPreview = true;
			this.KeyDown += new KeyEventHandler(Form1_KeyDown);  //Formun keydown olayına abone olmak için



			radioButton1.CheckedChanged += RadioButton_CheckedChanged;
			radioButton2.CheckedChanged += RadioButton_CheckedChanged;
			radioButton3.CheckedChanged += RadioButton_CheckedChanged;




			pictureBox1.Image = ımageList1.Images[0];
			pictureBox2.Image = ımageList1.Images[1];
			pictureBox3.Image = ımageList1.Images[2];






		}




		private void button4_Click(object sender, EventArgs e)
		{

			textBox1.Clear();
			textBox2.Clear();
			textBox1.Enabled = true;

			radioButton1.Checked = false;
			radioButton2.Checked = false;
			radioButton3.Checked = false;
			radioButton4.Checked = false;
			radioButton5.Checked = false;
			radioButton6.Checked = false;

			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				checkedListBox1.SetItemChecked(i, false);
			}
			textBox4.Clear();
			textBox5.Clear();
			numericUpDown1.Value = 0;
			numericUpDown2.Value = 0;
			numericUpDown3.Value = 0;
			numericUpDown4.Value = 0;
			numericUpDown5.Value = 0;
		}

	



		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true; // Enter tuşunun varsayılan işlenmesini devre dışı bırak
				textBox2.Focus(); // İkinci TextBox'e odaklan
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

			groupBox2.Enabled = true;

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			textBox2.Enabled = true;

			string text = textBox1.Text;  // textbox'taki metni al

			if (!string.IsNullOrEmpty(text))
			{
				// metni boşluk karakterlerden ayır (ad ve soyad ayrımı için)
				string[] words = text.Split(' ');

				// Her kelimenin ilk harfini uppercase yap
				for (int i = 0; i < words.Length; i++)
				{
					if (!string.IsNullOrEmpty(words[i]) && char.IsLetter(words[i][0]))
					// char.IsLetter(words[i][0]) --> her kelimenin ilk harfini al
					{
						words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
					}
				}


				text = string.Join(" ", words);
				textBox1.Text = text;
				textBox1.SelectionStart = text.Length;
			}
		}


		double lemonprice = 0;
		double bananaprice = 0;
		double strawprice = 0;
		double chocoprice = 0;

		double lemonC = 0;
		double bananaC = 0;
		double strawC = 0;
		double chocoC = 0;



		private void RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			// Enable the third GroupBox when any of the three radio buttons is checked
			groupBox3.Enabled = radioButton1.Checked || radioButton2.Checked || radioButton3.Checked;
			groupBox6.Enabled = true;
			groupBox7.Enabled = true;
			button1.Enabled = true;
			button2.Enabled = true;


			if (radioButton1.Checked)
			{
				lemonprice = 0.25;
				bananaprice = 0.55;
				strawprice = 0.75;
				chocoprice = 0.80;

				lemonC = 115;
				bananaC = 175;
				strawC = 135;
				chocoC = 235;
			}
			else if (radioButton2.Checked)
			{
				lemonprice = 0.35;
				bananaprice = 0.65;
				strawprice = 0.85;
				chocoprice = 0.90;

				lemonC = 125;
				bananaC = 325;
				strawC = 225;
				chocoC = 340;



			}


			else if (radioButton3.Checked)
			{
				lemonprice = 0.40;
				bananaprice = 0.80;
				strawprice = 0.85;
				chocoprice = 1.00;


				lemonC = 175;
				bananaC = 365;
				strawC = 280;
				chocoC = 400;

			}
			CalculateTotalPrice();

		}

		private void CalculateTotalPrice()
		{
			double total = 0;
			total += lemonprice * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice Lemon") ? numericUpDown1.Value : 0);
			total += bananaprice * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice Banana") ? numericUpDown2.Value : 0);
			total += strawprice * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice Strow.") ? numericUpDown3.Value : 0);
			total += chocoprice * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice-Chock") ? numericUpDown4.Value : 0);




			textBox6.Text = total.ToString(); // Display total price in TextBox
		}



		private void CalculateUnitPrice()
		{
			double total = 0;
			total += lemonprice * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice Lemon"));
			total += bananaprice * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice Banana"));
			total += strawprice * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice Strow."));
			total += chocoprice * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice-Chock"));


			textBox4.Text = total.ToString(); // Display total price in TextBox
		}


		private void CalculateCalori()
		{
			double totalC = 0;
			totalC += lemonC * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice Lemon") ? numericUpDown1.Value : 0);
			totalC += bananaC * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice Banana") ? numericUpDown2.Value : 0);
			totalC += strawC * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice Strow.") ? numericUpDown3.Value : 0);
			totalC += chocoC * Convert.ToDouble(checkedListBox1.CheckedItems.Contains("Ice-Chock") ? numericUpDown4.Value : 0);




			textBox5.Text = totalC.ToString(); // Display total price in TextBox

			if (radioButton4.Checked)
			{
				totalC += 30;
				textBox5.Text = totalC.ToString();
			}

			else if (radioButton5.Checked)
			{
				totalC += 45;
				textBox5.Text = totalC.ToString();
			}


			else if (radioButton6.Checked)
			{
				totalC += 75;
				textBox5.Text = totalC.ToString();
			}



		}

		private void NumericUpDownValues()
		{
			decimal totalValue = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value;

			numericUpDown5.Text = totalValue.ToString();

		}





		private void button6_Click(object sender, EventArgs e)
		{
			CalculateTotalPrice();
			NumericUpDownValues();
			CalculateCalori();
			CalculateUnitPrice();
		}




		
	






		private void button1_Click(object sender, EventArgs e)
		{ // ListView temizle


			// Seçili öğeleri toplamak için bir liste oluştur
			List<string> selectedItems = new List<string>();

			// CheckListBox'taki işaretlenmiş öğeleri al
			foreach (int index in checkedListBox1.CheckedIndices)
			{
				// CheckListBox'taki işaretlenmiş öğenin adını al
				string itemName = checkedListBox1.Items[index].ToString();

				// Seçilen öğeyi listeye ekle
				selectedItems.Add(itemName);
			}

			// ListView'e ekle
			ListViewItem listViewItem = new ListViewItem();

			// Listede birden fazla seçili öğe varsa, bunları virgülle ayırarak birleştir
			listViewItem.Text = string.Join(" and ", selectedItems);



			if (radioButton1.Checked)
			{
				listViewItem.SubItems.Add("Diet");
			}


			else if (radioButton2.Checked)
			{
				listViewItem.SubItems.Add("Low-Fat");
			}


			else if (radioButton3.Checked)
			{
				listViewItem.SubItems.Add("Fat");
			}
			else
			{
				listViewItem.SubItems.Add("unspecified");
			}




			if (radioButton4.Checked)
			{
				listViewItem.SubItems.Add("Peanut");
			}


			else if (radioButton5.Checked)
			{
				listViewItem.SubItems.Add("HazelNut");
			}


			else if (radioButton6.Checked)
			{
				listViewItem.SubItems.Add("AntepNut");
			}
			else
			{
				listViewItem.SubItems.Add("unspecified");
			}

			string price = textBox4.Text;
			listViewItem.SubItems.Add(price);

			string calori = textBox5.Text;
			listViewItem.SubItems.Add(calori);


			string amont = numericUpDown5.Text;
			listViewItem.SubItems.Add(amont);


			string TotalPrice = textBox6.Text;
			listViewItem.SubItems.Add(TotalPrice);

			listView2.Items.Add(listViewItem);



			decimal totalColumn6 = 0;
			foreach (ListViewItem item in listView2.Items)
			{
				// Eğer sütun 6'da bir sayı varsa, toplamaya ekle
				decimal valueInColumn6;
				if (decimal.TryParse(item.SubItems[6].Text, out valueInColumn6))
				{
					totalColumn6 += valueInColumn6;
				}
			}

			// Toplam değeri textBox3'e yazdır
			textBox3.Text = totalColumn6.ToString();








		}

		private void button5_Click(object sender, EventArgs e)
		{
				// Check if there is a selected item in the ListView
				if (listView2.SelectedItems.Count > 0)
				{
					// Remove the selected item from the ListView
					listView2.Items.Remove(listView2.SelectedItems[0]);
				}
				else
				{
					MessageBox.Show("Please select an item to delete.");
				}
			}

		private void button3_Click(object sender, EventArgs e)
		{


			textBox1.Clear();
			textBox2.Clear();
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			radioButton3.Checked = false;
			radioButton4.Checked = false;
			radioButton5.Checked = false;
			radioButton6.Checked = false;

			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				checkedListBox1.SetItemChecked(i, false);
			} 


			textBox4.Clear();
			textBox5.Clear();
			numericUpDown1.Value = 0;
			numericUpDown2.Value = 0;
			numericUpDown3.Value = 0;
			numericUpDown4.Value = 0;
			numericUpDown5.Value = 0;
			textBox1.Enabled = false;
			textBox2.Enabled = false;

			groupBox2.Enabled = false;
			groupBox3.Enabled = false;
			groupBox6.Enabled = false;
			groupBox7.Enabled = false;



			button1.Enabled = false;
			button2.Enabled = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			radioButton1.Checked = false;
			radioButton2.Checked = false;
			radioButton3.Checked = false;
			radioButton4.Checked = false;
			radioButton5.Checked = false;
			radioButton6.Checked = false;

			for (int i = 0; i < checkedListBox1.Items.Count; i++)
			{
				checkedListBox1.SetItemChecked(i, false);
			}
			textBox4.Clear();
			textBox5.Clear();
			numericUpDown1.Value = 0;
			numericUpDown2.Value = 0;
			numericUpDown3.Value = 0;
			numericUpDown4.Value = 0;
			numericUpDown5.Value = 0;
		}

		private void listView2_SelectedIndexChanged(object sender, EventArgs e)
		{
			decimal unitPrice = 0;

			// Iterate through each item in the ListView
			foreach (ListViewItem item in listView2.Items)
			{
				// Parse the price from the 4th column (assuming it's a decimal)
				decimal price;
				if (decimal.TryParse(item.SubItems[3].Text, out price))
				{
					// Add the price to the total
					unitPrice += price;
				}
				else
				{
					MessageBox.Show("Invalid price format in one or more items.");
					return; // Exit the loop if there's an issue with the format
				}
			}

			// Display the total price in the TextBox
			textBox3.Text = unitPrice.ToString();





		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			CalculateTotalPrice();
			NumericUpDownValues();
			CalculateCalori();
			CalculateUnitPrice();
		}

		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{

			CalculateTotalPrice();
			NumericUpDownValues();
			CalculateCalori();
			CalculateUnitPrice();
		}

		private void numericUpDown3_ValueChanged(object sender, EventArgs e)
		{

			CalculateTotalPrice();
			NumericUpDownValues();
			CalculateCalori();
			CalculateUnitPrice();
		}

		private void numericUpDown4_ValueChanged(object sender, EventArgs e)
		{

			CalculateTotalPrice();
			NumericUpDownValues();
			CalculateCalori();
			CalculateUnitPrice();
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{

			CalculateTotalPrice();
			NumericUpDownValues();
			CalculateCalori();
			CalculateUnitPrice();
		}

		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{

			CalculateTotalPrice();
			NumericUpDownValues();
			CalculateCalori();
			CalculateUnitPrice();
		}

		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{

			CalculateTotalPrice();
			NumericUpDownValues();
			CalculateCalori();
			CalculateUnitPrice();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			decimal totalColumn6 = 0;
			foreach (ListViewItem item in listView2.Items)
			{
				// Eğer sütun 6'da bir sayı varsa, toplamaya ekle
				decimal valueInColumn6;
				if (decimal.TryParse(item.SubItems[6].Text, out valueInColumn6))
				{
					totalColumn6 += valueInColumn6;
				}
			}

			// Toplam değeri textBox3'e yazdır
			textBox3.Text = totalColumn6.ToString();
		}

		private void groupBox4_Enter(object sender, EventArgs e)
		{

		}
	}


}
