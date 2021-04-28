using System;
using System.Drawing;
using System.Windows.Forms;

namespace IranyitoMutato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(passAttemptCountTextBox.Text) > 0)
                {
                    enableTextBoxes();
                }
                else
                {
                    disableTextBoxes();
                }
            }
            catch (FormatException)
            {
                disableTextBoxes();
            }

        }

        private void enableTextBoxes()
        {
            successfulPassCountTextBox.Enabled = true;
            passedYardsTextBox.Enabled = true;
            successfulTDPassCountTextBox.Enabled = true;
            lostBallCountTextBox.Enabled = true;
        }

        private void disableTextBoxes()
        {
            successfulPassCountTextBox.Enabled = false;
            passedYardsTextBox.Enabled = false;
            successfulTDPassCountTextBox.Enabled = false;
            lostBallCountTextBox.Enabled = false;
        }

        private double MinMax(double x)
        {
            if (x < 0)
                return 0;
            else if (x > 2.375)
                return 2.375;
            return x;
        }

        private double Szamol(int kiserlet, int sikeres, int yardok, int tdPassz, int eladott)
        {
            double a, b, c, d;
            a = MinMax(((double)sikeres / kiserlet - 0.3) * 5);
            b = MinMax(((double)yardok / kiserlet - 3) * 0.25);
            c = MinMax(((double)tdPassz / kiserlet) * 20);
            d = MinMax(2.375 - ((double)eladott / kiserlet) * 25);

            return 100 * (a + b + c + d) / 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ratingLabel.Text = Convert.ToString(Math.Round(Szamol(int.Parse(passAttemptCountTextBox.Text), int.Parse(successfulPassCountTextBox.Text), int.Parse(passedYardsTextBox.Text), int.Parse(successfulTDPassCountTextBox.Text), int.Parse(lostBallCountTextBox.Text)), 2));
                ratingLabel.ForeColor = Color.Black;
            }
            catch (FormatException)
            {
                ratingLabel.Text = "Hibás adat!";
                ratingLabel.ForeColor = Color.Red;
            }
            
        }
    }
}
