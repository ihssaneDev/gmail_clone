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
    public partial class mdpoublie : Form
    {
        Sign s;
        public mdpoublie()
        {
            InitializeComponent();
          


        }
        public mdpoublie(Sign s)
        {
            InitializeComponent();
            this.s = s;
            tmdp.UseSystemPasswordChar = true;
            tmdp1.UseSystemPasswordChar = true;
        }
        public compte rech()
        {
            return s.d.compte.SingleOrDefault(a => a.email == s.temail.Text);
        }
        private void mdpoublie_Load(object sender, EventArgs e)
        {
            compte c = rech();
            qs.Text = c.qs;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            compte c = rech();
            if (c.qr == textBox1.Text)
              groupBox1.Visible = true; 
            else
                MessageBox.Show("Votre reponse est incorrecte");
          
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            compte c = rech();
            if (tmdp.Text == tmdp1.Text)
            {
                c.mdps = tmdp.Text;
                s.d.SubmitChanges();
                MessageBox.Show("Vote MDP est modifier");
                
            }

            else
                MessageBox.Show("Mot de pass de confirmation  est incorrecte");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tmdp.UseSystemPasswordChar = false;
                tmdp1.UseSystemPasswordChar = false;
            }
            else
            {
                tmdp.UseSystemPasswordChar = true;
                tmdp1.UseSystemPasswordChar = true;
            }
        }
    }
}
