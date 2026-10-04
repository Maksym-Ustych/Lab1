namespace Lab1_Ustych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Моя перша програма!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = 3.251;
            double y = 0.325;
            double z = 0.466e-4;

            double s =
                Math.Pow(2, Math.Pow(y, x))
                + Math.Pow(Math.Pow(3, x), y)
                - (y * (Math.Atan(z) - 1.0 / 3.0))
                / (Math.Abs(x) + 1.0 / (Math.Pow(y, 2) + 1));

            MessageBox.Show("s = " + s.ToString("F5"));
        }
    }
}
