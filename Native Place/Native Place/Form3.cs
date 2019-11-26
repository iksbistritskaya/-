using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Native_Place
{
	public partial class Form3 : Form
	{
		DataBaseProcedure procedure = new DataBaseProcedure();
		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			procedure.spAvtoriz_Insert(textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text, textBox4.Text,  textBox5.Text, textBox6.Text);
			MessageBox.Show("Вы зарегистрировались!!!");
			Form2 form2 = new Form2();
			form2.Show();
			this.Hide();

		}
	}
}
