using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Native_Place
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		static int i;
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{

				SqlCommand com = new SqlCommand();
				com.CommandText = "Select count(*) From Reg WHERE Av_Login = '" + textBox1.Text + "' AND Av_Password = '" + textBox2.Text + "'";
				SqlCommand check = new SqlCommand(com.CommandText, DateBaseTables.sqlConnection);
				DateBaseTables.sqlConnection.Open();
				i = (int)check.ExecuteScalar();
				DateBaseTables.sqlConnection.Close();
				if (i == 0)
				{
					MessageBox.Show("Неверный логин или пароль");
				}
				else
				{
					SqlCommand command = new SqlCommand("", DateBaseTables.sqlConnection);
					DateBaseTables.sqlConnection.Open();
					DateBaseTables.sqlConnection.Close();
					MessageBox.Show("Вы успешно авторизировались!");
					Form5 form5 = new Form5();
					form5.Show();
					this.Hide();
				}
			}
			finally
			{
				DateBaseTables.sqlConnection.Close();
			}
		}
	}
}
