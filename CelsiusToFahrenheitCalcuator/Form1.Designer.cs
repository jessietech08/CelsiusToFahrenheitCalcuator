namespace CelsiusToFahrenheitCalcuator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			button2 = new Button();
			txtCelsius = new TextBox();
			txtFahrenheit = new TextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(95, 33);
			label1.Name = "label1";
			label1.Size = new Size(47, 15);
			label1.TabIndex = 0;
			label1.Text = "Celsius:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(76, 76);
			label2.Name = "label2";
			label2.Size = new Size(66, 15);
			label2.TabIndex = 1;
			label2.Text = "Fahrenheit:";
			// 
			// button1
			// 
			button1.Location = new Point(42, 139);
			button1.Name = "button1";
			button1.Size = new Size(91, 54);
			button1.TabIndex = 2;
			button1.Text = "Convert";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(179, 139);
			button2.Name = "button2";
			button2.Size = new Size(94, 54);
			button2.TabIndex = 3;
			button2.Text = "Exit";
			button2.UseVisualStyleBackColor = true;
			// 
			// txtCelsius
			// 
			txtCelsius.Location = new Point(179, 30);
			txtCelsius.Name = "txtCelsius";
			txtCelsius.Size = new Size(44, 23);
			txtCelsius.TabIndex = 4;
			txtCelsius.TextChanged += txtCelsius_TextChanged;
			// 
			// txtFahrenheit
			// 
			txtFahrenheit.Enabled = false;
			txtFahrenheit.Location = new Point(179, 73);
			txtFahrenheit.Name = "txtFahrenheit";
			txtFahrenheit.Size = new Size(44, 23);
			txtFahrenheit.TabIndex = 5;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(323, 221);
			Controls.Add(txtFahrenheit);
			Controls.Add(txtCelsius);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Celsius To Fahrenheit Calculator";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Button button1;
		private Button button2;
		private TextBox txtCelsius;
		private TextBox txtFahrenheit;
	}
}
