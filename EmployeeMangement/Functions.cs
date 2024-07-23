using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
	namespace EmployeeMangement
{
	class Functions
	{
		private string ConStr;
		private SqlConnection Con;
		private SqlCommand Cmd;
		private DataTable Dt;
		private SqlDataAdapter sda;





		public Functions()
		{
			ConStr = @"Data Source=LAPTOP-6RRQ2KPC\SQLEXPRESS;Initial Catalog=EmployeeManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
			Con = new SqlConnection(ConStr);
			Cmd = new SqlCommand();
			Cmd.Connection = Con;
		}

		public DataTable GetData(string Query) 
		{
			Dt = new DataTable();
			sda = new SqlDataAdapter(Query,ConStr);
			sda.Fill(Dt);
			return Dt;
		}

		public int SetData(string Query)
		{
			int cnt = 0;
			if(Con.State == ConnectionState.Closed)
			{
				Con.Open();

			}
			Cmd.CommandText = Query;
			cnt = Cmd.ExecuteNonQuery();
			return cnt;
		}


	}
}
