using System;
using System.Windows.Forms;

namespace Gestion_stock0
{
    partial class ProduitD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProduitD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAjouterP = new System.Windows.Forms.Button();
            this.btnModifierP = new System.Windows.Forms.Button();
            this.btnSupprimerP = new System.Windows.Forms.Button();
            this.txtChercher = new System.Windows.Forms.TextBox();
            this.btnChercher = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListeProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListe = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListeProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouterP
            // 
            this.btnAjouterP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjouterP.BackColor = System.Drawing.Color.DarkRed;
            this.btnAjouterP.FlatAppearance.BorderSize = 0;
            this.btnAjouterP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnAjouterP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouterP.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterP.Image")));
            this.btnAjouterP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterP.Location = new System.Drawing.Point(99, 623);
            this.btnAjouterP.Name = "btnAjouterP";
            this.btnAjouterP.Size = new System.Drawing.Size(183, 54);
            this.btnAjouterP.TabIndex = 0;
            this.btnAjouterP.Text = "Ajouter";
            this.btnAjouterP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouterP.UseVisualStyleBackColor = false;
            this.btnAjouterP.Click += new System.EventHandler(this.btnAjouterP_Click);
            // 
            // btnModifierP
            // 
            this.btnModifierP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModifierP.BackColor = System.Drawing.Color.DarkRed;
            this.btnModifierP.FlatAppearance.BorderSize = 0;
            this.btnModifierP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnModifierP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifierP.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierP.Image")));
            this.btnModifierP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifierP.Location = new System.Drawing.Point(488, 623);
            this.btnModifierP.Name = "btnModifierP";
            this.btnModifierP.Size = new System.Drawing.Size(220, 54);
            this.btnModifierP.TabIndex = 1;
            this.btnModifierP.Text = "Modifier";
            this.btnModifierP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifierP.UseVisualStyleBackColor = false;
            this.btnModifierP.Click += new System.EventHandler(this.btnModifierP_Click);
            // 
            // btnSupprimerP
            // 
            this.btnSupprimerP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerP.BackColor = System.Drawing.Color.DarkRed;
            this.btnSupprimerP.FlatAppearance.BorderSize = 0;
            this.btnSupprimerP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerP.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerP.Image")));
            this.btnSupprimerP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerP.Location = new System.Drawing.Point(896, 623);
            this.btnSupprimerP.Name = "btnSupprimerP";
            this.btnSupprimerP.Size = new System.Drawing.Size(225, 54);
            this.btnSupprimerP.TabIndex = 2;
            this.btnSupprimerP.Text = "Supprimer";
            this.btnSupprimerP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimerP.UseVisualStyleBackColor = false;
            this.btnSupprimerP.Click += new System.EventHandler(this.btnSupprimerP_Click);
            // 
            // txtChercher
            // 
            this.txtChercher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChercher.BackColor = System.Drawing.SystemColors.Menu;
            this.txtChercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChercher.Font = new System.Drawing.Font("Arial Unicode MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChercher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChercher.Location = new System.Drawing.Point(758, 11);
            this.txtChercher.Multiline = true;
            this.txtChercher.Name = "txtChercher";
            this.txtChercher.Size = new System.Drawing.Size(400, 38);
            this.txtChercher.TabIndex = 5;
            this.txtChercher.Text = "Recherche";
            this.txtChercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChercher.Enter += new System.EventHandler(this.txtChercher_Enter);
            this.txtChercher.Leave += new System.EventHandler(this.txtChercher_Leave);
            // 
            // btnChercher
            // 
            this.btnChercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChercher.FlatAppearance.BorderSize = 0;
            this.btnChercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnChercher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChercher.Image = ((System.Drawing.Image)(resources.GetObject("btnChercher.Image")));
            this.btnChercher.Location = new System.Drawing.Point(1165, 11);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(44, 38);
            this.btnChercher.TabIndex = 6;
            this.btnChercher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChercher.UseVisualStyleBackColor = false;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Location = new System.Drawing.Point(758, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 5);
            this.panel3.TabIndex = 5;
            // 
            // ListeProduit
            // 
            this.ListeProduit.AllowUserToAddRows = false;
            this.ListeProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListeProduit.BackgroundColor = System.Drawing.Color.White;
            this.ListeProduit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListeProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListeProduit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListeProduit.ColumnHeadersHeight = 55;
            this.ListeProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListeProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idProduit,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.quantite,
            this.Column5});
            this.ListeProduit.EnableHeadersVisualStyles = false;
            this.ListeProduit.Location = new System.Drawing.Point(0, 66);
            this.ListeProduit.MultiSelect = false;
            this.ListeProduit.Name = "ListeProduit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListeProduit.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListeProduit.RowHeadersWidth = 62;
            this.ListeProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeProduit.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ListeProduit.RowTemplate.Height = 28;
            this.ListeProduit.Size = new System.Drawing.Size(1454, 540);
            this.ListeProduit.TabIndex = 7;
            this.ListeProduit.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeProduit_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selectionner";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // idProduit
            // 
            this.idProduit.HeaderText = "Id";
            this.idProduit.MinimumWidth = 8;
            this.idProduit.Name = "idProduit";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prix";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date d\'expiration";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fournisseur";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantité";
            this.quantite.MinimumWidth = 8;
            this.quantite.Name = "quantite";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "statut";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 25;
            this.comboBox1.Items.AddRange(new object[] {
            "Liste des produits disponible",
            "Liste des produits non disponible",
            "Liste des produits déstockés"});
            this.comboBox1.Location = new System.Drawing.Point(256, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(404, 33);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Veuillez choisir une liste à afficher";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(256, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 5);
            this.panel1.TabIndex = 6;
            // 
            // btnListe
            // 
            this.btnListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListe.FlatAppearance.BorderSize = 0;
            this.btnListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnListe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListe.Image = ((System.Drawing.Image)(resources.GetObject("btnListe.Image")));
            this.btnListe.Location = new System.Drawing.Point(664, 13);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(44, 37);
            this.btnListe.TabIndex = 9;
            this.btnListe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListe.UseVisualStyleBackColor = false;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Image = ((System.Drawing.Image)(resources.GetObject("btnActualiser.Image")));
            this.btnActualiser.Location = new System.Drawing.Point(1385, 623);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(50, 43);
            this.btnActualiser.TabIndex = 12;
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // ProduitD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ListeProduit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.txtChercher);
            this.Controls.Add(this.btnSupprimerP);
            this.Controls.Add(this.btnModifierP);
            this.Controls.Add(this.btnAjouterP);
            this.Name = "ProduitD";
            this.Size = new System.Drawing.Size(1454, 691);
            this.Load += new System.EventHandler(this.ProduitD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListeProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   

       

      
       

        #endregion

        private System.Windows.Forms.Button btnAjouterP;
        private System.Windows.Forms.Button btnModifierP;
        private System.Windows.Forms.Button btnSupprimerP;
        private System.Windows.Forms.TextBox txtChercher;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ListeProduit;
        private System.Windows.Forms.ComboBox comboBox1;
       
        private System.Windows.Forms.Panel panel1;
        private Button btnListe;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn idProduit;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn quantite;
        private DataGridViewTextBoxColumn Column5;
        private Button btnActualiser;
    }
}
