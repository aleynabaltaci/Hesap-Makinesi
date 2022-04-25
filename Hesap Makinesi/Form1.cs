using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double x, y;
        string işlem;

        private void Bir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

            
        }

        private void İki_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void üç_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Dört_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void beş_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void altı_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void yedi_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void dokuz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void sıfır_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void artı_Click(object sender, EventArgs e)
        {
           
            işlem = "+";
            x =Convert.ToDouble(textBox1.Text);
            textBox1.Text += "+";
            lblsonuç.Text +=textBox1.Text;
            textBox1.Text ="";
        }

        private void bölme_Click(object sender, EventArgs e)
        {
            işlem = "/";
            x = Convert.ToDouble(textBox1.Text);
            
            textBox1.Text += "/";
            lblsonuç.Text += textBox1.Text;
            textBox1.Text = "";
        }

        private void eksi_Click(object sender, EventArgs e)
        {
            işlem = "-";
            x = Convert.ToDouble(textBox1.Text);
            
            textBox1.Text += "-";
            lblsonuç.Text += textBox1.Text;
            textBox1.Text = "";
        }

        private void çarpma_Click(object sender, EventArgs e)
        {
            işlem = "*";
            x = Convert.ToDouble(textBox1.Text);
            
            textBox1.Text += "*";
            lblsonuç.Text += textBox1.Text;
            textBox1.Text = "";
        }

        private void eşittir_Click(object sender, EventArgs e)
        {
            
            y= Convert.ToDouble(textBox1.Text);
            lblsonuç.Text +=textBox1.Text;
            
            
            if (işlem=="+")
            {
                
                textBox1.Text=Convert.ToString(x+y);
            }
            else if (işlem == "-")
            {

                textBox1.Text = Convert.ToString(x - y);
            }
            else if (işlem == "/")
            {

                textBox1.Text = Convert.ToString(x / y);
            }
            else 
            {

                textBox1.Text = Convert.ToString(x * y);
            }
         

        }

        private void silme_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblsonuç.Text = "";
            x = 0;
            y = 0;
            işlem = "";
        }

        private void fibobtn_Click(object sender, EventArgs e)
        {

            Methodlarım.fibonacciM(Convert.ToInt32( textBox1.Text));

        }

        private void lblsonuç_Click(object sender, EventArgs e)
        {

        }
    }
}
