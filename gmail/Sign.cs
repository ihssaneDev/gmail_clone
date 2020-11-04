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
    public partial class Sign : Form
    {
       public  string m;
       inscription i;
        public  DataClasses1DataContext d = new DataClasses1DataContext();
        public Sign()
        {
            InitializeComponent();
            tmdp.UseSystemPasswordChar = true;
        }
        public Sign(inscription i)
        {
            InitializeComponent();
            this.i = i;
            temail.Text = i.temail.Text;
            tmdp.Text = i.tmdp1.Text;
            tmdp.UseSystemPasswordChar = true;
        }

        private void Sign_Load(object sender, EventArgs e)
        {

        }

        private void insc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inscription i = new inscription();
            i.Show();
        }
        public compte reche()
        {

            return d.compte.SingleOrDefault(c => c.email == temail.Text);
        }
        

        private void bcon_Click(object sender, EventArgs e)
        {
            
            compte a = reche();
            if (a != null && tmdp.Text == a.mdps)
            {
                m = temail.Text;
                // MessageBox.Show("Bienvenue");
                temail.Clear();
                tmdp.Clear();
                Accueil at = new Accueil(m);
                at.ShowDialog();
            }
            else if (a != null && a.mdps != tmdp.Text)
                MessageBox.Show("mot de pass incorrect");
            else 
                MessageBox.Show("Ce compte n'existe pas");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                tmdp.UseSystemPasswordChar = false;
            else
                tmdp.UseSystemPasswordChar = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public compte rech()
        {
            return d.compte.SingleOrDefault(a => a.email == temail.Text);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            compte c =rech();
            if (c != null)
            {
                mdpoublie s = new mdpoublie(this);
                s.ShowDialog();
            }
            else
                MessageBox.Show("Ce compte n'existe pas");  
        }

        
    }
}
