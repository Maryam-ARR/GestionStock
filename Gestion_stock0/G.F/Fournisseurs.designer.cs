namespace Gestion_stock0
{
    partial class Fournisseurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fournisseurs));
            this.ListeFournisseur = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtChercher = new System.Windows.Forms.TextBox();
            this.btnSupprimerP = new System.Windows.Forms.Button();
            this.btnModifierP = new System.Windows.Forms.Button();
            this.btnAjouterF = new System.Windows.Forms.Button();
            this.btnCommander = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListeFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // ListeFournisseur
            // 
            this.ListeFournisseur.AllowUserToAddRows = false;
            this.ListeFournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeFournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListeFournisseur.BackgroundColor = System.Drawing.Color.White;
            this.ListeFournisseur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListeFournisseur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListeFournisseur.ColumnHeadersHeight = 34;
            this.ListeFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListeFournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.nom,
            this.prenom,
            this.adresse,
            this.tele,
            this.mail});
            this.ListeFournisseur.EnableHeadersVisualStyles = false;
            this.ListeFournisseur.Location = new System.Drawing.Point(3, 47);
            this.ListeFournisseur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListeFournisseur.MultiSelect = false;
            this.ListeFournisseur.Name = "ListeFournisseur";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListeFournisseur.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListeFournisseur.RowHeadersWidth = 62;
            this.ListeFournisseur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeFournisseur.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ListeFournisseur.RowTemplate.Height = 28;
            this.ListeFournisseur.Size = new System.Drawing.Size(1297, 447);
            this.ListeFournisseur.TabIndex = 17;
            this.ListeFournisseur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeFournisseur_CellContentClick);
            this.ListeFournisseur.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeFournisseur_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "select";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 8;
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.MinimumWidth = 8;
            this.prenom.Name = "prenom";
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.MinimumWidth = 8;
            this.adresse.Name = "adresse";
            // 
            // tele
            // 
            this.tele.HeaderText = "Téléphone";
            this.tele.MinimumWidth = 8;
            this.tele.Name = "tele";
            // 
            // mail
            // 
            this.mail.HeaderText = "E-mail";
            this.mail.MinimumWidth = 8;
            this.mail.Name = "mail";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Location = new System.Drawing.Point(440, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 4);
            this.panel3.TabIndex = 13;
            // 
            // txtChercher
            // 
            this.txtChercher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChercher.BackColor = System.Drawing.SystemColors.Menu;
            this.txtChercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChercher.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtChercher.Location = new System.Drawing.Point(440, 2);
            this.txtChercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChercher.Multiline = true;
            this.txtChercher.Name = "txtChercher";
            this.txtChercher.Size = new System.Drawing.Size(357, 28);
            this.txtChercher.TabIndex = 14;
            this.txtChercher.Text = "Recherche";
            this.txtChercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChercher.Enter += new System.EventHandler(this.txtChercher_Enter);
            this.txtChercher.Leave += new System.EventHandler(this.txtChercher_Leave);
            // 
            // btnSupprimerP
            // 
            this.btnSupprimerP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSupprimerP.BackColor = System.Drawing.Color.DarkRed;
            this.btnSupprimerP.FlatAppearance.BorderSize = 0;
            this.btnSupprimerP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerP.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerP.Image")));
            this.btnSupprimerP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerP.Location = new System.Drawing.Point(692, 507);
            this.btnSupprimerP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimerP.Name = "btnSupprimerP";
            this.btnSupprimerP.Size = new System.Drawing.Size(220, 42);
            this.btnSupprimerP.TabIndex = 12;
            this.btnSupprimerP.Text = "Supprimer";
            this.btnSupprimerP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupprimerP.UseVisualStyleBackColor = false;
            this.btnSupprimerP.Click += new System.EventHandler(this.btnSupprimerP_Click);
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
            this.btnModifierP.Location = new System.Drawing.Point(352, 507);
            this.btnModifierP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifierP.Name = "btnModifierP";
            this.btnModifierP.Size = new System.Drawing.Size(211, 42);
            this.btnModifierP.TabIndex = 11;
            this.btnModifierP.Text = "Modifier";
            this.btnModifierP.UseVisualStyleBackColor = false;
            this.btnModifierP.Click += new System.EventHandler(this.btnModifierP_Click);
            // 
            // btnAjouterF
            // 
            this.btnAjouterF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjouterF.BackColor = System.Drawing.Color.DarkRed;
            this.btnAjouterF.FlatAppearance.BorderSize = 0;
            this.btnAjouterF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnAjouterF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouterF.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterF.Image")));
            this.btnAjouterF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterF.Location = new System.Drawing.Point(23, 507);
            this.btnAjouterF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouterF.Name = "btnAjouterF";
            this.btnAjouterF.Size = new System.Drawing.Size(207, 42);
            this.btnAjouterF.TabIndex = 10;
            this.btnAjouterF.Text = "Ajouter";
            this.btnAjouterF.UseVisualStyleBackColor = false;
            this.btnAjouterF.Click += new System.EventHandler(this.btnAjouterF_Click);
            // 
            // btnCommander
            // 
            this.btnCommander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommander.BackColor = System.Drawing.Color.DarkRed;
            this.btnCommander.FlatAppearance.BorderSize = 0;
            this.btnCommander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommander.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnCommander.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCommander.Image = ((System.Drawing.Image)(resources.GetObject("btnCommander.Image")));
            this.btnCommander.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommander.Location = new System.Drawing.Point(1056, 507);
            this.btnCommander.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(223, 42);
            this.btnCommander.TabIndex = 18;
            this.btnCommander.Text = "Commander";
            this.btnCommander.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCommander.UseVisualStyleBackColor = false;
            this.btnCommander.Click += new System.EventHandler(this.btnCommander_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(803, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 30);
            this.button1.TabIndex = 19;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnActualiser
            // 
            this.btnActualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualiser.Image = ((System.Drawing.Image)(resources.GetObject("btnActualiser.Image")));
            this.btnActualiser.Location = new System.Drawing.Point(3, 4);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(51, 37);
            this.btnActualiser.TabIndex = 20;
            this.btnActualiser.UseVisualStyleBackColor = false;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // Fournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.ListeFournisseur);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtChercher);
            this.Controls.Add(this.btnSupprimerP);
            this.Controls.Add(this.btnModifierP);
            this.Controls.Add(this.btnAjouterF);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fournisseurs";
            this.Size = new System.Drawing.Size(1297, 558);
            this.Load += new System.EventHandler(this.Fournisseurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListeFournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListeFournisseur;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtChercher;
        private System.Windows.Forms.Button btnSupprimerP;
        private System.Windows.Forms.Button btnModifierP;
        private System.Windows.Forms.Button btnAjouterF;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn tele;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.Button btnActualiser;
    }
}
