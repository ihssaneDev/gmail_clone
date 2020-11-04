using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace gmail
{
    public partial class Nouveaumsg : UserControl
    {
        DataClasses1DataContext d = new DataClasses1DataContext();
        string t;
        string chemin = "";
        public Nouveaumsg()
        {
            InitializeComponent();
        }

        public Nouveaumsg(string t)
        {
            InitializeComponent();
            this.t = t;
        }
        private void b_Send_Click(object sender, EventArgs e)
        {
            msg m=new msg();
            m.adrexp = t;
            m.adrdes = tdes.Text;
            m.important=0;
            m.important1 = 0;
            m.objet = tobjet.Text;
            m.corps= tcontenu.Text;
            m.supdes = false;
            m.supex = false;
            m.datemsg = DateTime.Now;
            m.lu = 0;
            m.lu1 = 0;
            if (chemin != "")
            {
                byte[] i = File.ReadAllBytes(chemin);
                m.img = i;
            }

            d.msg.InsertOnSubmit(m);
            d.SubmitChanges();
            MessageBox.Show("Message envoyer avec succes");  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            chemin = openFileDialog1.FileName;
            pictureBox2.Image = Image.FromFile(chemin);
        }

    }
}
