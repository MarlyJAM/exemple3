using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemple3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {

            float taille = float.Parse(textBox1.Text);
            float poids = float.Parse(textBox2.Text);
            float imc = poids /( taille * taille) ;


            if (imc <= 16.5)
            {
                textBox3.Text = "dénutrition";
                textBox4.Text = imc.ToString();
                textBox3.BackColor = Color.YellowGreen;

            }
            else if (16.5 <= imc && imc <= 18.5)
            {
                textBox3.Text = "maigreur";
                textBox4.Text = imc.ToString();
                textBox3.BackColor = Color.Yellow;
            }
            else if (18.5 <= imc && imc <= 25)
            {
                textBox3.Text = "poids normarl";
                textBox4.Text = imc.ToString();
                textBox3.BackColor = Color.Green;
            }
            else if (25 <= imc && imc <= 30)
            {
                textBox3.Text = "surpoids";
                textBox4.Text = imc.ToString();
                textBox3.BackColor = Color.DarkKhaki;
            }
            else if (30 <= imc && imc <= 35)
            {
                textBox3.Text = "obésité modérée";
                textBox4.Text = imc.ToString();
                textBox3.BackColor = Color.Orange;
            }
            else if (35 <= imc && imc <= 40)
            {
                textBox3.Text = "obésité sésère";
                textBox4.Text = imc.ToString();
                textBox3.BackColor = Color.OrangeRed;
            }
            else
            {
                textBox3.Text = "obésité morbide";
                textBox4.Text = imc.ToString();
                textBox3.BackColor = Color.Red;
            }

        }
    }
}
