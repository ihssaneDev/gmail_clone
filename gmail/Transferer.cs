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
    public partial class Transferer : UserControl
    {
       Lesinfomsg f;
        public Transferer()
        {
            InitializeComponent();
        }

        private void benv_Click(object sender, EventArgs e)
        {
            msg me = new msg();
            me.adrexp = tde.Text;
            me.adrdes = ta.Text;
            me.objet = tobjet.Text;
            me.datemsg = DateTime.Parse(tdate.Text);
            me.supdes = false;
            me.supex = false;
            me.corps = tcontenu.Text;
            me.important = 0;
            me.important1 = 0;
            me.lu = 0;
            me.lu1 = 0;
            f.r.a.dtc.msg.InsertOnSubmit(me);
            f.r.a.dtc.SubmitChanges();
            MessageBox.Show("le message est transferer");

        }
        public Transferer(Lesinfomsg f)
        {
            InitializeComponent();
            this.f = f;
        }

       
    }
}
