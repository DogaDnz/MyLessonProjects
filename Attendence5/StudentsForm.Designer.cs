namespace Attendence5
{
	partial class StudentsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentsTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new Attendence5.DataSet1();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabelClass = new MetroFramework.Controls.MetroLabel();
			this.metroLabelID = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.studentsTBLTableAdapter = new Attendence5.DataSet1TableAdapters.StudentsTBLTableAdapter();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsTBLBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.Status});
			this.dataGridView1.DataSource = this.studentsTBLBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 63);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(722, 303);
			this.dataGridView1.TabIndex = 0;
			// 
			// studentIDDataGridViewTextBoxColumn
			// 
			this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
			this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
			this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
			this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// studentNameDataGridViewTextBoxColumn
			// 
			this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
			this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
			this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
			// 
			// classIDDataGridViewTextBoxColumn
			// 
			this.classIDDataGridViewTextBoxColumn.DataPropertyName = "ClassID";
			this.classIDDataGridViewTextBoxColumn.HeaderText = "ClassID";
			this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
			// 
			// studentsTBLBindingSource
			// 
			this.studentsTBLBindingSource.DataMember = "StudentsTBL";
			this.studentsTBLBindingSource.DataSource = this.dataSet1;
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(32, 24);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(77, 19);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "ClassName:";
			// 
			// metroLabelClass
			// 
			this.metroLabelClass.AutoSize = true;
			this.metroLabelClass.Location = new System.Drawing.Point(119, 24);
			this.metroLabelClass.Name = "metroLabelClass";
			this.metroLabelClass.Size = new System.Drawing.Size(0, 0);
			this.metroLabelClass.TabIndex = 2;
			// 
			// metroLabelID
			// 
			this.metroLabelID.AutoSize = true;
			this.metroLabelID.Location = new System.Drawing.Point(458, 24);
			this.metroLabelID.Name = "metroLabelID";
			this.metroLabelID.Size = new System.Drawing.Size(0, 0);
			this.metroLabelID.TabIndex = 4;
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(390, 24);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(53, 19);
			this.metroLabel4.TabIndex = 3;
			this.metroLabel4.Text = "ClassID:";
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(602, 387);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(132, 32);
			this.metroButton1.TabIndex = 5;
			this.metroButton1.Text = "Save";
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// studentsTBLTableAdapter
			// 
			this.studentsTBLTableAdapter.ClearBeforeFill = true;
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Status";
			this.Status.Name = "Status";
			// 
			// StudentsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroButton1);
			this.Controls.Add(this.metroLabelID);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabelClass);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "StudentsForm";
			this.Text = "StudentsForm";
			this.Load += new System.EventHandler(this.StudentsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsTBLBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabelClass;
		private MetroFramework.Controls.MetroLabel metroLabelID;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroButton metroButton1;
		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource studentsTBLBindingSource;
		private DataSet1TableAdapters.StudentsTBLTableAdapter studentsTBLTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
	}
}