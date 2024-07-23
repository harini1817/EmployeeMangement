using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMangement
{
	public partial class Department : Form
	{
		Functions Con;
		public Department()
		{
			InitializeComponent();
			Con = new Functions();
			ShowDepartments();
		}

		private void ShowDepartments()
		{
			string Query = "SELECT * FROM Departmenttbl";
			DeptList.DataSource = Con.GetData(Query);
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (DeptNameTb.Text == "")
				{
					MessageBox.Show("Missing Data!!");
				}
				else
				{
					string Dep = DeptNameTb.Text;
					string Query = "INSERT INTO Departmenttbl (DepName) VALUES ('{0}')";
					Query = string.Format(Query, Dep);
					Con.SetData(Query);
					ShowDepartments();
					MessageBox.Show("Department added successfully");
					DeptNameTb.Text = "";
				}
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.Message);
			}
		}

		private void AddBtn_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (DeptNameTb.Text == "")
				{
					MessageBox.Show("Missing Data!!");
				}
				else
				{
					string Dep = DeptNameTb.Text;
					string Query = "INSERT INTO Departmenttbl (DepName) VALUES ('{0}')";
					Query = string.Format(Query, Dep);
					Con.SetData(Query);
					ShowDepartments();
					MessageBox.Show("Department added successfully");
					DeptNameTb.Text = "";
				}
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.Message);
			}
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (DeptNameTb.Text == "")
				{
					MessageBox.Show("Missing Data!!");
				}
				else
				{
					string Dep = DeptNameTb.Text;
					string Query = "UPDATE Departmenttbl SET DepName='{0}' WHERE DeptId={1}";
					Query = string.Format(Query, Dep, Key);
					Con.SetData(Query);
					ShowDepartments();
					MessageBox.Show("Department updated successfully");
					DeptNameTb.Text = "";
				}
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.Message);
			}

		}
		int Key = 0;
		private void DeptList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DeptNameTb.Text = DeptList.SelectedRows[0].Cells[1].Value.ToString();
			if (DeptNameTb.Text == "")
			{
				Key = 0;
			}
			else
			{
				Key = Convert.ToInt32(DeptList.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		private void DepEmpl_Click(object sender, EventArgs e)
		{
			Employee EmpObj = new Employee();
			EmpObj.Show();
			this.Hide();
		}

		private void DepSal_Click(object sender, EventArgs e)
		{
			Salaries SalObj = new Salaries();
			SalObj.Show();
			this.Hide();
		}

		private void DepLogout_Click(object sender, EventArgs e)
		{
			Login LogObj = new Login();
			LogObj.Show();
			this.Hide();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			Department DepObj = new Department();
			DepObj.Show();
			this.Hide();
		}
	}
}
