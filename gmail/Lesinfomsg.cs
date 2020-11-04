using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmail
{
    public partial class Lesinfomsg : UserControl
    {

        public BoiteReception r;
        public Lesinfomsg()
        {
            InitializeComponent();
        }
        public Lesinfomsg(BoiteReception r)
        {
            InitializeComponent();
            this.r = r;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            r.a.panel2.Controls.Clear();
            Transferer t = new Transferer(this);
            t.tde.Text = r.a.t;
            t.tobjet.Text = lobj.Text;
            t.tdate.Text = ldate.Text;
            t.tcontenu.Text = lcon.Text;
            r.a.panel2.Controls.Add(t);
        }

        private void b_Send_Click(object sender, EventArgs e)
        {
        }
       
       
    }
}
