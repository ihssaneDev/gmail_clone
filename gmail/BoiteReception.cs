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
    public partial class BoiteReception : UserControl
    {
        int i;
       public Accueil a;
        int btn;
        public BoiteReception()
        {
            InitializeComponent();
        }
        public BoiteReception(int i,Accueil a,int btn)
        {
            InitializeComponent();
            this.i = i;
            this.a = a;
            this.btn=btn;
        }

        private void BoiteReception_Load(object sender, EventArgs e)
        {

        }

        private void pimp_Click(object sender, EventArgs e)
        {
            msg m = a.dtc.msg.ToList().SingleOrDefault(f => f.idm == i);
            if (m.adrexp ==a.t && m.important==1)
            {
                pimp1.Visible = true;
                pimp.Visible = false;
                m.important = 0;
                a.dtc.SubmitChanges();

                if (btn == 1)
                    a.mfav_Click(null, null);
            }
            else
                if (m.adrdes==a.t && m.important1 == 1)
            {
                pimp1.Visible = true;
                pimp.Visible = false;
                m.important1 = 0;
                a.dtc.SubmitChanges();

                if (btn == 1)
                    a.mfav_Click(null, null);
            }
            
        }

        private void pimp1_Click(object sender, EventArgs e)
        {
            msg m = a.dtc.msg.ToList().SingleOrDefault(f => f.idm == i);
            if (m.adrexp == a.t && m.important == 0)
            {
                pimp1.Visible = false;
                pimp.Visible = true;
                m.important = 1;
                a.dtc.SubmitChanges();

            }
            else
                if (m.adrdes == a.t && m.important1 == 0)
            {
                pimp1.Visible = false;
                pimp.Visible = true;
                m.important1 = 1;
                a.dtc.SubmitChanges();
            }

        }

        private void plu2_Click(object sender, EventArgs e)
        {
            msg l = a.dtc.msg.ToList().SingleOrDefault(f => f.idm == i);
            if (l.lu == 1 && l.adrexp==a.t)
            {
                pnoli.Visible = true;
                plu2.Visible = false;
                l.lu = 0;
                a.dtc.SubmitChanges(); 
            }
            else
            if (l.lu1 == 1 && l.adrdes == a.t)
            {
                pnoli.Visible = true;
                plu2.Visible = false;
                l.lu1 = 0;
                a.dtc.SubmitChanges();
            }
        }

        private void pnoli_Click(object sender, EventArgs e)
        {
            msg l = a.dtc.msg.ToList().SingleOrDefault(f => f.idm == i);

            if (l.lu == 0 && l.adrexp == a.t)
            {
                pnoli.Visible = false;
                plu2.Visible = true;
                l.lu = 1;
                a.dtc.SubmitChanges();
            }
            else
            if (l.lu1 == 0 && l.adrdes == a.t)
            {
                pnoli.Visible = false;
                plu2.Visible = true;
                l.lu1 = 1;
                a.dtc.SubmitChanges();
            }
          
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Voulez-vous vraiment supprimer le message ", "Comfirmer suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
          if (c== DialogResult.Yes)
          {
               msg l = a.dtc.msg.ToList().SingleOrDefault(f => f.idm == i);
               if (l.adrexp == a.t)
               {

                   if (l.supdes == true)
                   {
                       a.dtc.msg.DeleteOnSubmit(l);
                       a.dtc.SubmitChanges();
                   }
                   else
                   {
                       l.supex = true;
                       a.dtc.SubmitChanges();
                   }
               }
               else
               {
                   if (l.supex == true)
                   {
                       a.dtc.msg.DeleteOnSubmit(l);
                       a.dtc.SubmitChanges();
                   }
                   else
                   {
                       l.supdes = true;
                       a.dtc.SubmitChanges();
                   }
               }
              if (btn == 0)
                  a.bre_Click(null, null);
              else
                  if (btn == 2)
                      a.ben_Click(null, null);
                  else
                      a.mfav_Click(null, null);
          }
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            
                msg l = a.dtc.msg.ToList().SingleOrDefault(f => f.idm == i);
                a.panel2.Controls.Clear();
                Lesinfomsg fes = new Lesinfomsg(this);
                fes.lobj.Text = l.objet;
                fes.ldate.Text = l.datemsg.Value.ToShortDateString();
                fes.lcon.Text = l.corps;
                fes.lde.Text = l.adrexp;
                fes.la.Text = l.adrdes;
                
                if (l.img != null)
                {
                    fes.pictureBox1.Visible = true;
                    byte[] i = l.img.ToArray();
                    fes.pictureBox1.Image = Image.FromStream(new MemoryStream(i));
                }
                else
                    fes.pictureBox1.Visible = false;
                a.panel2.Controls.Add(fes);
                pnoli_Click(null, null);
        }   
    }
}
