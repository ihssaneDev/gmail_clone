using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmail
{
    public partial class inscription : Form
    {
  
        DataClasses1DataContext d = new DataClasses1DataContext();
        string chemin = "";
        public inscription()
        {
            InitializeComponent();
            tmdp1.UseSystemPasswordChar = true;
            tmdp2.UseSystemPasswordChar = true;
            cmbqs.SelectedIndex = 0;
            csexe.SelectedIndex = 0;
        }
        public compte reche()
        {
            return d.compte.SingleOrDefault(c => c.email == temail.Text);
        }

        private void bcon_Click(object sender, EventArgs e)
        {

            if (chemin != "")
            {
               byte[]  i = File.ReadAllBytes(chemin);
                compte c = new compte();
                c.nom = tnom.Text;
                c.prenom = tprenom.Text;
                c.daten = daten.Value;
                c.email = temail.Text;
                c.mdps = tmdp1.Text;
                c.sexe = csexe.Text;
                c.qs = cmbqs.Text;
                c.qr = trep.Text;
                c.img = i;
                if (reche() != null)
                {
                    MessageBox.Show("Email est deja existe");
                    temail.ForeColor = Color.Red;
                }
                else
                    if (tmdp1.ForeColor != Color.Black || temail.ForeColor != Color.Black)
                        MessageBox.Show("données invalide");
                    else if (tmdp1.Text != tmdp2.Text)
                    {
                        tmdp2.ForeColor = Color.Red;
                        MessageBox.Show("Mot de pass de confirmation  est incorrecte");
                        tmdp2.Clear();
                    }
                    else if (string.IsNullOrWhiteSpace(tnom.Text) || string.IsNullOrWhiteSpace(tprenom.Text) ||
                        string.IsNullOrWhiteSpace(csexe.Text) || string.IsNullOrWhiteSpace(cmbqs.Text)
                        || string.IsNullOrWhiteSpace(trep.Text) || string.IsNullOrWhiteSpace(daten.Text)
                        || chemin=="")
                        MessageBox.Show("Les informations ne sont pas complets");

                    else
                    {
                        d.compte.InsertOnSubmit(c);
                        d.SubmitChanges();
                        tmdp2.ForeColor = Color.Black;
                        temail.ForeColor = Color.Black;
                        Sign s = new Sign(this);

                        s.ShowDialog();

                    }

            }
        }

        private void temail_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^([\w-_\.])+@(\w)+\.(\w){2,3}$");
            if (!r.IsMatch(temail.Text))
            {
                temail.ForeColor = Color.Red;
                MessageBox.Show("email invalide");
            }
            else
            {
                temail.ForeColor = Color.Black;
            }
        }

        private void tmdp1_Validating(object sender, CancelEventArgs e)
        {
            if (tmdp1.Text.Length < 2)
            {
                tmdp1.ForeColor = Color.Red;
                MessageBox.Show("mot de passe doit etre au minimum 9 caractères");

            }
            else
                tmdp1.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                tmdp1.UseSystemPasswordChar = false;
                tmdp2.UseSystemPasswordChar = false;
            }
            else
            {
                tmdp1.UseSystemPasswordChar = true;
                tmdp2.UseSystemPasswordChar = true; 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            chemin = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(chemin);
        }
    }
}
