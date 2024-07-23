namespace EmployeeMangement
{
	partial class Employee
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			panel1 = new Panel();
			label1 = new Label();
			contextMenuStrip1 = new ContextMenuStrip(components);
			label3 = new Label();
			EmpName = new TextBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			EmpSal = new TextBox();
			AddEmp = new Button();
			EditEmp = new Button();
			label7 = new Label();
			label8 = new Label();
			panel2 = new Panel();
			panel3 = new Panel();
			panel4 = new Panel();
			EmpGen = new ComboBox();
			EmpDept = new ComboBox();
			EmpDob = new DateTimePicker();
			EmpJoin = new DateTimePicker();
			pictureBox1 = new PictureBox();
			LogoutLabel = new Label();
			SalaryLable = new Label();
			DeptLabel = new Label();
			label11 = new Label();
			pictureBox4 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox6 = new PictureBox();
			pictureBox3 = new PictureBox();
			label12 = new Label();
			EmpDelete = new Button();
			EmpGrid = new DataGridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)EmpGrid).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Teal;
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(2326, 130);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(934, 53);
			label1.Name = "label1";
			label1.Size = new Size(492, 37);
			label1.TabIndex = 2;
			label1.Text = "Employee Management System";
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(32, 32);
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Teal;
			label3.Location = new Point(22, 361);
			label3.Name = "label3";
			label3.Size = new Size(252, 37);
			label3.TabIndex = 7;
			label3.Text = "Employee Name";
			// 
			// EmpName
			// 
			EmpName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			EmpName.Location = new Point(22, 415);
			EmpName.Name = "EmpName";
			EmpName.Size = new Size(500, 44);
			EmpName.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Teal;
			label4.Location = new Point(22, 475);
			label4.Name = "label4";
			label4.Size = new Size(272, 37);
			label4.TabIndex = 9;
			label4.Text = "Employee Gender";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.Teal;
			label5.Location = new Point(22, 589);
			label5.Name = "label5";
			label5.Size = new Size(333, 37);
			label5.TabIndex = 11;
			label5.Text = "Employee Department";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.Teal;
			label6.Location = new Point(20, 906);
			label6.Name = "label6";
			label6.Size = new Size(335, 37);
			label6.TabIndex = 13;
			label6.Text = "Employee Daily Salary";
			// 
			// EmpSal
			// 
			EmpSal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			EmpSal.Location = new Point(20, 946);
			EmpSal.Name = "EmpSal";
			EmpSal.Size = new Size(500, 44);
			EmpSal.TabIndex = 12;
			// 
			// AddEmp
			// 
			AddEmp.BackColor = Color.Teal;
			AddEmp.Cursor = Cursors.Hand;
			AddEmp.FlatStyle = FlatStyle.Flat;
			AddEmp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			AddEmp.ForeColor = Color.White;
			AddEmp.Location = new Point(22, 1006);
			AddEmp.Name = "AddEmp";
			AddEmp.Size = new Size(125, 56);
			AddEmp.TabIndex = 14;
			AddEmp.Text = "Add";
			AddEmp.UseVisualStyleBackColor = false;
			AddEmp.Click += AddEmp_Click;
			// 
			// EditEmp
			// 
			EditEmp.BackColor = Color.PaleTurquoise;
			EditEmp.Cursor = Cursors.Hand;
			EditEmp.FlatStyle = FlatStyle.Flat;
			EditEmp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			EditEmp.ForeColor = Color.Black;
			EditEmp.Location = new Point(190, 1006);
			EditEmp.Name = "EditEmp";
			EditEmp.Size = new Size(134, 56);
			EditEmp.TabIndex = 15;
			EditEmp.Text = "Update";
			EditEmp.UseVisualStyleBackColor = false;
			EditEmp.Click += EditEmp_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.Teal;
			label7.Location = new Point(20, 795);
			label7.Name = "label7";
			label7.Size = new Size(152, 37);
			label7.TabIndex = 17;
			label7.Text = "Join Date";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.Teal;
			label8.Location = new Point(20, 686);
			label8.Name = "label8";
			label8.Size = new Size(202, 37);
			label8.TabIndex = 19;
			label8.Text = "Date Of Birth";
			// 
			// panel2
			// 
			panel2.BackColor = Color.Teal;
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 1068);
			panel2.Name = "panel2";
			panel2.Size = new Size(2326, 10);
			panel2.TabIndex = 20;
			// 
			// panel3
			// 
			panel3.BackColor = Color.Teal;
			panel3.Dock = DockStyle.Right;
			panel3.Location = new Point(2313, 130);
			panel3.Name = "panel3";
			panel3.Size = new Size(13, 938);
			panel3.TabIndex = 21;
			// 
			// panel4
			// 
			panel4.BackColor = Color.Teal;
			panel4.Dock = DockStyle.Left;
			panel4.Location = new Point(0, 130);
			panel4.Name = "panel4";
			panel4.Size = new Size(11, 938);
			panel4.TabIndex = 22;
			// 
			// EmpGen
			// 
			EmpGen.FormattingEnabled = true;
			EmpGen.Items.AddRange(new object[] { "Female", "Male" });
			EmpGen.Location = new Point(22, 527);
			EmpGen.Name = "EmpGen";
			EmpGen.Size = new Size(500, 45);
			EmpGen.TabIndex = 23;
			// 
			// EmpDept
			// 
			EmpDept.FormattingEnabled = true;
			EmpDept.Location = new Point(20, 638);
			EmpDept.Name = "EmpDept";
			EmpDept.Size = new Size(500, 45);
			EmpDept.TabIndex = 24;
			// 
			// EmpDob
			// 
			EmpDob.Location = new Point(20, 737);
			EmpDob.Name = "EmpDob";
			EmpDob.Size = new Size(500, 44);
			EmpDob.TabIndex = 25;
			// 
			// EmpJoin
			// 
			EmpJoin.Location = new Point(20, 844);
			EmpJoin.Name = "EmpJoin";
			EmpJoin.Size = new Size(500, 44);
			EmpJoin.TabIndex = 26;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(22, 151);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(203, 162);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 30;
			pictureBox1.TabStop = false;
			// 
			// LogoutLabel
			// 
			LogoutLabel.AutoSize = true;
			LogoutLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			LogoutLabel.ForeColor = Color.Teal;
			LogoutLabel.Location = new Point(1999, 163);
			LogoutLabel.Name = "LogoutLabel";
			LogoutLabel.Size = new Size(116, 37);
			LogoutLabel.TabIndex = 71;
			LogoutLabel.Text = "Logout";
			LogoutLabel.Click += LogoutLabel_Click;
			// 
			// SalaryLable
			// 
			SalaryLable.AutoSize = true;
			SalaryLable.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SalaryLable.ForeColor = Color.Teal;
			SalaryLable.Location = new Point(1696, 163);
			SalaryLable.Name = "SalaryLable";
			SalaryLable.Size = new Size(107, 37);
			SalaryLable.TabIndex = 70;
			SalaryLable.Text = "Salary";
			SalaryLable.Click += SalaryLable_Click;
			// 
			// DeptLabel
			// 
			DeptLabel.AutoSize = true;
			DeptLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			DeptLabel.ForeColor = Color.Teal;
			DeptLabel.Location = new Point(1297, 163);
			DeptLabel.Name = "DeptLabel";
			DeptLabel.Size = new Size(200, 37);
			DeptLabel.TabIndex = 69;
			DeptLabel.Text = "Departments";
			DeptLabel.Click += DeptLabel_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label11.ForeColor = Color.Teal;
			label11.Location = new Point(934, 163);
			label11.Name = "label11";
			label11.Size = new Size(157, 37);
			label11.TabIndex = 68;
			label11.Text = "Employee";
			label11.Click += label11_Click;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(1205, 148);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(102, 52);
			pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 67;
			pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(1611, 148);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(102, 52);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 66;
			pictureBox2.TabStop = false;
			// 
			// pictureBox6
			// 
			pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.Location = new Point(1927, 148);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(102, 52);
			pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox6.TabIndex = 65;
			pictureBox6.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(850, 148);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(102, 52);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 64;
			pictureBox3.TabStop = false;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label12.ForeColor = Color.Teal;
			label12.Location = new Point(1308, 251);
			label12.Name = "label12";
			label12.Size = new Size(313, 37);
			label12.TabIndex = 63;
			label12.Text = "Manage Employees";
			// 
			// EmpDelete
			// 
			EmpDelete.BackColor = Color.Salmon;
			EmpDelete.Cursor = Cursors.Hand;
			EmpDelete.FlatStyle = FlatStyle.Flat;
			EmpDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			EmpDelete.ForeColor = Color.Black;
			EmpDelete.Location = new Point(367, 1006);
			EmpDelete.Name = "EmpDelete";
			EmpDelete.Size = new Size(153, 56);
			EmpDelete.TabIndex = 72;
			EmpDelete.Text = "Delete";
			EmpDelete.UseVisualStyleBackColor = false;
			EmpDelete.Click += EmpDelete_Click;
			// 
			// EmpGrid
			// 
			EmpGrid.AllowUserToAddRows = false;
			EmpGrid.BackgroundColor = Color.White;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.Teal;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
			dataGridViewCellStyle4.SelectionForeColor = Color.Black;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			EmpGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			EmpGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			EmpGrid.Cursor = Cursors.Hand;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Window;
			dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle5.ForeColor = Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
			dataGridViewCellStyle5.SelectionForeColor = Color.Black;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			EmpGrid.DefaultCellStyle = dataGridViewCellStyle5;
			EmpGrid.GridColor = Color.Black;
			EmpGrid.Location = new Point(588, 322);
			EmpGrid.MultiSelect = false;
			EmpGrid.Name = "EmpGrid";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = Color.Teal;
			dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle6.ForeColor = Color.White;
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			EmpGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			EmpGrid.RowHeadersWidth = 82;
			EmpGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			EmpGrid.Size = new Size(1692, 712);
			EmpGrid.TabIndex = 73;
			EmpGrid.CellContentClick += EmpGrid_CellContentClick;
			// 
			// Employee
			// 
			AutoScaleDimensions = new SizeF(19F, 37F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(2326, 1078);
			Controls.Add(EmpGrid);
			Controls.Add(EmpDelete);
			Controls.Add(LogoutLabel);
			Controls.Add(SalaryLable);
			Controls.Add(DeptLabel);
			Controls.Add(label11);
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox6);
			Controls.Add(pictureBox3);
			Controls.Add(label12);
			Controls.Add(pictureBox1);
			Controls.Add(EmpJoin);
			Controls.Add(EmpDob);
			Controls.Add(EmpDept);
			Controls.Add(EmpGen);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(EditEmp);
			Controls.Add(AddEmp);
			Controls.Add(label6);
			Controls.Add(EmpSal);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(EmpName);
			Controls.Add(panel1);
			Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 3, 4, 3);
			Name = "Employee";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Employee";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)EmpGrid).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private ContextMenuStrip contextMenuStrip1;
		private Label label1;
		private Label label3;
		private TextBox EmpName;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox EmpSal;
		private Button AddEmp;
		private Button EditEmp;
		private Label label7;
		private Label label8;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
		private ComboBox EmpGen;
		private ComboBox EmpDept;
		private DateTimePicker EmpDob;
		private DateTimePicker EmpJoin;
		private PictureBox pictureBox1;
		private Label LogoutLabel;
		private Label SalaryLable;
		private Label DeptLabel;
		private Label label11;
		private PictureBox pictureBox4;
		private PictureBox pictureBox2;
		private PictureBox pictureBox6;
		private PictureBox pictureBox3;
		private Label label12;
		private Button EmpDelete;
		private DataGridView EmpList;
		private DataGridView EmpGrid;
	}
}