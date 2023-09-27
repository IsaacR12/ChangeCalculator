namespace ChangeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //set the variables
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;
            int change = Convert.ToInt32(textBox1.Text);

            //logic
            do
            {
                if (change >= 25 && change <= 99)
                {
                    change = change - 25;
                    quarters++;
                }
                else if (change <= 24 && change > 9)
                {
                    change = change - 10;
                    dimes++;
                }
                else if (change == 5)
                {
                    change = change - 5;
                    nickels++;
                }
                else if (change <= 4)
                {
                    change = change - 1;
                    pennies++;
                }

                textBox2.Text = quarters.ToString("n");
                textBox3.Text = dimes.ToString("n");
                textBox3.Text = nickels.ToString("n");
                textBox5.Text = pennies.ToString("n");

            } while (change > 0);
        }
    }
}