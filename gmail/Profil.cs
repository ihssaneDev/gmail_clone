using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmail
{
    public partial class Profil : Form
    {
        Accueil a;
        public Profil()
        {
            InitializeComponent();

        }
        public Profil(Accueil a)
        {
            InitializeComponent();
            this.a = a;
        }
        public compte rech()
        {
            return a.dtc.compte.SingleOrDefault(c => c.email == a.t);
        }

        private void Profil_Load(object sender, EventArgs e)
        {
           compte t= rech();
           if (t != null)
           {
               byte[] i = t.img.ToArray();
               MemoryStream m = new MemoryStream(i);
               pictureBox1.Image = Image.FromStream(m);
               lemail.Text = a.t;
               lnom.Text = t.nom;
               lprenom.Text = t.prenom;
               ldn.Text=t.daten.Value.ToShortDateString();
             //  pictureBox1.Image = Image.FromStream(new MemoryStream(t.img)); 
               
           }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compte t = rech();
            if (t != null)
            {
                groupBox1.Visible = true;
                if (tmpd1.Text == t.mdps)
                    t.mdps = tmdp2.Text;
                a.dtc.SubmitChanges();
                MessageBox.Show("Votre MDP est modifier");
            }
        }
    }
}
