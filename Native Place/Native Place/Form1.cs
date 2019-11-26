using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Native_Place
{
	public partial class Form1 : Form
	{
		DataBaseProcedure procedure = new DataBaseProcedure();
		public Form1()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
		}

		private void button4_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}
		private void stbBol()
		{
			try
			{
				Action action = () =>
				{
					try
					{
						DataBaseTables1 dataComb = new DataBaseTables1();
						dataComb.DTYch_med_prep.Clear();
						dataComb.FillYach_med_prep();
						dataComb.dependency.OnChange += BILong;
						dataGridView1.DataSource = dataComb.DTYach_med_prep;
						dataGridView1.Columns[0].Visible = false;
						dataGridView1.Columns[1].HeaderText = "Название";
						dataGridView1.Columns[2].HeaderText = "Количество";



					}
					catch
					{

					}

				};
				Invoke(action);
			}
			catch { }
		}
		private void BILong(object sender, SqlNotificationEventArgs e)
		{
			if (e.Info != SqlNotificationInfo.Invalid)
				stbBol();
		}

		private void adm_Load(object sender, EventArgs e)
		{

			Thread thread3 = new Thread(stbBol);
			thread3.Start();
		}
	}
}
