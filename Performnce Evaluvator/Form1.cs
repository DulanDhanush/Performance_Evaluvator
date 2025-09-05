using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Performnce_Evaluvator
{
    public partial class Form1 : Form
    {
        public double avg = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Calculation Button
        private void Cbutton_Click(object sender, EventArgs e)
        {
            if (EIDtxt.Text == "" || EIDtxt.Text == "")
            {
                MessageBox.Show("Please enter the details!");
                return;
            }else
            {
                if (Convert.ToDouble(Ptxt.Text) > 0 || Convert.ToString(Ptxt.Text) == ""||Convert.ToDouble( Ptxt.Text) < 100 ||
                    Convert.ToString(Teamtxt.Text)== ""||
                    Convert.ToDouble(Teamtxt.Text)>0 || Convert.ToDouble(Teamtxt.Text)>100 ||
                    Convert.ToString(Teamtxt.Text)== ""||
                    Convert.ToDouble(Inovationtxt.Text)>0 || Convert.ToDouble(Inovationtxt.Text)>100)
                {
                    avg = (Convert.ToDouble(Teamtxt.Text)+Convert.ToDouble(Ptxt.Text)+Convert.ToDouble(Inovationtxt.Text)) / 3.00;
                    if (avg >= 80)
                    {
                        this.BackColor = Color.Aqua;
                        this.GradeTXT.Text = "Excelent";
                        this.AvgTxt.Text = $"{avg}";
                    }
                    else if (avg > 60)
                    {
                        this.BackColor = Color.Yellow;
                        this.AvgTxt.Text = $"{avg}";
                        this.GradeTXT.Text = "Good";
                    
                    }
                    else if (avg > 40)
                    {
                        this.BackColor = Color.Pink;
                        this.GradeTXT.Text = "Satisfactory";
                        this.AvgTxt.Text = $"{avg}";
                        
                    }
                    else
                    {
                        this.BackColor = Color.Red;
                        this.GradeTXT.Text = $"Poor";
                        this.AvgTxt.Text = $"{avg}";

                    }
                }else
                {
                    MessageBox.Show("Invalied inputs!");
                    this.Teamtxt.Text = "";
                    this.Ptxt.Text = "";
                    this.Inovationtxt.Text = "";
                    
                }
            }
           
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.EIDtxt.Text = "";
            this.Nametxt.Text = "";
            this.Ptxt.Text = "";
            this.Inovationtxt.Text = "";
            this.Teamtxt.Text = "";
            this.BackColor = Color.White;
            this.GradeTXT.Text = "";
            this.AvgTxt.Text = "";
            MessageBox.Show("Cleared!");
        }
    }
}
