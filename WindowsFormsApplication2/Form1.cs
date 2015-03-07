using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Results aResults = new Results();
            aResults.Physics = Convert.ToDouble(PhysicsTextBox.Text);
            aResults.Chemistry = Convert.ToDouble(ChemistryTextBox.Text);
            aResults.Math = Convert.ToDouble(MathTextBox.Text);
            AverageTextBox.Text = aResults.GetAverage().ToString();
            GradeTextBox.Text = aResults.GetGradeLetter().ToString();
        }
    }
}
