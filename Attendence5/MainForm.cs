using Attendence5.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Attendence5
{
	public partial class MainForm : MetroFramework.Forms.MetroForm
	{

		private DataTable dataTable2 = new DataTable();
		public int loggedIn { get; set; }
		public int UserID { get; set; }
	
		public MainForm()
		{
			InitializeComponent();
			loggedIn = 0;
		}

		SqlConnection con = new SqlConnection("Data Source=DESKTOP-0IHLFH6;Initial Catalog=AttandenceDB;Integrated Security=True");


		private void ShowData()
		{
			con.Open();
			SqlCommand com = new SqlCommand("Select *from Teachers", con);
			SqlDataReader red = com.ExecuteReader();

			while (red.Read())
			{
				ListViewItem ad = new ListViewItem();

				ad.Text = red["TeacherName"].ToString();
				ad.SubItems.Add(red["Classes"].ToString());
				ad.SubItems.Add(red["LessonsHour"].ToString());
				
				listView1.Items.Add(ad);
			}
			con.Close();
		}


		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'dataSet1.AttendencesRecords' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

			// TODO: Bu kod satırı 'dataSet1.Classes' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			dataGridView3.DataSource = dataTable2;
			;

			// Veritabanından verileri çekme

		}

		private void MainForm_Activated(object sender, EventArgs e)
		{

			if (loggedIn == 0)
			{
				Login loginform = new Login();
				loginform.ShowDialog();

				if (loginform.loginFlag == false)
				{
					Close();
				}

				else
				{
					UserID = loginform.UserID;
					statblUser.Text = UserID.ToString();
					loggedIn = 1;

					this.classesTableAdapter.Fill(this.dataSet1.Classes);
					classesBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";

				}
			}
		}

	
		private void AddClass_Click(object sender, EventArgs e)
		{
			AddClass addd = new AddClass();
			addd.UserID = this.UserID;
			addd.ShowDialog();
		}

		private void AddStudents_Click(object sender, EventArgs e)
		{
			StudentsForm newStu = new StudentsForm();
			newStu.className = metroComboBox1.Text;
			newStu.classID = (int)metroComboBox1.SelectedValue;
			newStu.ShowDialog();
		}

		private void GetValue_Click(object sender, EventArgs e)
		{
			
			AttendencesRecordsTableAdapter ada = new AttendencesRecordsTableAdapter();
			DataTable dt = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);

			if (dt.Rows.Count > 0)
			{
				DataTable data_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
				dataGridView1.DataSource = data_new;
			}

			else
			{
				StudentsTBLTableAdapter student_ada = new StudentsTBLTableAdapter();

				DataTable dt_students = student_ada.GetDataBy((int)metroComboBox1.SelectedValue);

				foreach (DataRow row in dt_students.Rows)
				{
					ada.InsertQuery((int)row[0], (int)metroComboBox1.SelectedValue, dateTimePicker1.Text, "", row[1].ToString(), metroComboBox1.Text);
				}
				DataTable data_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
				dataGridView1.DataSource = data_new;
			}

			
		
		}


		private void GetDataFromDatabase()
		{
			try
			{
				// Veritabanı bağlantısı ve sorgusu
				using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0IHLFH6;Initial Catalog=AttandenceDB;Integrated Security=True"))
				{
					connection.Open();

					// Tablo adını ve bağlantıyı kullanarak SqlDataAdapter oluşturuyoruz
					using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM StudentsTBL", connection))
					{
						// DataTable'ı temizle ve verileri çek
						dataTable2.Clear();
						adapter.Fill(dataTable2);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata: " + ex.Message);
			}
		}
		

		

		private void metroButton1_Click(object sender, EventArgs e)
		{
			GetDataFromDatabase();
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			ShowData();



		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand com = new SqlCommand("Insert Into Teachers (TeacherName,Classes,LessonsHour) Values('" + metroTextBox1.Text.ToString() + "' , '" + metroComboBox2.Text.ToString() + "' , '" + metroComboBox3.Text.ToString()  + "')", con);
			com.ExecuteNonQuery();
			con.Close();
			metroTextBox1.Clear();
		
			
		}

		
	}
	}

		
	

