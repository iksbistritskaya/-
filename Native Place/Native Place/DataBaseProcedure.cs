using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Native_Place
{
	class DataBaseProcedure
	{
		private SqlCommand cmd = new SqlCommand("", DateBaseTables.sqlConnection);
		private void spConfiguration(string spName)
		{
			cmd.CommandText = spName;
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
		}
		public void spAvtoriz_Insert( string Famil, string Imya, string Otchestvo, string Data_rojd,string Nom_pol, string Av_Login, string Av_Password)
		{
			spConfiguration("Reg_Insert");
			try
			{
				cmd.Parameters.AddWithValue("@Famil", Famil);
				cmd.Parameters.AddWithValue("@Imya", Imya);
				cmd.Parameters.AddWithValue("@Otchestvo", Otchestvo);
				cmd.Parameters.AddWithValue("@Data_rojd", Data_rojd);
				cmd.Parameters.AddWithValue("@Nom_pol", Nom_pol);
				cmd.Parameters.AddWithValue("@Av_Login", Av_Login);
				cmd.Parameters.AddWithValue("@Av_Password", Av_Password);
				//cmd.Parameters.AddWithValue("@Pole_ID", Pole_ID);
				DateBaseTables.sqlConnection.Open();
				DateBaseTables.sqlConnection.InfoMessage += message;
				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
			}

			catch (SqlException ex)
			{
				DateBaseTables.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
			}
			finally
			{
				DateBaseTables.sqlConnection.Close();
			}

		}

		public void spsotr_Insert(string f_sotr, string i_sotr, string o_sotr, string d_roj, string ser_pas, string nom_pas, string id_dolz, string tel_sotr)
		{
			spConfiguration("Add_sotr");
			try
			{
				cmd.Parameters.AddWithValue("@f_sotr", f_sotr);
				cmd.Parameters.AddWithValue("@i_sotr", i_sotr);
				cmd.Parameters.AddWithValue("@o_sotr", o_sotr);
				cmd.Parameters.AddWithValue("@d_roj", d_roj);
				cmd.Parameters.AddWithValue("@ser_pas", ser_pas);
				cmd.Parameters.AddWithValue("@nom_pas", nom_pas);
				cmd.Parameters.AddWithValue("@id_dolz", id_dolz);
				cmd.Parameters.AddWithValue("@tel_sotr", tel_sotr);
				DateBaseTables.sqlConnection.Open();
				DateBaseTables.sqlConnection.InfoMessage += message;
				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
			}
			catch (SqlException ex)
			{
				DateBaseTables.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
			}
			finally
			{
				DateBaseTables.sqlConnection.Close();
			}
			public void spsotr_Delete(Int32 id_dan_pac)
		{
			spConfiguration("Dan_pac_Delete");
			try
			{
				cmd.Parameters.AddWithValue("@id_dan_pac", id_dan_pac);
				DateBaseTables.sqlConnection.Open();
				DateBaseTables.sqlConnection.InfoMessage += message;
				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
			}
			catch (SqlException ex)
			{
				DateBaseTables.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + ex.Message;
			}
			finally
			{
				DateBaseTables.sqlConnection.Close();
			}
		}

		private void message(object sender, SqlInfoMessageEventArgs e)
		{
			DateBaseTables.error_message += "\n" + DateTime.Now.ToLongDateString() + " " + e.Message;
		}
	}
}
