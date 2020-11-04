using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmail
{
    public partial class Gmail : Form
    {
        public Gmail()
        {
            InitializeComponent();
        }
       // int n = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Gmail_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(30);
            if (progressBar1.Value ==100)
            {
                Sign s = new Sign();
                s.Show();
                timer1.Stop();

            }
           

           /*if (n == 5)
            {
                timer1.Stop();
                Sign s = new Sign();
                s.Show();
            }
            n++;*/
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
