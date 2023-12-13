using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13aralık_lab
{
	public partial class Form1 : Form
	{
		private Student[] students; 

		public Form1()
		{
			InitializeComponent();
			students = new Student[100]; 
		}

		public class Student
		{
			public int IdNumber { get; set; }
			public string Name { get; set; }
			public string Surname { get; set; }
			public int OopGrade { get; set; }
			public int CalculusGrade { get; set; }
			public int DataStructureGrade { get; set; }
			public int StudentAvg { get; private set; }

			public Student(int idNumber, string name, string surname, int oopGrade, int calculusGrade, int dataStructureGrade)
			{
				IdNumber = idNumber;
				Name = name;
				Surname = surname;
				OopGrade = oopGrade;
				CalculusGrade = calculusGrade;
				DataStructureGrade = dataStructureGrade;

				CalculateAvg();
			}

			private void CalculateAvg()
			{
				StudentAvg = (OopGrade + CalculusGrade + DataStructureGrade) / 3;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();

			foreach (var student in students)
			{
				if (student != null)
				{
					richTextBox1.AppendText($"Id: {student.IdNumber}, Name: {student.Name}, Surname: {student.Surname}, Avg: {student.StudentAvg}\n");
				}
				else
				{
					
					break;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Student newStudent = new Student(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));

			for (int i = 0; i < students.Length; i++)
			{
				if (students[i] == null)
				{
					students[i] = newStudent;
					break;
				}
			}

			
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
		}

	}
}

