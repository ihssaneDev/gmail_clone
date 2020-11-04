using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gmail
{
    public partial class Accueil : Form
    {
        public  DataClasses1DataContext dtc = new DataClasses1DataContext();
       public string t;
        int btn;
        public Accueil()
        {
            InitializeComponent();
        }

        public compte rech()
        {
            return dtc.compte.SingleOrDefault(c => c.email == t);
        }
        /*sign=>accueil*/
        public Accueil(string t)
        {
            InitializeComponent();
            this.t = t;
           
            

        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            compte te = rech();
            if (te != null)
            {
                byte[] i = te.img.ToArray();
                pictureBox2.Image = Image.FromStream(new MemoryStream(i));
            }

        }

        public static void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        public  void bre_Click(object sender, EventArgs e)
        {
                btn = 0;
                panel2.Controls.Clear();
                foreach (msg i in dtc.msg.ToList().Where(w => w.supdes == false
                    /*&& ((w.important1 == 1 && w.adrdes == t) ||
                    (w.important1 == 0 && w.adrdes == t))
                    && ((w.lu1 == 1 && w.adrdes == t) ||
                    (w.lu1 == 0 && w.adrdes == t))*/))
                {
                    if (i.adrdes == t)
                    {
                        BoiteReception b = new BoiteReception(i.idm, this, btn);
                        b.lcmpdes.Text = i.adrexp;
                        b.lobjet.Text = i.objet;
                        b.ldatemsg.Text = i.datemsg.Value.ToShortDateString();
                        if (i.important1 == 1 && i.adrdes == t)
                        {
                            b.pimp1.Visible = false;
                        }
                        else
                        {
                            b.pimp.Visible = true;
                        }
                        if (i.lu1 == 0)
                        {
                            b.plu2.Visible = false;
                        }
                        else
                        {
                            b.pnoli.Visible = true;
                        }
                        b.Top = b.Height * panel2.Controls.Count;
                        panel2.Controls.Add(b);

                    }

                }
            
            

        }

        private void mnv_Click(object sender, EventArgs e)
        {
            Nouveaumsg n = new Nouveaumsg(t);
            panel2.Controls.Clear();
            panel2.Controls.Add(n);

        }

        public void ben_Click(object sender, EventArgs e)
        {
            btn = 2;
            panel2.Controls.Clear();
            foreach (msg i in dtc.msg.ToList().Where(w => w.supex == false /*&& ((w.important == 1 && w.adrexp == t)
                || (w.important == 0 && w.adrexp == t)) && ((w.lu == 1 && w.adrexp == t)
                || (w.lu == 0 && w.adrexp == t))*/))
            {
                if (i.adrexp == t)
                {
                    BoiteReception b = new BoiteReception(i.idm, this, btn);
 
                    b.lcmpdes.Text = i.adrdes;
                    b.lobjet.Text = i.objet;
                    b.ldatemsg.Text = i.datemsg.Value.ToShortDateString();
                    if (i.important == 1 )
                    {
                        b.pimp1.Visible = false;
                    }
                    else
                        b.pimp.Visible = true;
                    if (i.lu == 0)
                        b.plu2.Visible = false;
                    else
                        b.pnoli.Visible = true;
                    b.Top = b.Height * panel2.Controls.Count;
                    panel2.Controls.Add(b);

                }

            }
        }

        public void mfav_Click(object sender, EventArgs e)
        {
            btn = 1;           
                panel2.Controls.Clear();
                foreach (msg i in dtc.msg.ToList().Where(w=> (w.supex==false || w.supdes==false) ))
                {
                    if((i.important==1 && i.adrexp==t) || (i.important1==1 && i.adrdes == t) )
                    //if ((i.adrdes == t || i.adrexp == t) && i.important == 1)
                    {

                        BoiteReception c = new BoiteReception(i.idm, this, btn);
                        if (i.adrexp == t)

                            c.lcmpdes.Text = i.adrdes;
                        else
                            c.lcmpdes.Text = i.adrexp;
                        c.lobjet.Text = i.objet;
                        c.ldatemsg.Text = i.datemsg.Value.ToShortDateString();
                        if (i.important == 1 ||i.important1==1)
                        {
                            c.pimp1.Visible = false;
                        }

                        if ((i.lu == 0 && i.adrexp == t) || (i.lu1 == 0 && i.adrdes==t))
                        
                            c.plu2.Visible = false;
                        
                        else
                            c.pnoli.Visible = true;
                        c.Top = c.Height * panel2.Controls.Count;
                        panel2.Controls.Add(c);

                    }

                }

            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            Profil p = new Profil(this);
            p.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
     }
}
