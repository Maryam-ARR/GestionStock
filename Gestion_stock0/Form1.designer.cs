namespace Gestion_stock0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnImpression = new System.Windows.Forms.Button();
            this.btnGFournisseurs = new System.Windows.Forms.Button();
            this.btnGVentes = new System.Windows.Forms.Button();
            this.btnGProduit = new System.Windows.Forms.Button();
            this.btnStatics = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnImpression);
            this.panel1.Controls.Add(this.btnGFournisseurs);
            this.panel1.Controls.Add(this.btnGVentes);
            this.panel1.Controls.Add(this.btnGProduit);
            this.panel1.Controls.Add(this.btnStatics);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 514);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(5)))), ((int)(((byte)(3)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 103);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 56);
            this.SidePanel.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnImpression
            // 
            this.btnImpression.FlatAppearance.BorderSize = 0;
            this.btnImpression.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpression.ForeColor = System.Drawing.Color.White;
            this.btnImpression.Image = ((System.Drawing.Image)(resources.GetObject("btnImpression.Image")));
            this.btnImpression.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpression.Location = new System.Drawing.Point(12, 348);
            this.btnImpression.Name = "btnImpression";
            this.btnImpression.Size = new System.Drawing.Size(164, 51);
            this.btnImpression.TabIndex = 6;
            this.btnImpression.Text = "  Impression du log journalier";
            this.btnImpression.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImpression.UseVisualStyleBackColor = true;
            this.btnImpression.Click += new System.EventHandler(this.btnImpression_Click);
            // 
            // btnGFournisseurs
            // 
            this.btnGFournisseurs.FlatAppearance.BorderSize = 0;
            this.btnGFournisseurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGFournisseurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGFournisseurs.ForeColor = System.Drawing.Color.White;
            this.btnGFournisseurs.Image = ((System.Drawing.Image)(resources.GetObject("btnGFournisseurs.Image")));
            this.btnGFournisseurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGFournisseurs.Location = new System.Drawing.Point(12, 291);
            this.btnGFournisseurs.Name = "btnGFournisseurs";
            this.btnGFournisseurs.Size = new System.Drawing.Size(164, 51);
            this.btnGFournisseurs.TabIndex = 5;
            this.btnGFournisseurs.Text = "  Gestion Fournisseurs";
            this.btnGFournisseurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGFournisseurs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGFournisseurs.UseVisualStyleBackColor = true;
            this.btnGFournisseurs.Click += new System.EventHandler(this.btnGFournisseurs_Click);
            // 
            // btnGVentes
            // 
            this.btnGVentes.FlatAppearance.BorderSize = 0;
            this.btnGVentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGVentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGVentes.ForeColor = System.Drawing.Color.White;
            this.btnGVentes.Image = ((System.Drawing.Image)(resources.GetObject("btnGVentes.Image")));
            this.btnGVentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGVentes.Location = new System.Drawing.Point(12, 234);
            this.btnGVentes.Name = "btnGVentes";
            this.btnGVentes.Size = new System.Drawing.Size(164, 51);
            this.btnGVentes.TabIndex = 4;
            this.btnGVentes.Text = "  Gestion Ventes";
            this.btnGVentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGVentes.UseVisualStyleBackColor = true;
            this.btnGVentes.Click += new System.EventHandler(this.btnGVentes_Click);
            // 
            // btnGProduit
            // 
            this.btnGProduit.FlatAppearance.BorderSize = 0;
            this.btnGProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGProduit.ForeColor = System.Drawing.Color.White;
            this.btnGProduit.Image = ((System.Drawing.Image)(resources.GetObject("btnGProduit.Image")));
            this.btnGProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGProduit.Location = new System.Drawing.Point(12, 165);
            this.btnGProduit.Name = "btnGProduit";
            this.btnGProduit.Size = new System.Drawing.Size(164, 63);
            this.btnGProduit.TabIndex = 3;
            this.btnGProduit.Text = "  Gestion Produits";
            this.btnGProduit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGProduit.UseVisualStyleBackColor = true;
            this.btnGProduit.Click += new System.EventHandler(this.btnGProduit_Click);
            // 
            // btnStatics
            // 
            this.btnStatics.FlatAppearance.BorderSize = 0;
            this.btnStatics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatics.ForeColor = System.Drawing.Color.White;
            this.btnStatics.Image = ((System.Drawing.Image)(resources.GetObject("btnStatics.Image")));
            this.btnStatics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatics.Location = new System.Drawing.Point(12, 103);
            this.btnStatics.Name = "btnStatics";
            this.btnStatics.Size = new System.Drawing.Size(164, 56);
            this.btnStatics.TabIndex = 2;
            this.btnStatics.Text = "  Statistics";
            this.btnStatics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatics.UseVisualStyleBackColor = true;
            this.btnStatics.Click += new System.EventHandler(this.btnStatics_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-324, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 11);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(-322, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 11);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(5)))), ((int)(((byte)(3)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(181, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(980, 13);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(217, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 0);
            this.panel5.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1133, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(181, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(979, 479);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1100, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 514);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnImpression;
        private System.Windows.Forms.Button btnGFournisseurs;
        private System.Windows.Forms.Button btnGVentes;
        private System.Windows.Forms.Button btnGProduit;
        private System.Windows.Forms.Button btnStatics;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Panel panel6;
    }
}

