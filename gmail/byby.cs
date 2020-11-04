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
    public partial class byby : Form
    {
        public byby()
        {
            InitializeComponent();
        }
        int n;
        private void byby_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n == 2)
            {
                timer1.Stop();
                Application.Exit();
            }
            n++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}
