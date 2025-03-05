namespace cubia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grade1 = Convert.ToDouble(textBox2.Text);
            double grade2 = Convert.ToDouble(textBox3.Text);
            double grade3 = Convert.ToDouble(textBox4.Text);
            double grade4 = Convert.ToDouble(textBox5.Text);
            double grade5 = Convert.ToDouble(textBox6.Text);

            double total = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;

            if (total >= 75)
            {
                Result.Text = ("The student passed.\nThe general average of " + textBox1.Text + " is " + total + ".");
            }
            else
            {
                Result.Text = ("The student failed.\nThe general average of " + textBox1.Text + " is " + total + ".");
            }
        }
    }
}
