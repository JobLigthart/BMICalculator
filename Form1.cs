using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rekenen;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lblGewicht.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vul alle textboxen in");
                return; 
            }
            if (lblLengte.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vul alle textboxen in");
                return; 
            }
            if (lblLeeftijd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vul alle textboxen in");
                return; 
            }

            float gewicht = float.Parse(lblGewicht.Text);
            float lengte = float.Parse(lblLengte.Text);
            float leeftijd = float.Parse(lblLeeftijd.Text);

            float BMI = gewicht / (lengte * lengte);
            string advies = "Hier komt uw BMI te staan";
            
            lblBMI.Text = BMI.ToString();
            lblAdvies.Text = advies;

            lblAdvies.Visible = true;
            lblBMI.Visible = true;
            
            if (BMI <= 18.5)
            {
                 lblAdvies.Text = "ondergewicht";
            } 
            else if (BMI <= 25)
            {
                 lblAdvies.Text = "gezondgewicht";
            }
            else {
                 lblAdvies.Text = "overgewicht";
            }

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAdvies.Visible = false;
            lblBMI.Visible = false;
        }

        class BMICalculation
        {
            static void BMIRekenaar()
            {

            }
        }

    }
}
