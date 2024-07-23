namespace EmployeeMangement
{
	partial class Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			panel1 = new Panel();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			UserName = new TextBox();
			UserPassword = new TextBox();
			label2 = new Label();
			label3 = new Label();
			LoginBtn = new Button();
			panel2 = new Panel();
			panel3 = new Panel();
			panel4 = new Panel();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Teal;
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(605, 739);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Teal;
			label1.Location = new Point(810, 31);
			label1.Name = "label1";
			label1.Size = new Size(492, 37);
			label1.TabIndex = 1;
			label1.Text = "Employee Management System";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(924, 105);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(282, 234);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// UserName
			// 
			UserName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			UserName.Location = new Point(810, 437);
			UserName.Name = "UserName";
			UserName.Size = new Size(500, 44);
			UserName.TabIndex = 3;
			// 
			// UserPassword
			// 
			UserPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			UserPassword.Location = new Point(810, 581);
			UserPassword.Name = "UserPassword";
			UserPassword.Size = new Size(500, 44);
			UserPassword.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Teal;
			label2.Location = new Point(810, 381);
			label2.Name = "label2";
			label2.Size = new Size(179, 37);
			label2.TabIndex = 5;
			label2.Text = "User Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Teal;
			label3.Location = new Point(810, 519);
			label3.Name = "label3";
			label3.Size = new Size(158, 37);
			label3.TabIndex = 6;
			label3.Text = "Password";
			// 
			// LoginBtn
			// 
			LoginBtn.BackColor = Color.White;
			LoginBtn.Cursor = Cursors.Hand;
			LoginBtn.FlatStyle = FlatStyle.Flat;
			LoginBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			LoginBtn.ForeColor = Color.Teal;
			LoginBtn.Location = new Point(939, 655);
			LoginBtn.Name = "LoginBtn";
			LoginBtn.Size = new Size(224, 56);
			LoginBtn.TabIndex = 7;
			LoginBtn.Text = "LOGIN";
			LoginBtn.UseVisualStyleBackColor = false;
			LoginBtn.Click += LoginBtn_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.Teal;
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(605, 729);
			panel2.Name = "panel2";
			panel2.Size = new Size(944, 10);
			panel2.TabIndex = 8;
			// 
			// panel3
			// 
			panel3.BackColor = Color.Teal;
			panel3.Dock = DockStyle.Right;
			panel3.Location = new Point(1539, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(10, 729);
			panel3.TabIndex = 9;
			// 
			// panel4
			// 
			panel4.BackColor = Color.Teal;
			panel4.Dock = DockStyle.Top;
			panel4.Location = new Point(605, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(934, 10);
			panel4.TabIndex = 10;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(13F, 26F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1549, 739);
			Controls.Add(panel4);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(LoginBtn);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(UserPassword);
			Controls.Add(UserName);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Controls.Add(panel1);
			Font = new Font("Microsoft Sans Serif", 8.25F);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			Load += Login_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private PictureBox pictureBox1;
		private TextBox UserName;
		private TextBox UserPassword;
		private Label label2;
		private Label label3;
		private Button LoginBtn;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
	}
}
