namespace gmail
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mnv = new System.Windows.Forms.Button();
            this.bre = new System.Windows.Forms.Button();
            this.mfav = new System.Windows.Forms.Button();
            this.ben = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(87, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 297);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 165);
            this.label1.TabIndex = 0;
            this.label1.Text = "G\r\nM\r\nA\r\nI\r\nL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // mnv
            // 
            this.mnv.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnv.Image = global::gmail.Properties.Resources.icons8_New_Message_50px_1;
            this.mnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnv.Location = new System.Drawing.Point(9, 10);
            this.mnv.Name = "mnv";
            this.mnv.Size = new System.Drawing.Size(135, 34);
            this.mnv.TabIndex = 20;
            this.mnv.Text = "Nouveau message";
            this.mnv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnv.UseVisualStyleBackColor = true;
            this.mnv.Click += new System.EventHandler(this.mnv_Click);
            // 
            // bre
            // 
            this.bre.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bre.Image = global::gmail.Properties.Resources.icons8_Inbox_50px;
            this.bre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bre.Location = new System.Drawing.Point(156, 10);
            this.bre.Name = "bre";
            this.bre.Size = new System.Drawing.Size(135, 34);
            this.bre.TabIndex = 19;
            this.bre.Text = "Boite de réception";
            this.bre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bre.UseVisualStyleBackColor = true;
            this.bre.Click += new System.EventHandler(this.bre_Click);
            // 
            // mfav
            // 
            this.mfav.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfav.Image = global::gmail.Properties.Resources.icons8_Love_52px;
            this.mfav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mfav.Location = new System.Drawing.Point(460, 10);
            this.mfav.Name = "mfav";
            this.mfav.Size = new System.Drawing.Size(135, 34);
            this.mfav.TabIndex = 21;
            this.mfav.Text = "Messages favoris";
            this.mfav.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mfav.UseVisualStyleBackColor = true;
            this.mfav.Click += new System.EventHandler(this.mfav_Click);
            // 
            // ben
            // 
            this.ben.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ben.Image = global::gmail.Properties.Resources.icons8_Sent_52px_1;
            this.ben.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ben.Location = new System.Drawing.Point(306, 10);
            this.ben.Name = "ben";
            this.ben.Size = new System.Drawing.Size(135, 34);
            this.ben.TabIndex = 22;
            this.ben.Text = "Messages envoyes";
            this.ben.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ben.UseVisualStyleBackColor = true;
            this.ben.Click += new System.EventHandler(this.ben_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gmail.Properties.Resources.Exit_Sign_52px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mnv);
            this.Controls.Add(this.bre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mfav);
            this.Controls.Add(this.ben);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ben;
        private System.Windows.Forms.Button mnv;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button bre;
        public System.Windows.Forms.Button mfav;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}