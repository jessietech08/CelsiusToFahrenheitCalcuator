namespace CelsiusToFahrenheitCalcuator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double c = Convert.ToDouble(txtCelsius.Text); // convert textbox to a double

			// calculate conversion celsius to fahrenhiet
			double f = Math.Round((c * 1.8 + 32), 2);

			// display calculation
			txtFahrenheit.Text = f.ToString();
		}
	}
}
