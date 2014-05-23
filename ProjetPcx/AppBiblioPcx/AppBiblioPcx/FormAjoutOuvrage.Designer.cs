namespace WindowsFormsApplication1
{
    partial class FormAjoutOuvrage
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label localisationLabel;
            System.Windows.Forms.Label dateCreationLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label nomEntrepriseLabel;
            this.comboBoxSuperviseur = new System.Windows.Forms.ComboBox();
            this.superviseurAjoutOuvrageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.biblioEPFCDataSet = new WindowsFormsApplication1.BiblioEPFCDataSet();
            this.splitContainerAjoutOuvrage = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxLocalisation = new System.Windows.Forms.ComboBox();
            this.localisationOuvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.sectionOuvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxEntreprise = new System.Windows.Forms.ComboBox();
            this.entrepriseOuvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.typeAjoutOuvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSuper = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelAuteur = new System.Windows.Forms.Label();
            this.listBoxAuteurs = new System.Windows.Forms.ListBox();
            this.auteurSuperviseurAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.superviseurAjoutOuvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ouvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ouvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TableAdapterManager();
            this.localisationOuvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.LocalisationOuvrageTableAdapter();
            this.sectionOuvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.SectionOuvrageTableAdapter();
            this.entrepriseOuvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.EntrepriseOuvrageTableAdapter();
            this.typeAjoutOuvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TypeAjoutOuvrageTableAdapter();
            this.superviseurAjoutOuvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.SuperviseurAjoutOuvrageTableAdapter();
            this.auteurSuperviseurAllTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.AuteurSuperviseurAllTableAdapter();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            titreLabel = new System.Windows.Forms.Label();
            localisationLabel = new System.Windows.Forms.Label();
            dateCreationLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            nomEntrepriseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.superviseurAjoutOuvrageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAjoutOuvrage)).BeginInit();
            this.splitContainerAjoutOuvrage.Panel1.SuspendLayout();
            this.splitContainerAjoutOuvrage.Panel2.SuspendLayout();
            this.splitContainerAjoutOuvrage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localisationOuvrageBindingSource)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionOuvrageBindingSource)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseOuvrageBindingSource)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeAjoutOuvrageBindingSource)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superviseurAjoutOuvrageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).BeginInit();
            this.flowLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(64, 0);
            titreLabel.Name = "titreLabel";
            titreLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            titreLabel.Size = new System.Drawing.Size(27, 13);
            titreLabel.TabIndex = 0;
            titreLabel.Text = "titre:";
            // 
            // localisationLabel
            // 
            localisationLabel.AutoSize = true;
            localisationLabel.Location = new System.Drawing.Point(22, 0);
            localisationLabel.Name = "localisationLabel";
            localisationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            localisationLabel.Size = new System.Drawing.Size(62, 13);
            localisationLabel.TabIndex = 0;
            localisationLabel.Text = "localisation:";
            // 
            // dateCreationLabel
            // 
            dateCreationLabel.AutoSize = true;
            dateCreationLabel.Location = new System.Drawing.Point(3, 0);
            dateCreationLabel.Name = "dateCreationLabel";
            dateCreationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dateCreationLabel.Size = new System.Drawing.Size(73, 13);
            dateCreationLabel.TabIndex = 0;
            dateCreationLabel.Text = "date Creation:";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(26, 0);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            sectionLabel.Size = new System.Drawing.Size(44, 13);
            sectionLabel.TabIndex = 0;
            sectionLabel.Text = "section:";
            // 
            // nomEntrepriseLabel
            // 
            nomEntrepriseLabel.AutoSize = true;
            nomEntrepriseLabel.Location = new System.Drawing.Point(4, 0);
            nomEntrepriseLabel.Name = "nomEntrepriseLabel";
            nomEntrepriseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nomEntrepriseLabel.Size = new System.Drawing.Size(80, 13);
            nomEntrepriseLabel.TabIndex = 0;
            nomEntrepriseLabel.Text = "nom Entreprise:";
            // 
            // comboBoxSuperviseur
            // 
            this.comboBoxSuperviseur.DataSource = this.superviseurAjoutOuvrageBindingSource1;
            this.comboBoxSuperviseur.DisplayMember = "NomPrenom";
            this.comboBoxSuperviseur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuperviseur.FormattingEnabled = true;
            this.comboBoxSuperviseur.Location = new System.Drawing.Point(76, 3);
            this.comboBoxSuperviseur.Name = "comboBoxSuperviseur";
            this.comboBoxSuperviseur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSuperviseur.TabIndex = 1;
            this.comboBoxSuperviseur.ValueMember = "idAuteurSuper";
            // 
            // superviseurAjoutOuvrageBindingSource1
            // 
            this.superviseurAjoutOuvrageBindingSource1.DataMember = "SuperviseurAjoutOuvrage";
            this.superviseurAjoutOuvrageBindingSource1.DataSource = this.biblioEPFCDataSet;
            // 
            // biblioEPFCDataSet
            // 
            this.biblioEPFCDataSet.DataSetName = "BiblioEPFCDataSet";
            this.biblioEPFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainerAjoutOuvrage
            // 
            this.splitContainerAjoutOuvrage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAjoutOuvrage.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAjoutOuvrage.Name = "splitContainerAjoutOuvrage";
            this.splitContainerAjoutOuvrage.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAjoutOuvrage.Panel1
            // 
            this.splitContainerAjoutOuvrage.Panel1.Controls.Add(this.flowLayoutPanel9);
            // 
            // splitContainerAjoutOuvrage.Panel2
            // 
            this.splitContainerAjoutOuvrage.Panel2.AutoScroll = true;
            this.splitContainerAjoutOuvrage.Panel2.Controls.Add(this.buttonAjouter);
            this.splitContainerAjoutOuvrage.Size = new System.Drawing.Size(439, 325);
            this.splitContainerAjoutOuvrage.SplitterDistance = 264;
            this.splitContainerAjoutOuvrage.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBoxTitre);
            this.flowLayoutPanel1.Controls.Add(titreLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 32);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Location = new System.Drawing.Point(97, 3);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitre.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.comboBoxLocalisation);
            this.flowLayoutPanel2.Controls.Add(localisationLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(209, 44);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(214, 31);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // comboBoxLocalisation
            // 
            this.comboBoxLocalisation.DataSource = this.localisationOuvrageBindingSource;
            this.comboBoxLocalisation.DisplayMember = "localisation";
            this.comboBoxLocalisation.FormattingEnabled = true;
            this.comboBoxLocalisation.Location = new System.Drawing.Point(90, 3);
            this.comboBoxLocalisation.Name = "comboBoxLocalisation";
            this.comboBoxLocalisation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocalisation.TabIndex = 1;
            this.comboBoxLocalisation.ValueMember = "localisation";
            // 
            // localisationOuvrageBindingSource
            // 
            this.localisationOuvrageBindingSource.DataMember = "LocalisationOuvrage";
            this.localisationOuvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(dateCreationLabel);
            this.flowLayoutPanel3.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 124);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 61);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.comboBoxSection);
            this.flowLayoutPanel4.Controls.Add(sectionLabel);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 44);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 32);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DataSource = this.sectionOuvrageBindingSource;
            this.comboBoxSection.DisplayMember = "section";
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(76, 3);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSection.TabIndex = 1;
            this.comboBoxSection.ValueMember = "section";
            // 
            // sectionOuvrageBindingSource
            // 
            this.sectionOuvrageBindingSource.DataMember = "SectionOuvrage";
            this.sectionOuvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.comboBoxEntreprise);
            this.flowLayoutPanel5.Controls.Add(nomEntrepriseLabel);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(209, 82);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel5.Size = new System.Drawing.Size(214, 36);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // comboBoxEntreprise
            // 
            this.comboBoxEntreprise.DataSource = this.entrepriseOuvrageBindingSource;
            this.comboBoxEntreprise.DisplayMember = "nomEntreprise";
            this.comboBoxEntreprise.FormattingEnabled = true;
            this.comboBoxEntreprise.Location = new System.Drawing.Point(90, 3);
            this.comboBoxEntreprise.Name = "comboBoxEntreprise";
            this.comboBoxEntreprise.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEntreprise.TabIndex = 1;
            this.comboBoxEntreprise.ValueMember = "nomEntreprise";
            // 
            // entrepriseOuvrageBindingSource
            // 
            this.entrepriseOuvrageBindingSource.DataMember = "EntrepriseOuvrage";
            this.entrepriseOuvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.comboBoxType);
            this.flowLayoutPanel6.Controls.Add(this.labelType);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(209, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel6.Size = new System.Drawing.Size(214, 35);
            this.flowLayoutPanel6.TabIndex = 7;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(50, 0);
            this.labelType.Name = "labelType";
            this.labelType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataSource = this.typeAjoutOuvrageBindingSource;
            this.comboBoxType.DisplayMember = "description";
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(90, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.ValueMember = "idType";
            // 
            // typeAjoutOuvrageBindingSource
            // 
            this.typeAjoutOuvrageBindingSource.DataMember = "TypeAjoutOuvrage";
            this.typeAjoutOuvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.comboBoxSuperviseur);
            this.flowLayoutPanel7.Controls.Add(this.labelSuper);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 82);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel7.Size = new System.Drawing.Size(200, 35);
            this.flowLayoutPanel7.TabIndex = 8;
            // 
            // labelSuper
            // 
            this.labelSuper.AutoSize = true;
            this.labelSuper.Location = new System.Drawing.Point(4, 0);
            this.labelSuper.Name = "labelSuper";
            this.labelSuper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSuper.Size = new System.Drawing.Size(66, 13);
            this.labelSuper.TabIndex = 0;
            this.labelSuper.Text = "Superviseur:";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.listBoxAuteurs);
            this.flowLayoutPanel8.Controls.Add(this.labelAuteur);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(209, 124);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel8.Size = new System.Drawing.Size(214, 100);
            this.flowLayoutPanel8.TabIndex = 9;
            // 
            // labelAuteur
            // 
            this.labelAuteur.AutoSize = true;
            this.labelAuteur.Location = new System.Drawing.Point(33, 0);
            this.labelAuteur.Name = "labelAuteur";
            this.labelAuteur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAuteur.Size = new System.Drawing.Size(52, 13);
            this.labelAuteur.TabIndex = 0;
            this.labelAuteur.Text = "Auteur(s):";
            // 
            // listBoxAuteurs
            // 
            this.listBoxAuteurs.DataSource = this.auteurSuperviseurAllBindingSource;
            this.listBoxAuteurs.DisplayMember = "prenomNom";
            this.listBoxAuteurs.FormattingEnabled = true;
            this.listBoxAuteurs.Location = new System.Drawing.Point(91, 3);
            this.listBoxAuteurs.Name = "listBoxAuteurs";
            this.listBoxAuteurs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAuteurs.Size = new System.Drawing.Size(120, 95);
            this.listBoxAuteurs.Sorted = true;
            this.listBoxAuteurs.TabIndex = 1;
            this.listBoxAuteurs.ValueMember = "idAuteurSuper";
            // 
            // auteurSuperviseurAllBindingSource
            // 
            this.auteurSuperviseurAllBindingSource.DataMember = "AuteurSuperviseurAll";
            this.auteurSuperviseurAllBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(172, 22);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(104, 23);
            this.buttonAjouter.TabIndex = 0;
            this.buttonAjouter.Text = "Ajouter Ouvrage";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // ouvrageBindingSource
            // 
            this.ouvrageBindingSource.DataMember = "Ouvrage";
            this.ouvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // ouvrageTableAdapter
            // 
            this.ouvrageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuteurSuperviseurAllTableAdapter = null;
            this.tableAdapterManager.AuteurSuperviseurTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ecrireTableAdapter = null;
            this.tableAdapterManager.MembreTableAdapter = null;
            this.tableAdapterManager.OuvrageTableAdapter = this.ouvrageTableAdapter;
            this.tableAdapterManager.reserverTableAdapter = null;
            this.tableAdapterManager.SuperviseurAjoutOuvrageTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // localisationOuvrageTableAdapter
            // 
            this.localisationOuvrageTableAdapter.ClearBeforeFill = true;
            // 
            // sectionOuvrageTableAdapter
            // 
            this.sectionOuvrageTableAdapter.ClearBeforeFill = true;
            // 
            // entrepriseOuvrageTableAdapter
            // 
            this.entrepriseOuvrageTableAdapter.ClearBeforeFill = true;
            // 
            // typeAjoutOuvrageTableAdapter
            // 
            this.typeAjoutOuvrageTableAdapter.ClearBeforeFill = true;
            // 
            // superviseurAjoutOuvrageTableAdapter
            // 
            this.superviseurAjoutOuvrageTableAdapter.ClearBeforeFill = true;
            // 
            // auteurSuperviseurAllTableAdapter
            // 
            this.auteurSuperviseurAllTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(439, 264);
            this.flowLayoutPanel9.TabIndex = 1;
            // 
            // FormAjoutOuvrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 325);
            this.Controls.Add(this.splitContainerAjoutOuvrage);
            this.Name = "FormAjoutOuvrage";
            this.Text = "Ajout Ouvrage";
            this.Load += new System.EventHandler(this.FormAjoutOuvrage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superviseurAjoutOuvrageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).EndInit();
            this.splitContainerAjoutOuvrage.Panel1.ResumeLayout(false);
            this.splitContainerAjoutOuvrage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAjoutOuvrage)).EndInit();
            this.splitContainerAjoutOuvrage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localisationOuvrageBindingSource)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionOuvrageBindingSource)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseOuvrageBindingSource)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeAjoutOuvrageBindingSource)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superviseurAjoutOuvrageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).EndInit();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerAjoutOuvrage;
        private BiblioEPFCDataSet biblioEPFCDataSet;
        private System.Windows.Forms.BindingSource ouvrageBindingSource;
        private BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter ouvrageTableAdapter;
        private BiblioEPFCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxLocalisation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.ComboBox comboBoxEntreprise;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label labelSuper;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label labelAuteur;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.BindingSource localisationOuvrageBindingSource;
        private BiblioEPFCDataSetTableAdapters.LocalisationOuvrageTableAdapter localisationOuvrageTableAdapter;
        private System.Windows.Forms.BindingSource sectionOuvrageBindingSource;
        private BiblioEPFCDataSetTableAdapters.SectionOuvrageTableAdapter sectionOuvrageTableAdapter;
        private System.Windows.Forms.BindingSource entrepriseOuvrageBindingSource;
        private BiblioEPFCDataSetTableAdapters.EntrepriseOuvrageTableAdapter entrepriseOuvrageTableAdapter;
        private System.Windows.Forms.BindingSource typeAjoutOuvrageBindingSource;
        private BiblioEPFCDataSetTableAdapters.TypeAjoutOuvrageTableAdapter typeAjoutOuvrageTableAdapter;
        private System.Windows.Forms.BindingSource superviseurAjoutOuvrageBindingSource;
        private BiblioEPFCDataSetTableAdapters.SuperviseurAjoutOuvrageTableAdapter superviseurAjoutOuvrageTableAdapter;
        private System.Windows.Forms.BindingSource superviseurAjoutOuvrageBindingSource1;
        private System.Windows.Forms.ComboBox comboBoxSuperviseur;
        private System.Windows.Forms.ListBox listBoxAuteurs;
        private System.Windows.Forms.BindingSource auteurSuperviseurAllBindingSource;
        private BiblioEPFCDataSetTableAdapters.AuteurSuperviseurAllTableAdapter auteurSuperviseurAllTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
    }
}