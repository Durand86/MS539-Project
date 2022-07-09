namespace Sasquach_Forest_Farms_Logistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            string str = textBox1.Text;
            if (int.TryParse(str, out result))
            {
                MessageBox.Show("Data Recorded");
            }
            else
            { MessageBox.Show("Please enter nunbers above zero or Leave Blank");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double txt2 = Convert.ToDouble(textBox2.Text);
            double txt3 = Convert.ToDouble(textBox3.Text);

            double sum = txt2 + txt3;

            textBox4.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double txt2 = Convert.ToDouble(textBox2.Text);
            double txt3 = Convert.ToDouble(textBox3.Text);

            double sum = txt2 - txt3;

            textBox4.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double txt2 = Convert.ToDouble(textBox2.Text);
            double txt3 = Convert.ToDouble(textBox3.Text);

            double sum = txt2 * txt3;

            textBox4.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double txt2 = Convert.ToDouble(textBox2.Text);
            double txt3 = Convert.ToDouble(textBox3.Text);

            double sum = txt2 / txt3;

            textBox4.Text = sum.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            { 
            double week1; // To hold week score #1
                double week2; // To hold week score #2
                double week3; // To hold week score #3
                double week4; // To hold week score #4
                double average; //To hold the Average Amount Sold

                // Get the four week scores.
                week1 = double.Parse(textBox5.Text);
                week2 = double.Parse(textBox6.Text);
                week3 = double.Parse(textBox7.Text);
                week4 = double.Parse(textBox8.Text);

                // Calculate the average week score.
                average = (week1 + week2 + week3 + week4) / 4.0;

                // Display the average week score, with 
                // the output rounded to 1 decimal point.

                label14.Text = average.ToString("n1");
                }
                catch (Exception ex)
                { // Display the default error message.
                MessageBox.Show(ex.Message); }
            }

        private void button8_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls.
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            label14.Text = "";
        }
    }
    }