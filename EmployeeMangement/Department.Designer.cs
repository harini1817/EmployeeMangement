namespace EmployeeMangement
{
	partial class Department
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			pictureBox1 = new PictureBox();
			DeptList = new DataGridView();
			panel4 = new Panel();
			panel3 = new Panel();
			panel2 = new Panel();
			EditBtn = new Button();
			label3 = new Label();
			DeptNameTb = new TextBox();
			label2 = new Label();
			contextMenuStrip1 = new ContextMenuStrip(components);
			label1 = new Label();
			AddBtn = new Button();
			panel1 = new Panel();
			pictureBox3 = new PictureBox();
			DepEmpl = new Label();
			pictureBox6 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox4 = new PictureBox();
			label5 = new Label();
			DepSal = new Label();
			DepLogout = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)DeptList).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
			// DeptList
			// 
			DeptList.AllowUserToAddRows = false;
			DeptList.BackgroundColor = Color.White;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Teal;
			dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle1.ForeColor = Color.White;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
			dataGridViewCellStyle1.SelectionForeColor = Color.Black;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			DeptList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			DeptList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DeptList.Cursor = Cursors.Hand;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			DeptList.DefaultCellStyle = dataGridViewCellStyle2;
			DeptList.GridColor = Color.Black;
			DeptList.Location = new Point(605, 336);
			DeptList.MultiSelect = false;
			DeptList.Name = "DeptList";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.Teal;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle3.ForeColor = Color.White;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			DeptList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			DeptList.RowHeadersWidth = 82;
			DeptList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			DeptList.Size = new Size(1692, 712);
			DeptList.TabIndex = 50;
			DeptList.CellContentClick += DeptList_CellContentClick;
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
			// EditBtn
			// 
			EditBtn.BackColor = Color.PaleTurquoise;
			EditBtn.Cursor = Cursors.Hand;
			EditBtn.FlatStyle = FlatStyle.Flat;
			EditBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			EditBtn.ForeColor = Color.Black;
			EditBtn.Location = new Point(222, 514);
			EditBtn.Name = "EditBtn";
			EditBtn.Size = new Size(175, 56);
			EditBtn.TabIndex = 40;
			EditBtn.Text = "Update";
			EditBtn.UseVisualStyleBackColor = false;
			EditBtn.Click += EditBtn_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Teal;
			label3.Location = new Point(22, 361);
			label3.Name = "label3";
			label3.Size = new Size(279, 37);
			label3.TabIndex = 34;
			label3.Text = "Department Name";
			// 
			// DeptNameTb
			// 
			DeptNameTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			DeptNameTb.Location = new Point(22, 415);
			DeptNameTb.Name = "DeptNameTb";
			DeptNameTb.Size = new Size(500, 44);
			DeptNameTb.TabIndex = 33;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Teal;
			label2.Location = new Point(1281, 285);
			label2.Name = "label2";
			label2.Size = new Size(258, 37);
			label2.TabIndex = 32;
			label2.Text = "Department List";
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
			// AddBtn
			// 
			AddBtn.BackColor = Color.Teal;
			AddBtn.Cursor = Cursors.Hand;
			AddBtn.FlatStyle = FlatStyle.Flat;
			AddBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			AddBtn.ForeColor = Color.White;
			AddBtn.Location = new Point(22, 514);
			AddBtn.Name = "AddBtn";
			AddBtn.Size = new Size(167, 56);
			AddBtn.TabIndex = 39;
			AddBtn.Text = "Add";
			AddBtn.UseVisualStyleBackColor = false;
			AddBtn.Click += AddBtn_Click_1;
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
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(844, 151);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(102, 52);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 53;
			pictureBox3.TabStop = false;
			// 
			// DepEmpl
			// 
			DepEmpl.AutoSize = true;
			DepEmpl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			DepEmpl.ForeColor = Color.Teal;
			DepEmpl.Location = new Point(952, 166);
			DepEmpl.Name = "DepEmpl";
			DepEmpl.Size = new Size(157, 37);
			DepEmpl.TabIndex = 59;
			DepEmpl.Text = "Employee";
			DepEmpl.Click += DepEmpl_Click;
			// 
			// pictureBox6
			// 
			pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.Location = new Point(1921, 151);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new Size(102, 52);
			pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox6.TabIndex = 56;
			pictureBox6.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(1605, 151);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(102, 52);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 57;
			pictureBox2.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new Point(1199, 151);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(102, 52);
			pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox4.TabIndex = 58;
			pictureBox4.TabStop = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.ForeColor = Color.Teal;
			label5.Location = new Point(1307, 166);
			label5.Name = "label5";
			label5.Size = new Size(200, 37);
			label5.TabIndex = 60;
			label5.Text = "Departments";
			label5.Click += label5_Click;
			// 
			// DepSal
			// 
			DepSal.AutoSize = true;
			DepSal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			DepSal.ForeColor = Color.Teal;
			DepSal.Location = new Point(1713, 166);
			DepSal.Name = "DepSal";
			DepSal.Size = new Size(107, 37);
			DepSal.TabIndex = 61;
			DepSal.Text = "Salary";
			DepSal.Click += DepSal_Click;
			// 
			// DepLogout
			// 
			DepLogout.AutoSize = true;
			DepLogout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			DepLogout.ForeColor = Color.Teal;
			DepLogout.Location = new Point(2029, 166);
			DepLogout.Name = "DepLogout";
			DepLogout.Size = new Size(116, 37);
			DepLogout.TabIndex = 62;
			DepLogout.Text = "Logout";
			DepLogout.Click += DepLogout_Click;
			// 
			// Department
			// 
			AutoScaleDimensions = new SizeF(19F, 37F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(2326, 1079);
			Controls.Add(DepLogout);
			Controls.Add(DepSal);
			Controls.Add(label5);
			Controls.Add(DepEmpl);
			Controls.Add(pictureBox4);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox6);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox1);
			Controls.Add(DeptList);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(EditBtn);
			Controls.Add(label3);
			Controls.Add(DeptNameTb);
			Controls.Add(label2);
			Controls.Add(AddBtn);
			Controls.Add(panel1);
			Font = new Font("Microsoft Sans Serif", 12F);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 3, 4, 3);
			Name = "Department";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Department";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)DeptList).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private DataGridView DeptList;
		private Panel panel4;
		private Panel panel3;
		private Panel panel2;
		private Button EditBtn;
		private Label label3;
		private TextBox DeptNameTb;
		private Label label2;
		private ContextMenuStrip contextMenuStrip1;
		private Label label1;
		private Button AddBtn;
		private Panel panel1;
		private PictureBox pictureBox3;
		private Label DepEmpl;
		private PictureBox pictureBox6;
		private PictureBox pictureBox2;
		private PictureBox pictureBox4;
		private Label label5;
		private Label DepSal;
		private Label DepLogout;
	}
}