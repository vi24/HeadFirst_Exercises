using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer() { NumberOfCows = 15 };
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows",
            farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void NumericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }
    }

}
