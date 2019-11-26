using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Native_Place
{
	class DataBaseTables1
	{
		public static string error_message = "App:start: " + DateTime.Now.ToLongDateString();
		public static SqlConnection sqlConnection = new SqlConnection("data source = DESKTOP-026U3B1;" + "Initial catalog = Native Place;" +
				   "persist security info = true; user id = sa;" + "password = \"123\"");
		//Переменная для команды
		public SqlCommand command = new SqlCommand("", DateBaseTables.sqlConnection);

		//Объявляем виртуальные таблицы
		public DataTable DTAvtor = new DataTable("Avtor");
		public DataTable DTDan_pac = new DataTable("Dan_pac");
		public DataTable DTDolj = new DataTable("Dolj");
		public DataTable DTPersonal = new DataTable("Personal");
		public DataTable DTPole = new DataTable("Pole");
		public DataTable DTSkl = new DataTable("Skl");
		public DataTable DTYch_med_prep = new DataTable("Ych_med_prep");
		public DataTable DTYch_rod = new DataTable("Ych_rod");
		public DataTable DTYch_rod_p = new DataTable("Ych_rod_p");

		internal void FillYach_med_prep()
		{
			throw new NotImplementedException();
		}

		public SqlDependency dependency = new SqlDependency();
		//Объявляем переменные, которые будут хранить запросы на выборку данных

		
		public string Qryach_med_prep = "SELECT * FROM Yach_med_prep ORDER BY ID_Yach_med_prep";
		private string qryach_med_prep;

		public object DTYach_med_prep { get; internal set; }

		//public DataBaseTables1(string qryach_med_prep)
		//{
		//	Qryach_med_prep = qryach_med_prep;
		//}

		public DataBaseTables1()
		{
			Qryach_med_prep = qryach_med_prep;
		}

		//public void FillYach_med_prep()
		//{
		//	dtFill(Qryach_med_prep, DTYach_med_prep);
		//}



		private void dtFill(string qryach_med_prep, object dTYach_med_prep)
		{
			throw new NotImplementedException();
		}

		private void dtFill(string query, DataTable table)
		{
			//try
			//{
			command.Notification = null;
			command.CommandText = query;
			dependency.AddCommandDependency(command);
			SqlDependency.Start(sqlConnection.ConnectionString);
			sqlConnection.Open();
			table.Load(command.ExecuteReader());
			//}
			//catch (Exception ex)
			//{

			//}
			//finally
			//{
			sqlConnection.Close();
			//}
		}
	}
}

