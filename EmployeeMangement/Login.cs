namespace EmployeeMangement
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void LoginBtn_Click(object sender, EventArgs e)
		{
			if (UserName.Text == ""|| UserPassword.Text== "")
			{
				MessageBox.Show("Enter Username and password");

			}
			else if(UserName.Text == "Admin" && UserPassword.Text == "Admin@123")
			{
				Employee EmpObj = new Employee();
				EmpObj.Show();
				this.Hide();


			}
		}
	}
}
