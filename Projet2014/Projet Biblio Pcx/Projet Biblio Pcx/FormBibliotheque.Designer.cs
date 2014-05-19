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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.groupBoxRadioButtonRecherche = new System.Windows.Forms.GroupBox();
            this.radioButtonType = new System.Windows.Forms.RadioButton();
            this.radioButtonMembre = new System.Windows.Forms.RadioButton();
            this.radioButtonAuteurSuperviseur = new System.Windows.Forms.RadioButton();
            this.radioButtonOuvrage = new System.Windows.Forms.RadioButton();
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabPageRecherche = new System.Windows.Forms.TabPage();
            this.typeDataGridView = new System.Windows.Forms.DataGridView();
            this.membreDataGridView = new System.Windows.Forms.DataGridView();
            this.ouvrageDataGridView = new System.Windows.Forms.DataGridView();
            this.auteurSuperviseurDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageOuvrage = new System.Windows.Forms.TabPage();
            this.auteurSuperviseurTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TableAdapterManager();
            this.ouvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.membreTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.MembreTableAdapter();
            this.typeTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TypeTableAdapter();
            this.flowLayoutPanelOuvrage = new System.Windows.Forms.FlowLayoutPanel();
            this.idOuvrageTextBox = new System.Windows.Forms.TextBox();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.localisationTextBox = new System.Windows.Forms.TextBox();
            this.dateCreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.dateEmpruntDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dureeEmpruntTextBox = new System.Windows.Forms.TextBox();
            this.numTypeTextBox = new System.Windows.Forms.TextBox();
            this.numMembreTextBox = new System.Windows.Forms.TextBox();
            this.nomEntrepriseTextBox = new System.Windows.Forms.TextBox();
            this.numSuperTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioEPFCDataSet = new WindowsFormsApplication1.BiblioEPFCDataSet();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ouvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteurSuperviseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxRadioButtonRecherche.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tabPageRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurDataGridView)).BeginInit();
            this.tabPageOuvrage.SuspendLayout();
            this.flowLayoutPanelOuvrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerGlobal
            // 
            this.splitContainerGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGlobal.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGlobal.Name = "splitContainerGlobal";
            // 
            // splitContainerGlobal.Panel1
            // 
            this.splitContainerGlobal.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainerGlobal.Panel2
            // 
            this.splitContainerGlobal.Panel2.AutoScroll = true;
            this.splitContainerGlobal.Panel2.Controls.Add(this.tabController);
            this.splitContainerGlobal.Size = new System.Drawing.Size(772, 533);
            this.splitContainerGlobal.SplitterDistance = 169;
            this.splitContainerGlobal.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxRecherche, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxRadioButtonRecherche, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.86867F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 533);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRecherche.Location = new System.Drawing.Point(3, 16);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(163, 20);
            this.textBoxRecherche.TabIndex = 1;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // groupBoxRadioButtonRecherche
            // 
            this.groupBoxRadioButtonRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRadioButtonRecherche.Controls.Add(this.radioButtonType);
            this.groupBoxRadioButtonRecherche.Controls.Add(this.radioButtonMembre);
            this.groupBoxRadioButtonRecherche.Controls.Add(this.radioButtonAuteurSuperviseur);
            this.groupBoxRadioButtonRecherche.Controls.Add(this.radioButtonOuvrage);
            this.groupBoxRadioButtonRecherche.Location = new System.Drawing.Point(3, 56);
            this.groupBoxRadioButtonRecherche.Name = "groupBoxRadioButtonRecherche";
            this.groupBoxRadioButtonRecherche.Size = new System.Drawing.Size(163, 474);
            this.groupBoxRadioButtonRecherche.TabIndex = 2;
            this.groupBoxRadioButtonRecherche.TabStop = false;
            this.groupBoxRadioButtonRecherche.Text = "Source";
            // 
            // radioButtonType
            // 
            this.radioButtonType.AutoSize = true;
            this.radioButtonType.Location = new System.Drawing.Point(36, 88);
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
            this.radioButtonMembre.Location = new System.Drawing.Point(36, 65);
            this.radioButtonMembre.Name = "radioButtonMembre";
            this.radioButtonMembre.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMembre.TabIndex = 2;
            this.radioButtonMembre.TabStop = true;
            this.radioButtonMembre.Text = "Membre";
            this.radioButtonMembre.UseVisualStyleBackColor = true;
            this.radioButtonMembre.CheckedChanged += new System.EventHandler(this.radioButtonMembre_CheckedChanged);
            // 
            // radioButtonAuteurSuperviseur
            // 
            this.radioButtonAuteurSuperviseur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAuteurSuperviseur.AutoSize = true;
            this.radioButtonAuteurSuperviseur.Location = new System.Drawing.Point(36, 42);
            this.radioButtonAuteurSuperviseur.Name = "radioButtonAuteurSuperviseur";
            this.radioButtonAuteurSuperviseur.Size = new System.Drawing.Size(117, 17);
            this.radioButtonAuteurSuperviseur.TabIndex = 1;
            this.radioButtonAuteurSuperviseur.TabStop = true;
            this.radioButtonAuteurSuperviseur.Text = "Auteur/Superviseur";
            this.radioButtonAuteurSuperviseur.UseVisualStyleBackColor = true;
            this.radioButtonAuteurSuperviseur.CheckedChanged += new System.EventHandler(this.radioButtonAuteurSuperviseur_CheckedChanged);
            // 
            // radioButtonOuvrage
            // 
            this.radioButtonOuvrage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonOuvrage.AutoSize = true;
            this.radioButtonOuvrage.Location = new System.Drawing.Point(36, 19);
            this.radioButtonOuvrage.Name = "radioButtonOuvrage";
            this.radioButtonOuvrage.Size = new System.Drawing.Size(66, 17);
            this.radioButtonOuvrage.TabIndex = 0;
            this.radioButtonOuvrage.TabStop = true;
            this.radioButtonOuvrage.Text = "Ouvrage";
            this.radioButtonOuvrage.UseVisualStyleBackColor = true;
            this.radioButtonOuvrage.CheckedChanged += new System.EventHandler(this.radioButtonOuvrage_CheckedChanged);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPageRecherche);
            this.tabController.Controls.Add(this.tabPageOuvrage);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 0);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(599, 533);
            this.tabController.TabIndex = 0;
            // 
            // tabPageRecherche
            // 
            this.tabPageRecherche.AutoScroll = true;
            this.tabPageRecherche.Controls.Add(this.typeDataGridView);
            this.tabPageRecherche.Controls.Add(this.membreDataGridView);
            this.tabPageRecherche.Controls.Add(this.ouvrageDataGridView);
            this.tabPageRecherche.Controls.Add(this.auteurSuperviseurDataGridView);
            this.tabPageRecherche.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecherche.Name = "tabPageRecherche";
            this.tabPageRecherche.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecherche.Size = new System.Drawing.Size(591, 507);
            this.tabPageRecherche.TabIndex = 0;
            this.tabPageRecherche.Text = "tabPageRecherche";
            this.tabPageRecherche.UseVisualStyleBackColor = true;
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
            this.typeDataGridView.Location = new System.Drawing.Point(3, 3);
            this.typeDataGridView.Name = "typeDataGridView";
            this.typeDataGridView.Size = new System.Drawing.Size(585, 501);
            this.typeDataGridView.TabIndex = 3;
            // 
            // membreDataGridView
            // 
            this.membreDataGridView.AutoGenerateColumns = false;
            this.membreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.membreDataGridView.DataSource = this.membreBindingSource;
            this.membreDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membreDataGridView.Location = new System.Drawing.Point(3, 3);
            this.membreDataGridView.Name = "membreDataGridView";
            this.membreDataGridView.Size = new System.Drawing.Size(585, 501);
            this.membreDataGridView.TabIndex = 2;
            // 
            // ouvrageDataGridView
            // 
            this.ouvrageDataGridView.AutoGenerateColumns = false;
            this.ouvrageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ouvrageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.ouvrageDataGridView.DataSource = this.ouvrageBindingSource;
            this.ouvrageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ouvrageDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ouvrageDataGridView.Name = "ouvrageDataGridView";
            this.ouvrageDataGridView.Size = new System.Drawing.Size(585, 501);
            this.ouvrageDataGridView.TabIndex = 1;
            // 
            // auteurSuperviseurDataGridView
            // 
            this.auteurSuperviseurDataGridView.AutoGenerateColumns = false;
            this.auteurSuperviseurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auteurSuperviseurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.auteurSuperviseurDataGridView.DataSource = this.auteurSuperviseurBindingSource;
            this.auteurSuperviseurDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteurSuperviseurDataGridView.Location = new System.Drawing.Point(3, 3);
            this.auteurSuperviseurDataGridView.Name = "auteurSuperviseurDataGridView";
            this.auteurSuperviseurDataGridView.Size = new System.Drawing.Size(585, 501);
            this.auteurSuperviseurDataGridView.TabIndex = 0;
            // 
            // tabPageOuvrage
            // 
            this.tabPageOuvrage.Controls.Add(this.flowLayoutPanelOuvrage);
            this.tabPageOuvrage.Location = new System.Drawing.Point(4, 22);
            this.tabPageOuvrage.Name = "tabPageOuvrage";
            this.tabPageOuvrage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOuvrage.Size = new System.Drawing.Size(591, 507);
            this.tabPageOuvrage.TabIndex = 1;
            this.tabPageOuvrage.Text = "tabPageOuvrage";
            this.tabPageOuvrage.UseVisualStyleBackColor = true;
            // 
            // auteurSuperviseurTableAdapter
            // 
            this.auteurSuperviseurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuteurSuperviseurTableAdapter = this.auteurSuperviseurTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ecrireTableAdapter = null;
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
            // flowLayoutPanelOuvrage
            // 
            this.flowLayoutPanelOuvrage.Controls.Add(idOuvrageLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.idOuvrageTextBox);
            this.flowLayoutPanelOuvrage.Controls.Add(titreLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.titreTextBox);
            this.flowLayoutPanelOuvrage.Controls.Add(localisationLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.localisationTextBox);
            this.flowLayoutPanelOuvrage.Controls.Add(dateCreationLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.dateCreationDateTimePicker);
            this.flowLayoutPanelOuvrage.Controls.Add(sectionLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.sectionTextBox);
            this.flowLayoutPanelOuvrage.Controls.Add(dateEmpruntLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.dateEmpruntDateTimePicker);
            this.flowLayoutPanelOuvrage.Controls.Add(dureeEmpruntLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.dureeEmpruntTextBox);
            this.flowLayoutPanelOuvrage.Controls.Add(numTypeLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.numTypeTextBox);
            this.flowLayoutPanelOuvrage.Controls.Add(numMembreLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.numMembreTextBox);
            this.flowLayoutPanelOuvrage.Controls.Add(nomEntrepriseLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.nomEntrepriseTextBox);
            this.flowLayoutPanelOuvrage.Controls.Add(numSuperLabel);
            this.flowLayoutPanelOuvrage.Controls.Add(this.numSuperTextBox);
            this.flowLayoutPanelOuvrage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOuvrage.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelOuvrage.Name = "flowLayoutPanelOuvrage";
            this.flowLayoutPanelOuvrage.Size = new System.Drawing.Size(585, 501);
            this.flowLayoutPanelOuvrage.TabIndex = 0;
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
            // idOuvrageTextBox
            // 
            this.idOuvrageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "idOuvrage", true));
            this.idOuvrageTextBox.Location = new System.Drawing.Point(71, 3);
            this.idOuvrageTextBox.Name = "idOuvrageTextBox";
            this.idOuvrageTextBox.Size = new System.Drawing.Size(100, 20);
            this.idOuvrageTextBox.TabIndex = 1;
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(177, 0);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(27, 13);
            titreLabel.TabIndex = 2;
            titreLabel.Text = "titre:";
            // 
            // titreTextBox
            // 
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(210, 3);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(100, 20);
            this.titreTextBox.TabIndex = 3;
            // 
            // localisationLabel
            // 
            localisationLabel.AutoSize = true;
            localisationLabel.Location = new System.Drawing.Point(316, 0);
            localisationLabel.Name = "localisationLabel";
            localisationLabel.Size = new System.Drawing.Size(62, 13);
            localisationLabel.TabIndex = 4;
            localisationLabel.Text = "localisation:";
            // 
            // localisationTextBox
            // 
            this.localisationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "localisation", true));
            this.localisationTextBox.Location = new System.Drawing.Point(384, 3);
            this.localisationTextBox.Name = "localisationTextBox";
            this.localisationTextBox.Size = new System.Drawing.Size(100, 20);
            this.localisationTextBox.TabIndex = 5;
            // 
            // dateCreationLabel
            // 
            dateCreationLabel.AutoSize = true;
            dateCreationLabel.Location = new System.Drawing.Point(490, 0);
            dateCreationLabel.Name = "dateCreationLabel";
            dateCreationLabel.Size = new System.Drawing.Size(73, 13);
            dateCreationLabel.TabIndex = 6;
            dateCreationLabel.Text = "date Creation:";
            // 
            // dateCreationDateTimePicker
            // 
            this.dateCreationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ouvrageBindingSource, "dateCreation", true));
            this.dateCreationDateTimePicker.Location = new System.Drawing.Point(3, 29);
            this.dateCreationDateTimePicker.Name = "dateCreationDateTimePicker";
            this.dateCreationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateCreationDateTimePicker.TabIndex = 7;
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(209, 26);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(44, 13);
            sectionLabel.TabIndex = 8;
            sectionLabel.Text = "section:";
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "section", true));
            this.sectionTextBox.Location = new System.Drawing.Point(259, 29);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionTextBox.TabIndex = 9;
            this.sectionTextBox.TextChanged += new System.EventHandler(this.sectionTextBox_TextChanged);
            // 
            // dateEmpruntLabel
            // 
            dateEmpruntLabel.AutoSize = true;
            dateEmpruntLabel.Location = new System.Drawing.Point(365, 26);
            dateEmpruntLabel.Name = "dateEmpruntLabel";
            dateEmpruntLabel.Size = new System.Drawing.Size(73, 13);
            dateEmpruntLabel.TabIndex = 10;
            dateEmpruntLabel.Text = "date Emprunt:";
            // 
            // dateEmpruntDateTimePicker
            // 
            this.dateEmpruntDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ouvrageBindingSource, "dateEmprunt", true));
            this.dateEmpruntDateTimePicker.Location = new System.Drawing.Point(3, 55);
            this.dateEmpruntDateTimePicker.Name = "dateEmpruntDateTimePicker";
            this.dateEmpruntDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateEmpruntDateTimePicker.TabIndex = 11;
            // 
            // dureeEmpruntLabel
            // 
            dureeEmpruntLabel.AutoSize = true;
            dureeEmpruntLabel.Location = new System.Drawing.Point(209, 52);
            dureeEmpruntLabel.Name = "dureeEmpruntLabel";
            dureeEmpruntLabel.Size = new System.Drawing.Size(79, 13);
            dureeEmpruntLabel.TabIndex = 12;
            dureeEmpruntLabel.Text = "duree Emprunt:";
            // 
            // dureeEmpruntTextBox
            // 
            this.dureeEmpruntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "dureeEmprunt", true));
            this.dureeEmpruntTextBox.Location = new System.Drawing.Point(294, 55);
            this.dureeEmpruntTextBox.Name = "dureeEmpruntTextBox";
            this.dureeEmpruntTextBox.Size = new System.Drawing.Size(100, 20);
            this.dureeEmpruntTextBox.TabIndex = 13;
            // 
            // numTypeLabel
            // 
            numTypeLabel.AutoSize = true;
            numTypeLabel.Location = new System.Drawing.Point(400, 52);
            numTypeLabel.Name = "numTypeLabel";
            numTypeLabel.Size = new System.Drawing.Size(57, 13);
            numTypeLabel.TabIndex = 14;
            numTypeLabel.Text = "num Type:";
            // 
            // numTypeTextBox
            // 
            this.numTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "numType", true));
            this.numTypeTextBox.Location = new System.Drawing.Point(463, 55);
            this.numTypeTextBox.Name = "numTypeTextBox";
            this.numTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numTypeTextBox.TabIndex = 15;
            // 
            // numMembreLabel
            // 
            numMembreLabel.AutoSize = true;
            numMembreLabel.Location = new System.Drawing.Point(3, 78);
            numMembreLabel.Name = "numMembreLabel";
            numMembreLabel.Size = new System.Drawing.Size(71, 13);
            numMembreLabel.TabIndex = 16;
            numMembreLabel.Text = "num Membre:";
            // 
            // numMembreTextBox
            // 
            this.numMembreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "numMembre", true));
            this.numMembreTextBox.Location = new System.Drawing.Point(80, 81);
            this.numMembreTextBox.Name = "numMembreTextBox";
            this.numMembreTextBox.Size = new System.Drawing.Size(100, 20);
            this.numMembreTextBox.TabIndex = 17;
            // 
            // nomEntrepriseLabel
            // 
            nomEntrepriseLabel.AutoSize = true;
            nomEntrepriseLabel.Location = new System.Drawing.Point(186, 78);
            nomEntrepriseLabel.Name = "nomEntrepriseLabel";
            nomEntrepriseLabel.Size = new System.Drawing.Size(80, 13);
            nomEntrepriseLabel.TabIndex = 18;
            nomEntrepriseLabel.Text = "nom Entreprise:";
            // 
            // nomEntrepriseTextBox
            // 
            this.nomEntrepriseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "nomEntreprise", true));
            this.nomEntrepriseTextBox.Location = new System.Drawing.Point(272, 81);
            this.nomEntrepriseTextBox.Name = "nomEntrepriseTextBox";
            this.nomEntrepriseTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomEntrepriseTextBox.TabIndex = 19;
            // 
            // numSuperLabel
            // 
            numSuperLabel.AutoSize = true;
            numSuperLabel.Location = new System.Drawing.Point(378, 78);
            numSuperLabel.Name = "numSuperLabel";
            numSuperLabel.Size = new System.Drawing.Size(61, 13);
            numSuperLabel.TabIndex = 20;
            numSuperLabel.Text = "num Super:";
            // 
            // numSuperTextBox
            // 
            this.numSuperTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "numSuper", true));
            this.numSuperTextBox.Location = new System.Drawing.Point(445, 81);
            this.numSuperTextBox.Name = "numSuperTextBox";
            this.numSuperTextBox.Size = new System.Drawing.Size(100, 20);
            this.numSuperTextBox.TabIndex = 21;
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
            // biblioEPFCDataSet
            // 
            this.biblioEPFCDataSet.DataSetName = "BiblioEPFCDataSet";
            this.biblioEPFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "adresseRue";
            this.dataGridViewTextBoxColumn19.HeaderText = "adresseRue";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "adresseNum";
            this.dataGridViewTextBoxColumn20.HeaderText = "adresseNum";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "adresseCP";
            this.dataGridViewTextBoxColumn21.HeaderText = "adresseCP";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "adresseVille";
            this.dataGridViewTextBoxColumn22.HeaderText = "adresseVille";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "tel";
            this.dataGridViewTextBoxColumn23.HeaderText = "tel";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // membreBindingSource
            // 
            this.membreBindingSource.DataMember = "Membre";
            this.membreBindingSource.DataSource = this.biblioEPFCDataSet;
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "localisation";
            this.dataGridViewTextBoxColumn7.HeaderText = "localisation";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "dateCreation";
            this.dataGridViewTextBoxColumn8.HeaderText = "dateCreation";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "section";
            this.dataGridViewTextBoxColumn9.HeaderText = "section";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "dateEmprunt";
            this.dataGridViewTextBoxColumn10.HeaderText = "dateEmprunt";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "dureeEmprunt";
            this.dataGridViewTextBoxColumn11.HeaderText = "dureeEmprunt";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "numType";
            this.dataGridViewTextBoxColumn12.HeaderText = "numType";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "numMembre";
            this.dataGridViewTextBoxColumn13.HeaderText = "numMembre";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "nomEntreprise";
            this.dataGridViewTextBoxColumn14.HeaderText = "nomEntreprise";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "numSuper";
            this.dataGridViewTextBoxColumn15.HeaderText = "numSuper";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // ouvrageBindingSource
            // 
            this.ouvrageBindingSource.DataMember = "Ouvrage";
            this.ouvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idAuteurSuper";
            this.dataGridViewTextBoxColumn1.HeaderText = "idAuteurSuper";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "statut";
            this.dataGridViewTextBoxColumn4.HeaderText = "statut";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // auteurSuperviseurBindingSource
            // 
            this.auteurSuperviseurBindingSource.DataMember = "AuteurSuperviseur";
            this.auteurSuperviseurBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 533);
            this.Controls.Add(this.splitContainerGlobal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerGlobal.Panel1.ResumeLayout(false);
            this.splitContainerGlobal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGlobal)).EndInit();
            this.splitContainerGlobal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxRadioButtonRecherche.ResumeLayout(false);
            this.groupBoxRadioButtonRecherche.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.tabPageRecherche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurDataGridView)).EndInit();
            this.tabPageOuvrage.ResumeLayout(false);
            this.flowLayoutPanelOuvrage.ResumeLayout(false);
            this.flowLayoutPanelOuvrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurBindingSource)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.GroupBox groupBoxRadioButtonRecherche;
        private System.Windows.Forms.RadioButton radioButtonMembre;
        private System.Windows.Forms.RadioButton radioButtonAuteurSuperviseur;
        private System.Windows.Forms.RadioButton radioButtonOuvrage;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabPageRecherche;
        private System.Windows.Forms.DataGridView membreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridView ouvrageDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridView auteurSuperviseurDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage tabPageOuvrage;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private BiblioEPFCDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.DataGridView typeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.RadioButton radioButtonType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOuvrage;
        private System.Windows.Forms.TextBox idOuvrageTextBox;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.TextBox localisationTextBox;
        private System.Windows.Forms.DateTimePicker dateCreationDateTimePicker;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.DateTimePicker dateEmpruntDateTimePicker;
        private System.Windows.Forms.TextBox dureeEmpruntTextBox;
        private System.Windows.Forms.TextBox numTypeTextBox;
        private System.Windows.Forms.TextBox numMembreTextBox;
        private System.Windows.Forms.TextBox nomEntrepriseTextBox;
        private System.Windows.Forms.TextBox numSuperTextBox;
    }
}

