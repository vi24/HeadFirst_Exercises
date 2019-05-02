using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KathleensParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numberOfPeopleUpDown.Value,
            healthyDecorationsCheckBox.Checked, fancyDecorationsCheckBox.Checked);
            DisplayDinnerPartyCost();
        }
        private void FancyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyDecorationsCheckBox.Checked;
            DisplayDinnerPartyCost();
        }
        private void HealthyDecorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyDecorationsCheckBox.Checked;
            DisplayDinnerPartyCost();
        }
        private void NumberOfPeopleUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberOfPeopleUpDown.Value;
            DisplayDinnerPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            totalCostLabel.Text = Cost.ToString("c");
        }
    }
}
