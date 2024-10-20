using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MangInasal
{
    public partial class Form5 : Form
    {
        public static Form5 instance;

        public Form5()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(a<2)
            {
                quantity.Text = 0.ToString();
            }
            else
            {
                a--;
                quantity.Text = a.ToString();
            }
        }
        private int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            quantity.Text = a.ToString();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {


            int pprice = Convert.ToInt32(price.Text);
            int total = pprice + pprice;
      
            int p = a * pprice;
            Form4.instance.lbl2.Text = p.ToString();
            Form4.instance.lbl1.Text = a.ToString();
    
            this.Hide();
        }

        private void pprice_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productname_Click(object sender, EventArgs e)
        {

        }
    }
}
