namespace Attendence5
{
	partial class MainForm
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.GetValue = new MetroFramework.Controls.MetroButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.User = new System.Windows.Forms.ToolStripStatusLabel();
			this.statblUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.AddStudents = new MetroFramework.Controls.MetroButton();
			this.AddClass = new MetroFramework.Controls.MetroButton();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new Attendence5.DataSet1();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateAtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.attendencesRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.TeacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
			this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.classesTableAdapter = new Attendence5.DataSet1TableAdapters.ClassesTableAdapter();
			this.attendencesRecordsTableAdapter = new Attendence5.DataSet1TableAdapters.AttendencesRecordsTableAdapter();
			this.metroTabControl1.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.attendencesRecordsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
			this.metroTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.metroTabPage1);
			this.metroTabControl1.Controls.Add(this.metroTabPage2);
			this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 0;
			this.metroTabControl1.Size = new System.Drawing.Size(754, 470);
			this.metroTabControl1.TabIndex = 0;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.Controls.Add(this.GetValue);
			this.metroTabPage1.Controls.Add(this.statusStrip1);
			this.metroTabPage1.Controls.Add(this.AddStudents);
			this.metroTabPage1.Controls.Add(this.AddClass);
			this.metroTabPage1.Controls.Add(this.metroLabel2);
			this.metroTabPage1.Controls.Add(this.dateTimePicker1);
			this.metroTabPage1.Controls.Add(this.metroComboBox1);
			this.metroTabPage1.Controls.Add(this.metroLabel1);
			this.metroTabPage1.Controls.Add(this.dataGridView1);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(746, 431);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "Attendence";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			// 
			// GetValue
			// 
			this.GetValue.Location = new System.Drawing.Point(383, 100);
			this.GetValue.Name = "GetValue";
			this.GetValue.Size = new System.Drawing.Size(87, 30);
			this.GetValue.TabIndex = 12;
			this.GetValue.Text = "Get Values";
			this.GetValue.Click += new System.EventHandler(this.GetValue_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.User,
            this.statblUser});
			this.statusStrip1.Location = new System.Drawing.Point(0, 409);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(746, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(30, 17);
			this.toolStripStatusLabel1.Text = "User";
			// 
			// User
			// 
			this.User.Name = "User";
			this.User.Size = new System.Drawing.Size(0, 17);
			// 
			// statblUser
			// 
			this.statblUser.Name = "statblUser";
			this.statblUser.Size = new System.Drawing.Size(0, 17);
			// 
			// AddStudents
			// 
			this.AddStudents.Location = new System.Drawing.Point(496, 302);
			this.AddStudents.Name = "AddStudents";
			this.AddStudents.Size = new System.Drawing.Size(87, 30);
			this.AddStudents.TabIndex = 10;
			this.AddStudents.Text = "Add Students";
			this.AddStudents.Click += new System.EventHandler(this.AddStudents_Click);
			// 
			// AddClass
			// 
			this.AddClass.Location = new System.Drawing.Point(496, 262);
			this.AddClass.Name = "AddClass";
			this.AddClass.Size = new System.Drawing.Size(87, 30);
			this.AddClass.TabIndex = 9;
			this.AddClass.Text = "Add Class";
			this.AddClass.Click += new System.EventHandler(this.AddClass_Click);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(383, 187);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(85, 19);
			this.metroLabel2.TabIndex = 6;
			this.metroLabel2.Text = "Select a Date";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(383, 222);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 5;
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.DataSource = this.classesBindingSource;
			this.metroComboBox1.DisplayMember = "ClassName";
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Location = new System.Drawing.Point(383, 60);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(178, 29);
			this.metroComboBox1.TabIndex = 4;
			this.metroComboBox1.ValueMember = "ClassID";
			// 
			// classesBindingSource
			// 
			this.classesBindingSource.DataMember = "Classes";
			this.classesBindingSource.DataSource = this.dataSet1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(383, 25);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(87, 19);
			this.metroLabel1.TabIndex = 3;
			this.metroLabel1.Text = "Select a Class";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameDataGridViewTextBoxColumn,
            this.DateAtt,
            this.StudentID});
			this.dataGridView1.DataSource = this.attendencesRecordsBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(312, 377);
			this.dataGridView1.TabIndex = 2;

			// 
			// studentNameDataGridViewTextBoxColumn
			// 
			this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
			this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
			this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
			// 
			// DateAtt
			// 
			this.DateAtt.DataPropertyName = "DateAtt";
			this.DateAtt.HeaderText = "DateAtt";
			this.DateAtt.Name = "DateAtt";
			// 
			// StudentID
			// 
			this.StudentID.DataPropertyName = "StudentID";
			this.StudentID.HeaderText = "StudentID";
			this.StudentID.Name = "StudentID";
			// 
			// attendencesRecordsBindingSource
			// 
			this.attendencesRecordsBindingSource.DataMember = "AttendencesRecords";
			this.attendencesRecordsBindingSource.DataSource = this.dataSet1BindingSource;
			// 
			// dataSet1BindingSource
			// 
			this.dataSet1BindingSource.DataSource = this.dataSet1;
			this.dataSet1BindingSource.Position = 0;
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.Controls.Add(this.listView1);
			this.metroTabPage2.Controls.Add(this.metroButton3);
			this.metroTabPage2.Controls.Add(this.metroButton2);
			this.metroTabPage2.Controls.Add(this.metroButton1);
			this.metroTabPage2.Controls.Add(this.dataGridView3);
			this.metroTabPage2.Controls.Add(this.metroLabel5);
			this.metroTabPage2.Controls.Add(this.metroLabel3);
			this.metroTabPage2.Controls.Add(this.metroComboBox3);
			this.metroTabPage2.Controls.Add(this.metroComboBox2);
			this.metroTabPage2.Controls.Add(this.label3);
			this.metroTabPage2.Controls.Add(this.label2);
			this.metroTabPage2.Controls.Add(this.metroTextBox1);
			this.metroTabPage2.Controls.Add(this.label1);
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(746, 431);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "Teachers";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TeacherName,
            this.Class,
            this.Hours});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(418, 77);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(266, 143);
			this.listView1.TabIndex = 18;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// TeacherName
			// 
			this.TeacherName.Text = "TeacherName";
			this.TeacherName.Width = 118;
			// 
			// Class
			// 
			this.Class.Text = "Class";
			// 
			// Hours
			// 
			this.Hours.Text = "Hours";
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(302, 161);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(33, 25);
			this.metroButton3.TabIndex = 17;
			this.metroButton3.Text = "OK";
			this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(473, 20);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(171, 35);
			this.metroButton2.TabIndex = 16;
			this.metroButton2.Text = "View Teachers";
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(505, 344);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(150, 34);
			this.metroButton1.TabIndex = 15;
			this.metroButton1.Text = "View Records";
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(3, 278);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(463, 150);
			this.dataGridView3.TabIndex = 14;
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel5.Location = new System.Drawing.Point(40, 239);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(233, 25);
			this.metroLabel5.TabIndex = 13;
			this.metroLabel5.Text = "Students Attendence Records";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.metroLabel3.Location = new System.Drawing.Point(3, 20);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(144, 25);
			this.metroLabel3.TabIndex = 10;
			this.metroLabel3.Text = "Add New Teacher";
			// 
			// metroComboBox3
			// 
			this.metroComboBox3.FormattingEnabled = true;
			this.metroComboBox3.ItemHeight = 23;
			this.metroComboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.metroComboBox3.Location = new System.Drawing.Point(155, 156);
			this.metroComboBox3.Name = "metroComboBox3";
			this.metroComboBox3.Size = new System.Drawing.Size(128, 29);
			this.metroComboBox3.TabIndex = 9;
			// 
			// metroComboBox2
			// 
			this.metroComboBox2.DataSource = this.classesBindingSource;
			this.metroComboBox2.DisplayMember = "ClassName";
			this.metroComboBox2.FormattingEnabled = true;
			this.metroComboBox2.ItemHeight = 23;
			this.metroComboBox2.Location = new System.Drawing.Point(155, 103);
			this.metroComboBox2.Name = "metroComboBox2";
			this.metroComboBox2.Size = new System.Drawing.Size(128, 29);
			this.metroComboBox2.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(1, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Lesson Hours:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(1, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Class";
			// 
			// metroTextBox1
			// 
			this.metroTextBox1.Location = new System.Drawing.Point(155, 56);
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.Size = new System.Drawing.Size(128, 23);
			this.metroTextBox1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(1, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "TeacherName";
			// 
			// classesTableAdapter
			// 
			this.classesTableAdapter.ClearBeforeFill = true;
			// 
			// attendencesRecordsTableAdapter
			// 
			this.attendencesRecordsTableAdapter.ClearBeforeFill = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 556);
			this.Controls.Add(this.metroTabControl1);
			this.Name = "MainForm";
			this.Text = "Attendence System";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.metroTabControl1.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			this.metroTabPage1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.attendencesRecordsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
			this.metroTabPage2.ResumeLayout(false);
			this.metroTabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private MetroFramework.Controls.MetroButton AddStudents;
		private MetroFramework.Controls.MetroButton AddClass;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel User;
		private System.Windows.Forms.ToolStripStatusLabel statblUser;
		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource dataSet1BindingSource;
		private System.Windows.Forms.BindingSource classesBindingSource;
		private DataSet1TableAdapters.ClassesTableAdapter classesTableAdapter;
		private MetroFramework.Controls.MetroButton GetValue;
		private System.Windows.Forms.BindingSource attendencesRecordsBindingSource;
		private DataSet1TableAdapters.AttendencesRecordsTableAdapter attendencesRecordsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateAtt;
		private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
		private MetroFramework.Controls.MetroTextBox metroTextBox1;
		private System.Windows.Forms.Label label1;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroComboBox metroComboBox3;
		private MetroFramework.Controls.MetroComboBox metroComboBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.DataGridView dataGridView3;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroButton metroButton3;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader TeacherName;
		private System.Windows.Forms.ColumnHeader Class;
		private System.Windows.Forms.ColumnHeader Hours;
	}
}

