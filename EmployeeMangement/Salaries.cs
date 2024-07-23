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
	public partial class Salaries : Form
	{
		Functions Con;

		public Salaries()
		{
			InitializeComponent();
			Con = new Functions();
			ShowSalary();
			GetEmployee();
		}

		private void ShowSalary()
		{
			string Query = "SELECT * FROM SalaryTbl";
			SalList.DataSource = Con.GetData(Query);
		}

		private void GetEmployee()
		{
			string Query = "Select * from EmployeeTbl";
			EmpNameList.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
			EmpNameList.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
			EmpNameList.DataSource = Con.GetData(Query);
		}

		int DSal = 0;
		string Period = "";
		private void GetSalary()
		{
			string Query = "select * from EmployeeTbl where EmpId ={0}";
			Query = string.Format(Query, EmpNameList.SelectedValue.ToString());
			foreach (DataRow dr in Con.GetData(Query).Rows)
			{
				DSal = Convert.ToInt32(dr["EmpSal"].ToString());
			}

			if (TotalDays.Text == "")
			{
				SalAmount.Text = "Rs " + (D * DSal);
			}
			else if (Convert.ToInt32(TotalDays.Text) > 31)
			{
				MessageBox.Show("Daya cannot be greater than 31");
			}
			else
			{
				D = Convert.ToInt32(TotalDays.Text);
				SalAmount.Text = "Rs " + (D * DSal);

			}
		}
		int D = 1;


		private void AddSal_Click(object sender, EventArgs e)
		{
			try
			{
				if (EmpNameList.SelectedIndex == -1 || TotalDays.Text == "")
				{
					MessageBox.Show("Missing Data!!");
				}
				else
				{
					int Amount = DSal * Convert.ToInt32(TotalDays.Text);
					int Days = Convert.ToInt32(TotalDays.Text);

					string Query = "insert into SalaryTbl (Employee,Attendance,Amount) values('{0}',{1},{2})";
					Query = string.Format(Query, EmpNameList.SelectedValue.ToString(), Days, Amount);
					Con.SetData(Query);
					ShowSalary();
					MessageBox.Show("Employee salary added successfully");
					TotalDays.Text = "";
				}
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.Message);
			}
		}

		private void EmpNameList_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetSalary();
		}

		private void SalEmp_Click(object sender, EventArgs e)
		{
			Employee EmpObj = new Employee();
			EmpObj.Show();
			this.Hide();
		}

		private void SalDepl_Click(object sender, EventArgs e)
		{
			Department DepObj = new Department();
			DepObj.Show();
			this.Hide();
		}

		private void label6_Click(object sender, EventArgs e)
		{
			Salaries SalObj = new Salaries();
			SalObj.Show();
			this.Hide();
		}

		private void SalLogoutl_Click(object sender, EventArgs e)
		{
			Login LogObj = new Login();
			LogObj.Show();
			this.Hide();
		}
	}
}
