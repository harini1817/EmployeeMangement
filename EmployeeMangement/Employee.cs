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
	public partial class Employee : Form
	{
		Functions Con;

		public Employee()
		{
			InitializeComponent();
			Con = new Functions();
			ShowEmployees();
			GetDepartment();
		}
		private void ShowEmployees()
		{
			string Query = "SELECT * FROM EmployeeTbl";
			EmpGrid.DataSource = Con.GetData(Query);
		}

		private void GetDepartment()
		{
			string Query = "Select * from Departmenttbl";
			EmpDept.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
			EmpDept.ValueMember = Con.GetData(Query).Columns["DeptId"].ToString();
			EmpDept.DataSource = Con.GetData(Query);

		}

		private void AddEmp_Click(object sender, EventArgs e)
		{
			try
			{
				if (EmpName.Text == "" || EmpGen.SelectedIndex == -1 || EmpDept.SelectedIndex == -1 || EmpDob.Text == "" || EmpJoin.Text == "" || EmpSal.Text == "")
				{
					MessageBox.Show("Missing Data!!");
				}
				else
				{
					string Name = EmpName.Text;
					string Gen = EmpGen.SelectedItem.ToString();
					string Dep = EmpDept.SelectedValue.ToString();
					string Dob = EmpDob.Value.ToString("yyyy-MM-dd");
					string Date = EmpJoin.Value.ToString("yyyy-MM-dd");

					int sal = Convert.ToInt32(EmpSal.Text);
					string Query = "INSERT INTO EmployeeTbl (EmpName,EmpGen,EmpDep,EmpDob,EmpDate,EmpSal) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
					Query = string.Format(Query, Name, Gen, Dep, Dob, Date, sal);
					Con.SetData(Query);
					ShowEmployees();
					MessageBox.Show("Employee added successfully");
					EmpName.Text = "";
					EmpGen.SelectedIndex = -1;
					EmpDept.SelectedIndex = -1;
					EmpSal.Text = "";


				}
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.Message);
			}

		}

		private void EditEmp_Click(object sender, EventArgs e)
		{
			try
			{
				if (EmpName.Text == "" || EmpGen.SelectedIndex == -1 || EmpDept.SelectedIndex == -1 || EmpDob.Text == "" || EmpJoin.Text == "" || EmpSal.Text == "")
				{
					MessageBox.Show("Missing Data!!");
				}
				else
				{
					string Name = EmpName.Text;
					string Gen = EmpGen.SelectedItem.ToString();
					string Dep = EmpDept.SelectedValue.ToString();
					string Dob = EmpDob.Value.ToString("yyyy-MM-dd");
					string Date = EmpJoin.Value.ToString("yyyy-MM-dd");

					int sal = Convert.ToInt32(EmpSal.Text);
					string Query = "UPDATE EmployeeTbl SET EmpName='{0}', EmpGen='{1}', EmpDep='{2}', EmpDob='{3}', EmpDate='{4}', EmpSal='{5}' WHERE EmpId={6}";
					Query = string.Format(Query, Name, Gen, Dep, Dob, Date, sal, Key);
					Con.SetData(Query);
					ShowEmployees();
					MessageBox.Show("Employee Updated successfully");
					EmpName.Text = "";
					EmpGen.SelectedIndex = -1;
					EmpDept.SelectedIndex = -1;
					EmpSal.Text = "";


				}

			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.Message);
			}


		}

		private void EmpDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (Key == 0)
				{
					MessageBox.Show("Missing Data!!");
				}
				else
				{
					string Name = EmpName.Text;
					string Gen = EmpGen.SelectedItem.ToString();
					string Dep = EmpDept.SelectedValue.ToString();
					string Dob = EmpDob.Value.ToString("yyyy-MM-dd");
					string Date = EmpJoin.Value.ToString("yyyy-MM-dd");

					int sal = Convert.ToInt32(EmpSal.Text);
					string Query = "Delete from EmployeeTbl where EmpId={0}";
					Query = string.Format(Query, Key);
					Con.SetData(Query);
					ShowEmployees();
					MessageBox.Show("Employee deleted successfully");
					EmpName.Text = "";
					EmpGen.SelectedIndex = -1;
					EmpDept.SelectedIndex = -1;
					EmpSal.Text = "";


				}

			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.Message);
			}

		}
		int Key = 0;



		private void EmpGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			EmpName.Text = EmpGrid.SelectedRows[0].Cells[1].Value.ToString();
			EmpGen.SelectedItem = EmpGrid.SelectedRows[0].Cells[2].Value.ToString();
			EmpDept.SelectedItem = EmpGrid.SelectedRows[0].Cells[3].Value.ToString();
			EmpDob.Text = EmpGrid.SelectedRows[0].Cells[4].Value.ToString();
			EmpJoin.Text = EmpGrid.SelectedRows[0].Cells[5].Value.ToString();
			EmpSal.Text = EmpGrid.SelectedRows[0].Cells[6].Value.ToString();




			if (EmpName.Text == "" || EmpGen.SelectedIndex == -1 || EmpDept.SelectedIndex == -1 || EmpDob.Text == "" || EmpJoin.Text == "" || EmpSal.Text == "")
			{
				Key = 0;
			}
			else
			{
				Key = Convert.ToInt32(EmpGrid.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		private void label11_Click(object sender, EventArgs e)
		{
			Employee EmpObj = new Employee();
			EmpObj.Show();
			this.Hide();
		}

		private void DeptLabel_Click(object sender, EventArgs e)
		{
			Department DepObj = new Department();
			DepObj.Show();
			this.Hide();
		}

		private void SalaryLable_Click(object sender, EventArgs e)
		{
			Salaries SalObj = new Salaries();
			SalObj.Show();
			this.Hide();
		}

		private void LogoutLabel_Click(object sender, EventArgs e)
		{
			Login LogObj = new Login();
			LogObj.Show();
			this.Hide();
		}
	}
}
