namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.Label idOuvrageLabel;
            System.Windows.Forms.Label titreLabel;
            System.Windows.Forms.Label localisationLabel;
            System.Windows.Forms.Label dateCreationLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label dateEmpruntLabel;
            System.Windows.Forms.Label dureeEmpruntLabel;
            System.Windows.Forms.Label numTypeLabel;
            System.Windows.Forms.Label numMembreLabel;
            System.Windows.Forms.Label nomEntrepriseLabel;
            System.Windows.Forms.Label numSuperLabel;
            this.splitContainerGlobal = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonType = new System.Windows.Forms.RadioButton();
            this.radioButtonMembre = new System.Windows.Forms.RadioButton();
            this.radioButtonOuvrage = new System.Windows.Forms.RadioButton();
            this.radioButtonAuteurSuperviseur = new System.Windows.Forms.RadioButton();
            this.auteurSuperviseurDataGridView = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOuvrageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOuvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioEPFCDataSet = new WindowsFormsApplication1.BiblioEPFCDataSet();
            this.typeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ouvrageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ouvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabPageOuvrage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelOuvrage = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.idOuvrageTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.localisationTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateCreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateEmpruntDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.dureeEmpruntTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.numMembreTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.nomEntrepriseTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.numSuperTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.auteursOuvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auteurSuperviseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auteursOuvrageTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auteurSuperviseurTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TableAdapterManager();
            this.ouvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.membreTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.MembreTableAdapter();
            this.typeTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TypeTableAdapter();
            this.ouvrageTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auteursOuvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.AuteursOuvrageTableAdapter();
            this.typeOuvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TypeOuvrageTableAdapter();
            this.textBoxTypeOuvrage = new System.Windows.Forms.TextBox();
            idOuvrageLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            localisationLabel = new System.Windows.Forms.Label();
            dateCreationLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            dateEmpruntLabel = new System.Windows.Forms.Label();
            dureeEmpruntLabel = new System.Windows.Forms.Label();
            numTypeLabel = new System.Windows.Forms.Label();
            numMembreLabel = new System.Windows.Forms.Label();
            nomEntrepriseLabel = new System.Windows.Forms.Label();
            numSuperLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGlobal)).BeginInit();
            this.splitContainerGlobal.Panel1.SuspendLayout();
            this.splitContainerGlobal.Panel2.SuspendLayout();
            this.splitContainerGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOuvrageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreBindingSource)).BeginInit();
            this.tabController.SuspendLayout();
            this.tabPageOuvrage.SuspendLayout();
            this.flowLayoutPanelOuvrage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteursOuvrageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteursOuvrageTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idOuvrageLabel
            // 
            idOuvrageLabel.AutoSize = true;
            idOuvrageLabel.Location = new System.Drawing.Point(3, 0);
            idOuvrageLabel.Name = "idOuvrageLabel";
            idOuvrageLabel.Size = new System.Drawing.Size(62, 13);
            idOuvrageLabel.TabIndex = 0;
            idOuvrageLabel.Text = "id Ouvrage:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(3, 0);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(27, 13);
            titreLabel.TabIndex = 0;
            titreLabel.Text = "titre:";
            // 
            // localisationLabel
            // 
            localisationLabel.AutoSize = true;
            localisationLabel.Location = new System.Drawing.Point(3, 0);
            localisationLabel.Name = "localisationLabel";
            localisationLabel.Size = new System.Drawing.Size(62, 13);
            localisationLabel.TabIndex = 0;
            localisationLabel.Text = "localisation:";
            // 
            // dateCreationLabel
            // 
            dateCreationLabel.AutoSize = true;
            dateCreationLabel.Location = new System.Drawing.Point(3, 0);
            dateCreationLabel.Name = "dateCreationLabel";
            dateCreationLabel.Size = new System.Drawing.Size(73, 13);
            dateCreationLabel.TabIndex = 0;
            dateCreationLabel.Text = "date Creation:";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(3, 0);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(44, 13);
            sectionLabel.TabIndex = 0;
            sectionLabel.Text = "section:";
            // 
            // dateEmpruntLabel
            // 
            dateEmpruntLabel.AutoSize = true;
            dateEmpruntLabel.Location = new System.Drawing.Point(3, 0);
            dateEmpruntLabel.Name = "dateEmpruntLabel";
            dateEmpruntLabel.Size = new System.Drawing.Size(73, 13);
            dateEmpruntLabel.TabIndex = 0;
            dateEmpruntLabel.Text = "date Emprunt:";
            // 
            // dureeEmpruntLabel
            // 
            dureeEmpruntLabel.AutoSize = true;
            dureeEmpruntLabel.Location = new System.Drawing.Point(3, 0);
            dureeEmpruntLabel.Name = "dureeEmpruntLabel";
            dureeEmpruntLabel.Size = new System.Drawing.Size(79, 13);
            dureeEmpruntLabel.TabIndex = 0;
            dureeEmpruntLabel.Text = "duree Emprunt:";
            // 
            // numTypeLabel
            // 
            numTypeLabel.AutoSize = true;
            numTypeLabel.Location = new System.Drawing.Point(3, 0);
            numTypeLabel.Name = "numTypeLabel";
            numTypeLabel.Size = new System.Drawing.Size(34, 13);
            numTypeLabel.TabIndex = 0;
            numTypeLabel.Text = "Type:";
            // 
            // numMembreLabel
            // 
            numMembreLabel.AutoSize = true;
            numMembreLabel.Location = new System.Drawing.Point(3, 0);
            numMembreLabel.Name = "numMembreLabel";
            numMembreLabel.Size = new System.Drawing.Size(71, 13);
            numMembreLabel.TabIndex = 0;
            numMembreLabel.Text = "num Membre:";
            // 
            // nomEntrepriseLabel
            // 
            nomEntrepriseLabel.AutoSize = true;
            nomEntrepriseLabel.Location = new System.Drawing.Point(3, 0);
            nomEntrepriseLabel.Name = "nomEntrepriseLabel";
            nomEntrepriseLabel.Size = new System.Drawing.Size(80, 13);
            nomEntrepriseLabel.TabIndex = 0;
            nomEntrepriseLabel.Text = "nom Entreprise:";
            // 
            // numSuperLabel
            // 
            numSuperLabel.AutoSize = true;
            numSuperLabel.Location = new System.Drawing.Point(3, 0);
            numSuperLabel.Name = "numSuperLabel";
            numSuperLabel.Size = new System.Drawing.Size(61, 13);
            numSuperLabel.TabIndex = 0;
            numSuperLabel.Text = "num Super:";
            // 
            // splitContainerGlobal
            // 
            this.splitContainerGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGlobal.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGlobal.Name = "splitContainerGlobal";
            // 
            // splitContainerGlobal.Panel1
            // 
            this.splitContainerGlobal.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainerGlobal.Panel2
            // 
            this.splitContainerGlobal.Panel2.AutoScroll = true;
            this.splitContainerGlobal.Panel2.Controls.Add(this.tabController);
            this.splitContainerGlobal.Size = new System.Drawing.Size(1103, 853);
            this.splitContainerGlobal.SplitterDistance = 500;
            this.splitContainerGlobal.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.auteurSuperviseurDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.typeDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.ouvrageDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.membreDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(500, 853);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBoxRecherche);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(500, 306);
            this.splitContainer2.SplitterDistance = 96;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecherche.Location = new System.Drawing.Point(4, 22);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(494, 20);
            this.textBoxRecherche.TabIndex = 1;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonType, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonMembre, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonOuvrage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonAuteurSuperviseur, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 206);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // radioButtonType
            // 
            this.radioButtonType.AutoSize = true;
            this.radioButtonType.Location = new System.Drawing.Point(3, 156);
            this.radioButtonType.Name = "radioButtonType";
            this.radioButtonType.Size = new System.Drawing.Size(49, 17);
            this.radioButtonType.TabIndex = 3;
            this.radioButtonType.TabStop = true;
            this.radioButtonType.Text = "Type";
            this.radioButtonType.UseVisualStyleBackColor = true;
            this.radioButtonType.CheckedChanged += new System.EventHandler(this.radioButtonType_CheckedChanged);
            // 
            // radioButtonMembre
            // 
            this.radioButtonMembre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMembre.AutoSize = true;
            this.radioButtonMembre.Location = new System.Drawing.Point(3, 119);
            this.radioButtonMembre.Name = "radioButtonMembre";
            this.radioButtonMembre.Size = new System.Drawing.Size(494, 17);
            this.radioButtonMembre.TabIndex = 2;
            this.radioButtonMembre.TabStop = true;
            this.radioButtonMembre.Text = "Membre";
            this.radioButtonMembre.UseVisualStyleBackColor = true;
            this.radioButtonMembre.CheckedChanged += new System.EventHandler(this.radioButtonMembre_CheckedChanged);
            // 
            // radioButtonOuvrage
            // 
            this.radioButtonOuvrage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonOuvrage.AutoSize = true;
            this.radioButtonOuvrage.Location = new System.Drawing.Point(3, 17);
            this.radioButtonOuvrage.Name = "radioButtonOuvrage";
            this.radioButtonOuvrage.Size = new System.Drawing.Size(494, 17);
            this.radioButtonOuvrage.TabIndex = 0;
            this.radioButtonOuvrage.TabStop = true;
            this.radioButtonOuvrage.Text = "Ouvrage";
            this.radioButtonOuvrage.UseVisualStyleBackColor = true;
            this.radioButtonOuvrage.CheckedChanged += new System.EventHandler(this.radioButtonOuvrage_CheckedChanged);
            // 
            // radioButtonAuteurSuperviseur
            // 
            this.radioButtonAuteurSuperviseur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAuteurSuperviseur.AutoSize = true;
            this.radioButtonAuteurSuperviseur.Location = new System.Drawing.Point(3, 68);
            this.radioButtonAuteurSuperviseur.Name = "radioButtonAuteurSuperviseur";
            this.radioButtonAuteurSuperviseur.Size = new System.Drawing.Size(494, 17);
            this.radioButtonAuteurSuperviseur.TabIndex = 1;
            this.radioButtonAuteurSuperviseur.TabStop = true;
            this.radioButtonAuteurSuperviseur.Text = "Auteur/Superviseur";
            this.radioButtonAuteurSuperviseur.UseVisualStyleBackColor = true;
            this.radioButtonAuteurSuperviseur.CheckedChanged += new System.EventHandler(this.radioButtonAuteurSuperviseur_CheckedChanged);
            // 
            // auteurSuperviseurDataGridView
            // 
            this.auteurSuperviseurDataGridView.AllowUserToAddRows = false;
            this.auteurSuperviseurDataGridView.AllowUserToDeleteRows = false;
            this.auteurSuperviseurDataGridView.AutoGenerateColumns = false;
            this.auteurSuperviseurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auteurSuperviseurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.idOuvrageDataGridViewTextBoxColumn,
            this.idTypeDataGridViewTextBoxColumn});
            this.auteurSuperviseurDataGridView.DataSource = this.typeOuvrageBindingSource;
            this.auteurSuperviseurDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteurSuperviseurDataGridView.Location = new System.Drawing.Point(0, 0);
            this.auteurSuperviseurDataGridView.Name = "auteurSuperviseurDataGridView";
            this.auteurSuperviseurDataGridView.ReadOnly = true;
            this.auteurSuperviseurDataGridView.Size = new System.Drawing.Size(500, 543);
            this.auteurSuperviseurDataGridView.TabIndex = 0;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idOuvrageDataGridViewTextBoxColumn
            // 
            this.idOuvrageDataGridViewTextBoxColumn.DataPropertyName = "idOuvrage";
            this.idOuvrageDataGridViewTextBoxColumn.HeaderText = "idOuvrage";
            this.idOuvrageDataGridViewTextBoxColumn.Name = "idOuvrageDataGridViewTextBoxColumn";
            this.idOuvrageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTypeDataGridViewTextBoxColumn
            // 
            this.idTypeDataGridViewTextBoxColumn.DataPropertyName = "idType";
            this.idTypeDataGridViewTextBoxColumn.HeaderText = "idType";
            this.idTypeDataGridViewTextBoxColumn.Name = "idTypeDataGridViewTextBoxColumn";
            this.idTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeOuvrageBindingSource
            // 
            this.typeOuvrageBindingSource.DataMember = "TypeOuvrage";
            this.typeOuvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // biblioEPFCDataSet
            // 
            this.biblioEPFCDataSet.DataSetName = "BiblioEPFCDataSet";
            this.biblioEPFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeDataGridView
            // 
            this.typeDataGridView.AutoGenerateColumns = false;
            this.typeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.typeDataGridView.DataSource = this.typeBindingSource;
            this.typeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.typeDataGridView.Name = "typeDataGridView";
            this.typeDataGridView.Size = new System.Drawing.Size(500, 543);
            this.typeDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "idType";
            this.dataGridViewTextBoxColumn24.HeaderText = "idType";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn25.HeaderText = "description";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Sigle";
            this.dataGridViewTextBoxColumn26.HeaderText = "Sigle";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // ouvrageDataGridView
            // 
            this.ouvrageDataGridView.AutoGenerateColumns = false;
            this.ouvrageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ouvrageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ouvrageDataGridView.DataSource = this.ouvrageBindingSource;
            this.ouvrageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ouvrageDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ouvrageDataGridView.Name = "ouvrageDataGridView";
            this.ouvrageDataGridView.Size = new System.Drawing.Size(500, 543);
            this.ouvrageDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idOuvrage";
            this.dataGridViewTextBoxColumn5.HeaderText = "idOuvrage";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "titre";
            this.dataGridViewTextBoxColumn6.HeaderText = "titre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ouvrageBindingSource
            // 
            this.ouvrageBindingSource.DataMember = "Ouvrage";
            this.ouvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // membreDataGridView
            // 
            this.membreDataGridView.AutoGenerateColumns = false;
            this.membreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.membreDataGridView.DataSource = this.membreBindingSource;
            this.membreDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membreDataGridView.Location = new System.Drawing.Point(0, 0);
            this.membreDataGridView.Name = "membreDataGridView";
            this.membreDataGridView.Size = new System.Drawing.Size(500, 543);
            this.membreDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "idMembre";
            this.dataGridViewTextBoxColumn16.HeaderText = "idMembre";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn17.HeaderText = "nom";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn18.HeaderText = "prenom";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // membreBindingSource
            // 
            this.membreBindingSource.DataMember = "Membre";
            this.membreBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPageOuvrage);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 0);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(599, 853);
            this.tabController.TabIndex = 0;
            // 
            // tabPageOuvrage
            // 
            this.tabPageOuvrage.Controls.Add(this.flowLayoutPanelOuvrage);
            this.tabPageOuvrage.Location = new System.Drawing.Point(4, 22);
            this.tabPageOuvrage.Name = "tabPageOuvrage";
            this.tabPageOuvrage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOuvrage.Size = new System.Drawing.Size(591, 827);
            this.tabPageOuvrage.TabIndex = 1;
            this.tabPageOuvrage.Text = "tabPageOuvrage";
            this.tabPageOuvrage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelOuvrage
            // 
            this.flowLayoutPanelOuvrage.AutoScroll = true;
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanelOuvrage.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanelOuvrage.Controls.Add(this.listBox1);
            this.flowLayoutPanelOuvrage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOuvrage.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelOuvrage.Name = "flowLayoutPanelOuvrage";
            this.flowLayoutPanelOuvrage.Size = new System.Drawing.Size(585, 821);
            this.flowLayoutPanelOuvrage.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(idOuvrageLabel);
            this.flowLayoutPanel1.Controls.Add(this.idOuvrageTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // idOuvrageTextBox
            // 
            this.idOuvrageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "idOuvrage", true));
            this.idOuvrageTextBox.Location = new System.Drawing.Point(71, 3);
            this.idOuvrageTextBox.Name = "idOuvrageTextBox";
            this.idOuvrageTextBox.Size = new System.Drawing.Size(100, 20);
            this.idOuvrageTextBox.TabIndex = 1;
            this.idOuvrageTextBox.TextChanged += new System.EventHandler(this.idOuvrageTextBox_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(titreLabel);
            this.flowLayoutPanel2.Controls.Add(this.titreTextBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(209, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // titreTextBox
            // 
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(36, 3);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(100, 20);
            this.titreTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(localisationLabel);
            this.flowLayoutPanel3.Controls.Add(this.localisationTextBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 109);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // localisationTextBox
            // 
            this.localisationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "localisation", true));
            this.localisationTextBox.Location = new System.Drawing.Point(71, 3);
            this.localisationTextBox.Name = "localisationTextBox";
            this.localisationTextBox.Size = new System.Drawing.Size(100, 20);
            this.localisationTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(dateCreationLabel);
            this.flowLayoutPanel4.Controls.Add(this.dateCreationDateTimePicker);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(209, 109);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(223, 100);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // dateCreationDateTimePicker
            // 
            this.dateCreationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ouvrageBindingSource, "dateCreation", true));
            this.dateCreationDateTimePicker.Location = new System.Drawing.Point(3, 16);
            this.dateCreationDateTimePicker.Name = "dateCreationDateTimePicker";
            this.dateCreationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateCreationDateTimePicker.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(sectionLabel);
            this.flowLayoutPanel5.Controls.Add(this.sectionTextBox);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 215);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "section", true));
            this.sectionTextBox.Location = new System.Drawing.Point(53, 3);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(dateEmpruntLabel);
            this.flowLayoutPanel6.Controls.Add(this.dateEmpruntDateTimePicker);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(209, 215);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(223, 100);
            this.flowLayoutPanel6.TabIndex = 5;
            // 
            // dateEmpruntDateTimePicker
            // 
            this.dateEmpruntDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ouvrageBindingSource, "dateEmprunt", true));
            this.dateEmpruntDateTimePicker.Location = new System.Drawing.Point(3, 16);
            this.dateEmpruntDateTimePicker.Name = "dateEmpruntDateTimePicker";
            this.dateEmpruntDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateEmpruntDateTimePicker.TabIndex = 1;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(dureeEmpruntLabel);
            this.flowLayoutPanel7.Controls.Add(this.dureeEmpruntTextBox);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 321);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(208, 100);
            this.flowLayoutPanel7.TabIndex = 6;
            // 
            // dureeEmpruntTextBox
            // 
            this.dureeEmpruntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "dureeEmprunt", true));
            this.dureeEmpruntTextBox.Location = new System.Drawing.Point(88, 3);
            this.dureeEmpruntTextBox.Name = "dureeEmpruntTextBox";
            this.dureeEmpruntTextBox.Size = new System.Drawing.Size(100, 20);
            this.dureeEmpruntTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(numTypeLabel);
            this.flowLayoutPanel8.Controls.Add(this.textBoxTypeOuvrage);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(217, 321);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel8.TabIndex = 7;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(numMembreLabel);
            this.flowLayoutPanel9.Controls.Add(this.numMembreTextBox);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 427);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel9.TabIndex = 8;
            // 
            // numMembreTextBox
            // 
            this.numMembreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "numMembre", true));
            this.numMembreTextBox.Location = new System.Drawing.Point(80, 3);
            this.numMembreTextBox.Name = "numMembreTextBox";
            this.numMembreTextBox.Size = new System.Drawing.Size(100, 20);
            this.numMembreTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(nomEntrepriseLabel);
            this.flowLayoutPanel10.Controls.Add(this.nomEntrepriseTextBox);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(209, 427);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(209, 100);
            this.flowLayoutPanel10.TabIndex = 9;
            // 
            // nomEntrepriseTextBox
            // 
            this.nomEntrepriseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "nomEntreprise", true));
            this.nomEntrepriseTextBox.Location = new System.Drawing.Point(89, 3);
            this.nomEntrepriseTextBox.Name = "nomEntrepriseTextBox";
            this.nomEntrepriseTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomEntrepriseTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(numSuperLabel);
            this.flowLayoutPanel11.Controls.Add(this.numSuperTextBox);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(3, 533);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel11.TabIndex = 10;
            // 
            // numSuperTextBox
            // 
            this.numSuperTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "numSuper", true));
            this.numSuperTextBox.Location = new System.Drawing.Point(70, 3);
            this.numSuperTextBox.Name = "numSuperTextBox";
            this.numSuperTextBox.Size = new System.Drawing.Size(100, 20);
            this.numSuperTextBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.auteursOuvrageBindingSource;
            this.listBox1.DisplayMember = "NomPrenom";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(209, 533);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 12;
            // 
            // auteursOuvrageBindingSource
            // 
            this.auteursOuvrageBindingSource.DataMember = "AuteursOuvrage";
            this.auteursOuvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // auteurSuperviseurBindingSource
            // 
            this.auteurSuperviseurBindingSource.DataMember = "AuteurSuperviseur";
            this.auteurSuperviseurBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // auteursOuvrageTableAdapterBindingSource
            // 
            this.auteursOuvrageTableAdapterBindingSource.DataSource = typeof(WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.AuteursOuvrageTableAdapter);
            // 
            // auteurSuperviseurTableAdapter
            // 
            this.auteurSuperviseurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuteurSuperviseurTableAdapter = this.auteurSuperviseurTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembreTableAdapter = null;
            this.tableAdapterManager.OuvrageTableAdapter = null;
            this.tableAdapterManager.reserverTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ouvrageTableAdapter
            // 
            this.ouvrageTableAdapter.ClearBeforeFill = true;
            // 
            // membreTableAdapter
            // 
            this.membreTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // ouvrageTableAdapterBindingSource
            // 
            this.ouvrageTableAdapterBindingSource.DataSource = typeof(WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter);
            // 
            // auteursOuvrageTableAdapter
            // 
            this.auteursOuvrageTableAdapter.ClearBeforeFill = true;
            // 
            // typeOuvrageTableAdapter
            // 
            this.typeOuvrageTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxTypeOuvrage
            // 
            this.textBoxTypeOuvrage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeOuvrageBindingSource, "description", true));
            this.textBoxTypeOuvrage.Location = new System.Drawing.Point(43, 3);
            this.textBoxTypeOuvrage.Name = "textBoxTypeOuvrage";
            this.textBoxTypeOuvrage.Size = new System.Drawing.Size(100, 20);
            this.textBoxTypeOuvrage.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 853);
            this.Controls.Add(this.splitContainerGlobal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerGlobal.Panel1.ResumeLayout(false);
            this.splitContainerGlobal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGlobal)).EndInit();
            this.splitContainerGlobal.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOuvrageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreBindingSource)).EndInit();
            this.tabController.ResumeLayout(false);
            this.tabPageOuvrage.ResumeLayout(false);
            this.flowLayoutPanelOuvrage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteursOuvrageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteursOuvrageTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BiblioEPFCDataSet biblioEPFCDataSet;
        private System.Windows.Forms.BindingSource auteurSuperviseurBindingSource;
        private BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter auteurSuperviseurTableAdapter;
        private BiblioEPFCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource ouvrageBindingSource;
        private BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter ouvrageTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainerGlobal;
        private System.Windows.Forms.BindingSource membreBindingSource;
        private BiblioEPFCDataSetTableAdapters.MembreTableAdapter membreTableAdapter;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.RadioButton radioButtonMembre;
        private System.Windows.Forms.RadioButton radioButtonAuteurSuperviseur;
        private System.Windows.Forms.RadioButton radioButtonOuvrage;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.DataGridView membreDataGridView;
        private System.Windows.Forms.DataGridView ouvrageDataGridView;
        private System.Windows.Forms.TabPage tabPageOuvrage;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private BiblioEPFCDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.DataGridView typeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.RadioButton radioButtonType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOuvrage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox idOuvrageTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox localisationTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.DateTimePicker dateCreationDateTimePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.DateTimePicker dateEmpruntDateTimePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.TextBox dureeEmpruntTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.TextBox numMembreTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.TextBox nomEntrepriseTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.TextBox numSuperTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.BindingSource ouvrageTableAdapterBindingSource;
        private BiblioEPFCDataSetTableAdapters.AuteursOuvrageTableAdapter auteursOuvrageTableAdapter;
        private System.Windows.Forms.BindingSource auteursOuvrageTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource auteursOuvrageBindingSource;
        private BiblioEPFCDataSetTableAdapters.TypeOuvrageTableAdapter typeOuvrageTableAdapter;
        private System.Windows.Forms.BindingSource typeOuvrageBindingSource;
        private System.Windows.Forms.DataGridView auteurSuperviseurDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOuvrageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox textBoxTypeOuvrage;
    }
}

