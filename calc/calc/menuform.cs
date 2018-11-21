using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class menuform : Form
    {
        public menuform()
        {
            InitializeComponent();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator cf = new Calculator();
            cf.Show();
            this.Hide();


        }

        private void menuform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SBar1.Value == 100)

            {
                SBar1.Value = 0;
            }
            
            SBar1.Value += 10;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (timer1.Enabled)
            {
                timer1.Stop();
            }

            else
            { 
                timer1.Start();
        }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SBar1.Value == 100)
            {
                SBar1.Value = 0;
            }
            SBar1.Value += 10;
        }
    }
}
