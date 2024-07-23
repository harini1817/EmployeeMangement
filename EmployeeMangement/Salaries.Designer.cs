namespace EmployeeMangement
{
	partial class Salaries
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			pictureBox1 = new PictureBox();
			EmpNameList = new ComboBox();
			panel4 = new Panel();
			panel3 = new Panel();
			panel2 = new Panel();
			label7 = new Label();
			SalAmount = new TextBox();
			label4 = new Label();
			label3 = new Label();
			contextMenuStrip1 = new ContextMenuStrip(components);
			label1 = new Label();
			AddSal = new Button();
			panel1 = new Panel();
			TotalDays = new TextBox();
			SalLogoutl = new Label();
			label6 = new Label();
			SalDepl = new Label();
			SalEmp = new Label();
			pictureBox4 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox6 = new PictureBox();
			pictureBox3 = new PictureBox();
			label10 = new Label();
			SalList = new DataGridView();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)SalList).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(22, 151);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(203, 162);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 51;
			pictureBox1.TabStop = false;
			// 
			// EmpNameList
			// 
			EmpNameList.FormattingEnabled = true;
			EmpNameList.Location = new Point(22, 414);
			EmpNameList.Name = "EmpNameList";
			EmpNameList.Size = new Size(500, 45);
			EmpNameList.TabIndex = 46;
			EmpNameList.SelectedIndexChanged += EmpNameList_SelectedIndexChanged;
			// 
			// panel4
			// 
			panel4.BackColor = Color.Teal;
			panel4.Dock = DockStyle.Left;
			panel4.Location = new Point(0, 130);
			panel4.Name = "panel4";
			panel4.Size = new Size(11, 939);
			panel4.TabIndex = 45;
			// 
			// panel3
			// 
			panel3.BackColor = Color.Teal;
			panel3.Dock = DockStyle.Right;
			panel3.Location = new Point(2313, 130);
			panel3.Name = "panel3";
			panel3.Size = new Size(13, 939);
			panel3.TabIndex = 44;
			// 
			// panel2
			// 
			panel2.BackColor = Color.Teal;
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 1069);
			panel2.Name = "panel2";
			panel2.Size = new Size(2326, 10);
			panel2.TabIndex = 43;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.ForeColor = Color.Teal;
			label7.Location = new Point(22, 630);
			label7.Name = "label7";
			label7.Size = new Size(228, 37);
			label7.TabIndex = 41;
			label7.Text = "Salary Amount";
			// 
			// SalAmount
			// 
			SalAmount.BackColor = Color.White;
			SalAmount.BorderStyle = BorderStyle.None;
			SalAmount.Enabled = false;
			SalAmount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SalAmount.Location = new Point(22, 707);
			SalAmount.Name = "SalAmount";
			SalAmount.Size = new Size(500, 37);
			SalAmount.TabIndex = 37;
			SalAmount.TextAlign = HorizontalAlignment.Right;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.Teal;
			label4.Location = new Point(22, 475);
			label4.Name = "label4";
			label4.Size = new Size(226, 37);
			label4.TabIndex = 35;
			label4.Text = "Days Attended";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Teal;
			label3.Location = new Point(22, 361);
			label3.Name = "label3";
			label3.Size = new Size(166, 37);
			label3.TabIndex = 34;
			label3.Text = "Employee ";
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(32, 32);
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
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
			// AddSal
			// 
			AddSal.BackColor = Color.Teal;
			AddSal.Cursor = Cursors.Hand;
			AddSal.FlatStyle = FlatStyle.Flat;
			AddSal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			AddSal.ForeColor = Color.White;
			AddSal.Location = new Point(22, 796);
			AddSal.Name = "AddSal";
			AddSal.Size = new Size(167, 56);
			AddSal.TabIndex = 39;
			AddSal.Text = "Add";
			AddSal.UseVisualStyleBackColor = false;
			AddSal.Click += AddSal_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Teal;
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(2326, 130);
			panel1.TabIndex = 31;
			// 
			// TotalDays
			// 
			TotalDays.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			TotalDays.Location = new Point(22, 527);
			TotalDays.Name = "TotalDays";
			TotalDays.Size = new Size(500, 44);
			TotalDays.TabIndex = 33;
			// 
			// SalLogoutl
			// 
			SalLogoutl.AutoSize = true;
			SalLogoutl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SalLogoutl.ForeColor = Color.Teal;
			SalLogoutl.Location = new Point(2028, 170);
			SalLogoutl.Name = "SalLogoutl";
			SalLogoutl.Size = new Size(116, 37);
			SalLogoutl.TabIndex = 71;
			SalLogoutl.Text = "Logout";
			SalLogoutl.Click += SalLogoutl_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.Teal;
			label6.Location = new Point(1712, 170);
			label6.Name = "label6";
			label6.Size = new Size(107, 37);
			label6.TabIndex = 70;
			label6.Text = "Salary";
			label6.Click += label6_Click;
			// 
			// SalDepl
			// 
			SalDepl.AutoSize = true;
			SalDepl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SalDepl.ForeColor = Color.Teal;
			SalDepl.Location = new Point(1306, 170);
			SalDepl.Name = "SalDepl";
			SalDepl.Size = new Size(200, 37);
			SalDepl.TabIndex = 69;
			SalDepl.Text = "Departments";
			SalDepl.Click += SalDepl_Click;
			// 
			// SalEmp
			// 
			SalEmp.AutoSize = true;
			SalEmp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SalEmp.ForeColor = Color.Teal;
			SalEmp.Location = new Point(951, 170);
			SalEmp.Name = "SalEmp";
			SalEmp.Size = new Size(157, 37);
			SalEmp.TabIndex = 68;
			SalEmp.Text = "Employee";
			SalEmp.Click += SalEmp_Click;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(1198, 155);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(102, 52);
			pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 67;
			pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(1604, 155);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(102, 52);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 66;
			pictureBox2.TabStop = false;
			// 
			// pictureBox6
			// 
			pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.Location = new Point(1920, 155);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(102, 52);
			pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox6.TabIndex = 65;
			pictureBox6.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(843, 155);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(102, 52);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 64;
			pictureBox3.TabStop = false;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label10.ForeColor = Color.Teal;
			label10.Location = new Point(1280, 266);
			label10.Name = "label10";
			label10.Size = new Size(244, 37);
			label10.TabIndex = 63;
			label10.Text = "Manage Salary";
			// 
			// SalList
			// 
			SalList.AllowUserToAddRows = false;
			SalList.BackgroundColor = Color.White;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Teal;
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			SalList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			SalList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			SalList.Cursor = Cursors.Hand;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			SalList.DefaultCellStyle = dataGridViewCellStyle2;
			SalList.GridColor = Color.Black;
			SalList.Location = new Point(610, 329);
			SalList.MultiSelect = false;
			SalList.Name = "SalList";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.Teal;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.White;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			SalList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			SalList.RowHeadersWidth = 82;
			SalList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			SalList.Size = new Size(1487, 712);
			SalList.TabIndex = 72;
			// 
			// Salaries
			// 
			AutoScaleDimensions = new SizeF(19F, 37F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(2326, 1079);
			Controls.Add(SalList);
			Controls.Add(SalLogoutl);
			Controls.Add(label6);
			Controls.Add(SalDepl);
			Controls.Add(SalEmp);
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox6);
			Controls.Add(pictureBox3);
			Controls.Add(label10);
			Controls.Add(pictureBox1);
			Controls.Add(EmpNameList);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(label7);
			Controls.Add(SalAmount);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(TotalDays);
			Controls.Add(AddSal);
			Controls.Add(panel1);
			Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 3, 4, 3);
			Name = "Salaries";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Salaries";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)SalList).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private ComboBox EmpNameList;
		private Panel panel4;
		private Panel panel3;
		private Panel panel2;
		private Label label7;
		private TextBox SalAmount;
		private Label label4;
		private Label label3;
		private ContextMenuStrip contextMenuStrip1;
		private Label label1;
		private Button AddSal;
		private Panel panel1;
		private TextBox TotalDays;
		private Label SalLogoutl;
		private Label label6;
		private Label SalDepl;
		private Label SalEmp;
		private PictureBox pictureBox4;
		private PictureBox pictureBox2;
		private PictureBox pictureBox6;
		private PictureBox pictureBox3;
		private Label label10;
		private DataGridView SalList;
	}
}