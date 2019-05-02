using System;
using System.Windows.Forms;

namespace ReimbursementCalculator
{
    public partial class Form1 : Form
    {
        public int startingMileage;
        public int endingMileage;

        public double milesTraveled;
        public double reimburseRate = 0.39;
        public double amountOwed;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                LabelAmount.Text = "$" + amountOwed;

            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot Calculate Mileage");
            }
        }

        private void DisplayMiles_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}
