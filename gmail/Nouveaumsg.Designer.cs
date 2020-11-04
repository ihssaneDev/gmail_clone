namespace gmail
{
    partial class Nouveaumsg
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
            this.tobjet = new System.Windows.Forms.TextBox();
            this.tdes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_Send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcontenu
            // 
            this.tcontenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcontenu.Location = new System.Drawing.Point(29, 86);
            this.tcontenu.Name = "tcontenu";
            this.tcontenu.Size = new System.Drawing.Size(390, 118);
            this.tcontenu.TabIndex = 15;
            this.tcontenu.Text = "";
            // 
            // tobjet
            // 
            this.tobjet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tobjet.Location = new System.Drawing.Point(60, 32);
            this.tobjet.Name = "tobjet";
            this.tobjet.Size = new System.Drawing.Size(359, 20);
            this.tobjet.TabIndex = 14;
            // 
            // tdes
            // 
            this.tdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tdes.Location = new System.Drawing.Point(60, 4);
            this.tdes.Name = "tdes";
            this.tdes.Size = new System.Drawing.Size(359, 20);
            this.tdes.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contenu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Objet : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "à : ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(69, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gmail.Properties.Resources.icons8_Attach_50px1;
            this.pictureBox1.Location = new System.Drawing.Point(187, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // b_Send
            // 
            this.b_Send.Image = global::gmail.Properties.Resources.icons8_Sent_48px;
            this.b_Send.Location = new System.Drawing.Point(380, 209);
            this.b_Send.Name = "b_Send";
            this.b_Send.Size = new System.Drawing.Size(39, 33);
            this.b_Send.TabIndex = 16;
            this.b_Send.UseVisualStyleBackColor = true;
            this.b_Send.Click += new System.EventHandler(this.b_Send_Click);
            // 
            // Nouveaumsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_Send);
            this.Controls.Add(this.tcontenu);
            this.Controls.Add(this.tobjet);
            this.Controls.Add(this.tdes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nouveaumsg";
            this.Size = new System.Drawing.Size(451, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Send;
        private System.Windows.Forms.RichTextBox tcontenu;
        private System.Windows.Forms.TextBox tobjet;
        private System.Windows.Forms.TextBox tdes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
