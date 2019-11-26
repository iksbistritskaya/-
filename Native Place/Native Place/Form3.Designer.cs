namespace Native_Place
{
	partial class Form3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(26, 147);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(315, 26);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Фамилия..";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(26, 179);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(315, 26);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "Имя..";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(26, 211);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(315, 26);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "Отчество..";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(372, 147);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(273, 26);
			this.textBox4.TabIndex = 4;
			this.textBox4.Text = "Номер полиса..";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(372, 179);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(273, 26);
			this.textBox5.TabIndex = 5;
			this.textBox5.Text = "E-mail..";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(372, 211);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(273, 26);
			this.textBox6.TabIndex = 6;
			this.textBox6.Text = "Пароль..";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(145, 285);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(196, 36);
			this.button1.TabIndex = 7;
			this.button1.Text = "Зарегистрироваться";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(372, 243);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(273, 26);
			this.textBox10.TabIndex = 12;
			this.textBox10.Text = "Повтор пароля..";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(372, 285);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(196, 36);
			this.button2.TabIndex = 13;
			this.button2.Text = "Назад";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(26, 243);
			this.maskedTextBox1.Mask = "00/00/0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(315, 26);
			this.maskedTextBox1.TabIndex = 14;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(679, 382);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form3";
			this.Text = "Native Place";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
	}
}