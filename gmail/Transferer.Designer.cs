namespace gmail
{
    partial class Transferer
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcontenu = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tde = new System.Windows.Forms.TextBox();
            this.tobjet = new System.Windows.Forms.TextBox();
            this.tdate = new System.Windows.Forms.TextBox();
            this.ta = new System.Windows.Forms.TextBox();
            this.benv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcontenu
            // 
            this.tcontenu.Location = new System.Drawing.Point(158, 165);
            this.tcontenu.Name = "tcontenu";
            this.tcontenu.ReadOnly = true;
            this.tcontenu.Size = new System.Drawing.Size(293, 96);
            this.tcontenu.TabIndex = 43;
            this.tcontenu.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Date message :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "De :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Contenu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Objet : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "à : ";
            // 
            // tde
            // 
            this.tde.Location = new System.Drawing.Point(231, 14);
            this.tde.Name = "tde";
            this.tde.ReadOnly = true;
            this.tde.Size = new System.Drawing.Size(220, 20);
            this.tde.TabIndex = 44;
            // 
            // tobjet
            // 
            this.tobjet.Location = new System.Drawing.Point(231, 64);
            this.tobjet.Name = "tobjet";
            this.tobjet.ReadOnly = true;
            this.tobjet.Size = new System.Drawing.Size(220, 20);
            this.tobjet.TabIndex = 45;
            // 
            // tdate
            // 
            this.tdate.Location = new System.Drawing.Point(259, 101);
            this.tdate.Name = "tdate";
            this.tdate.ReadOnly = true;
            this.tdate.Size = new System.Drawing.Size(192, 20);
            this.tdate.TabIndex = 46;
            // 
            // ta
            // 
            this.ta.Location = new System.Drawing.Point(231, 40);
            this.ta.Name = "ta";
            this.ta.Size = new System.Drawing.Size(220, 20);
            this.ta.TabIndex = 47;
            // 
            // benv
            // 
            this.benv.Location = new System.Drawing.Point(376, 267);
            this.benv.Name = "benv";
            this.benv.Size = new System.Drawing.Size(75, 23);
            this.benv.TabIndex = 48;
            this.benv.Text = "Envoyer";
            this.benv.UseVisualStyleBackColor = true;
            this.benv.Click += new System.EventHandler(this.benv_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gmail.Properties.Resources.images25;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // Transferer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.benv);
            this.Controls.Add(this.ta);
            this.Controls.Add(this.tdate);
            this.Controls.Add(this.tobjet);
            this.Controls.Add(this.tde);
            this.Controls.Add(this.tcontenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transferer";
            this.Size = new System.Drawing.Size(488, 294);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox tcontenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tde;
        public System.Windows.Forms.TextBox tobjet;
        public System.Windows.Forms.TextBox tdate;
        public System.Windows.Forms.TextBox ta;
        private System.Windows.Forms.Button benv;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
