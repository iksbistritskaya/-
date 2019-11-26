using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Native_Place
{
	public partial class Form6 : Form
	{
		DataBaseProcedure procedure = new DataBaseProcedure();
		public Form6()
		{
			InitializeComponent();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
		}

		private void button2_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
		}

		

		private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void stbBil()
		{
			try
			{
				Action action = () =>
				{
					try
					{
						DateBaseTables dataComb = new DateBaseTables();
						dataComb.DTDan_pac.Clear();
						dataComb.Fillsotr();
						dataComb.dependency.OnChange += BILonchange;
						dataGridView1.DataSource = dataComb.DTDan_pac;
						dataGridView1.Columns[0].Visible = false;
						dataGridView1.Columns[1].HeaderText = "Фамилия";
						dataGridView1.Columns[2].HeaderText = "Имя";
						dataGridView1.Columns[3].HeaderText = "Отчество";
						dataGridView1.Columns[4].HeaderText = "Тариф";
						dataGridView1.Columns[5].HeaderText = "Дата рождения";
						dataGridView1.Columns[6].HeaderText = "Серия паспорта";
						dataGridView1.Columns[7].HeaderText = "Номер паспорта";
						dataGridView1.Columns[8].HeaderText = "Номер полиса";
						dataGridView1.Columns[9].HeaderText = "Срок беременности";
						dataGridView1.Columns[10].HeaderText = "Логин";
						dataGridView1.Columns[11].HeaderText = "Пароль";

					}
					catch
					{

					}

				};
				Invoke(action);
			}
			catch { }
		}



		private void StbBil()
		{
			try
			{
				Action action = () =>
				{
					try
					{
						DateBaseTables dataComb = new DateBaseTables();
						dataComb.DTDolj.Clear();
						dataComb.FillDolj();
						dataComb.dependency.OnChange += BILon;
						dataGridView2.DataSource = dataComb.DTDolj;
						dataGridView2.Columns[0].Visible = false;
						dataGridView2.Columns[1].HeaderText = "Название";
						dataGridView2.Columns[2].HeaderText = "Название";
					}
					catch
					{

					}

				};
				Invoke(action);
			}
			catch { }
		}
	

		private void BILonchange(object sender, SqlNotificationEventArgs e)
		{
			if (e.Info != SqlNotificationInfo.Invalid)
				stbBil();
		}

		private void BILon(object sender, SqlNotificationEventArgs e)
		{
			if (e.Info != SqlNotificationInfo.Invalid)
				stbBil();
		}
		


		private void adm_Load(object sender, EventArgs e)
		{
			Thread thread1 = new Thread(stbBil);
			Thread thread2 = new Thread(StbBil);
			thread1.Start();
			thread2.Start();
			
		}

		

		

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form1 form1 = new Form1();
			form1.Show();
			this.Hide();
		}

		private void button8_Click(object sender, EventArgs e)
		{

			switch (MessageBox.Show("Удалить данные "
			+ dataGridView1.CurrentRow.Cells[0].Value.ToString() + " "
			+ dataGridView1.CurrentRow.Cells[1].Value.ToString() + " "
			+ dataGridView1.CurrentRow.Cells[2].Value.ToString() + " "
			+ dataGridView1.CurrentRow.Cells[3].Value.ToString() + " "
			+ dataGridView1.CurrentRow.Cells[4].Value.ToString() + " "
			+ dataGridView1.CurrentRow.Cells[5].Value.ToString() + " "
			+ dataGridView1.CurrentRow.Cells[6].Value.ToString() + " "
			+ dataGridView1.CurrentRow.Cells[7].Value.ToString() + " "
			+ dataGridView1.CurrentRow.Cells[8].Value.ToString() + " "
			+ dataGridView1.CurrentRow.Cells[9].Value.ToString() + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
			{
				case DialogResult.Yes:
					procedure.spsotr_Delete((int)dataGridView1.CurrentRow.Cells[0].Value);
					break;
				case DialogResult.No:

					break;
			}
		}
		private void ExportToExcel()
		{
			Excel.Application exApp = new Excel.Application();
			//exApp.Visible = true; (данную строку можно не указывать)
			exApp.Workbooks.Add();
			Excel.Worksheet workSheet = (Excel.Worksheet)exApp.ActiveSheet;
			workSheet.Cells[1, 1] = "ID";
			workSheet.Cells[1, 2] = "Фамилия";
			workSheet.Cells[1, 3] = "Имя";
			workSheet.Cells[1, 4] = "Отчество";
			workSheet.Cells[1, 5] = "Дата рождения";
			workSheet.Cells[1, 6] = "Серия паспорта";
			workSheet.Cells[1, 7] = "Номер паспорта";
			workSheet.Cells[1, 8] = "Номер полиса";
			workSheet.Cells[1, 9] = "Логин";
			workSheet.Cells[1, 10] = "Пароль";
			workSheet.Cells[1, 11] = "Пароль";
			

			int rowExcel = 2; //начать со второй строки.
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				//заполняем строку
				workSheet.Cells[rowExcel, "A"] = dataGridView1.Rows[i].Cells["ID_Dan_pac"].Value;
				workSheet.Cells[rowExcel, "B"] = dataGridView1.Rows[i].Cells["Famil"].Value;
				workSheet.Cells[rowExcel, "C"] = dataGridView1.Rows[i].Cells["Imya"].Value;
				workSheet.Cells[rowExcel, "D"] = dataGridView1.Rows[i].Cells["Otchestvo"].Value;
				workSheet.Cells[rowExcel, "E"] = dataGridView1.Rows[i].Cells["Data_rojd"].Value;
				workSheet.Cells[rowExcel, "F"] = dataGridView1.Rows[i].Cells["Ser_pasp"].Value;
				workSheet.Cells[rowExcel, "G"] = dataGridView1.Rows[i].Cells["Nom_pasp"].Value;
				workSheet.Cells[rowExcel, "H"] = dataGridView1.Rows[i].Cells["Nom_pol"].Value;
				workSheet.Cells[rowExcel, "I"] = dataGridView1.Rows[i].Cells["Srok_ber"].Value;
				workSheet.Cells[rowExcel, "J"] = dataGridView1.Rows[i].Cells["Av_login"].Value;
				workSheet.Cells[rowExcel, "K"] = dataGridView1.Rows[i].Cells["Av_Password"].Value;
				++rowExcel;
			}
			string pathToXmlFile;
			pathToXmlFile = Environment.CurrentDirectory + "\\" + "MyFile.xls";
			workSheet.SaveAs(pathToXmlFile);
			exApp.Quit();
			MessageBox.Show("Excel файл создан");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			ExportToExcel();
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			button4.BackColor = Color.BlueViolet;
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
	}

