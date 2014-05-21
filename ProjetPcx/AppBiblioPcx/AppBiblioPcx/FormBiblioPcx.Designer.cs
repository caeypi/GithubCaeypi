namespace WindowsFormsApplication1
{
    partial class FormBiblioPcx
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
            System.Windows.Forms.Label idAuteurSuperLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label statutLabel;
            System.Windows.Forms.Label idMembreLabel;
            System.Windows.Forms.Label nomLabel1;
            System.Windows.Forms.Label prenomLabel1;
            System.Windows.Forms.Label adresseRueLabel;
            System.Windows.Forms.Label adresseNumLabel;
            System.Windows.Forms.Label adresseCPLabel;
            System.Windows.Forms.Label adresseVilleLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label idTypeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label sigleLabel;
            this.splitContainerForm = new System.Windows.Forms.SplitContainer();
            this.splitContainerColG = new System.Windows.Forms.SplitContainer();
            this.splitContainerChpRecherche = new System.Windows.Forms.SplitContainer();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.radioButtonType = new System.Windows.Forms.RadioButton();
            this.radioButtonMembre = new System.Windows.Forms.RadioButton();
            this.radioButtonAuteurSuperviseur = new System.Windows.Forms.RadioButton();
            this.radioButtonOuvrage = new System.Windows.Forms.RadioButton();
            this.auteurSuperviseurDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteurSuperviseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioEPFCDataSet = new WindowsFormsApplication1.BiblioEPFCDataSet();
            this.typeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ouvrageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ouvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabOuvrage = new System.Windows.Forms.TabPage();
            this.splitContainerOuvrage = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelTabOuvrage = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.idOuvrageTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.localisationTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateCreationTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateEmpruntTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.dureeEmpruntTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.numTypeTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.numMembreTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.nomEntrepriseTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.numSuperTextBox = new System.Windows.Forms.TextBox();
            this.tabAuteurSuperviseur = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.idAuteurSuperTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.statutTextBox = new System.Windows.Forms.TextBox();
            this.tabMembre = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelTabMembre = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.idMembreTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel17 = new System.Windows.Forms.FlowLayoutPanel();
            this.nomTextBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel18 = new System.Windows.Forms.FlowLayoutPanel();
            this.prenomTextBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel19 = new System.Windows.Forms.FlowLayoutPanel();
            this.adresseRueTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel20 = new System.Windows.Forms.FlowLayoutPanel();
            this.adresseNumTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel21 = new System.Windows.Forms.FlowLayoutPanel();
            this.adresseCPTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel22 = new System.Windows.Forms.FlowLayoutPanel();
            this.adresseVilleTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel23 = new System.Windows.Forms.FlowLayoutPanel();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.tabType = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelTabType = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel24 = new System.Windows.Forms.FlowLayoutPanel();
            this.idTypeTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel25 = new System.Windows.Forms.FlowLayoutPanel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel26 = new System.Windows.Forms.FlowLayoutPanel();
            this.sigleTextBox = new System.Windows.Forms.TextBox();
            this.auteurSuperviseurTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TableAdapterManager();
            this.membreTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.MembreTableAdapter();
            this.ouvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.typeTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TypeTableAdapter();
            this.splitContainerAuteurSuperviseur = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelTabAuteurSuperviseur = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainerMembre = new System.Windows.Forms.SplitContainer();
            this.splitContainerTabType = new System.Windows.Forms.SplitContainer();
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
            idAuteurSuperLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            statutLabel = new System.Windows.Forms.Label();
            idMembreLabel = new System.Windows.Forms.Label();
            nomLabel1 = new System.Windows.Forms.Label();
            prenomLabel1 = new System.Windows.Forms.Label();
            adresseRueLabel = new System.Windows.Forms.Label();
            adresseNumLabel = new System.Windows.Forms.Label();
            adresseCPLabel = new System.Windows.Forms.Label();
            adresseVilleLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            idTypeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            sigleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerForm)).BeginInit();
            this.splitContainerForm.Panel1.SuspendLayout();
            this.splitContainerForm.Panel2.SuspendLayout();
            this.splitContainerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerColG)).BeginInit();
            this.splitContainerColG.Panel1.SuspendLayout();
            this.splitContainerColG.Panel2.SuspendLayout();
            this.splitContainerColG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChpRecherche)).BeginInit();
            this.splitContainerChpRecherche.Panel1.SuspendLayout();
            this.splitContainerChpRecherche.Panel2.SuspendLayout();
            this.splitContainerChpRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).BeginInit();
            this.tabController.SuspendLayout();
            this.tabOuvrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOuvrage)).BeginInit();
            this.splitContainerOuvrage.Panel1.SuspendLayout();
            this.splitContainerOuvrage.SuspendLayout();
            this.flowLayoutPanelTabOuvrage.SuspendLayout();
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
            this.flowLayoutPanel12.SuspendLayout();
            this.tabAuteurSuperviseur.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.flowLayoutPanel15.SuspendLayout();
            this.tabMembre.SuspendLayout();
            this.flowLayoutPanelTabMembre.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            this.flowLayoutPanel17.SuspendLayout();
            this.flowLayoutPanel18.SuspendLayout();
            this.flowLayoutPanel19.SuspendLayout();
            this.flowLayoutPanel20.SuspendLayout();
            this.flowLayoutPanel21.SuspendLayout();
            this.flowLayoutPanel22.SuspendLayout();
            this.flowLayoutPanel23.SuspendLayout();
            this.tabType.SuspendLayout();
            this.flowLayoutPanelTabType.SuspendLayout();
            this.flowLayoutPanel24.SuspendLayout();
            this.flowLayoutPanel25.SuspendLayout();
            this.flowLayoutPanel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAuteurSuperviseur)).BeginInit();
            this.splitContainerAuteurSuperviseur.Panel1.SuspendLayout();
            this.splitContainerAuteurSuperviseur.SuspendLayout();
            this.flowLayoutPanelTabAuteurSuperviseur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMembre)).BeginInit();
            this.splitContainerMembre.Panel1.SuspendLayout();
            this.splitContainerMembre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTabType)).BeginInit();
            this.splitContainerTabType.Panel1.SuspendLayout();
            this.splitContainerTabType.SuspendLayout();
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
            numTypeLabel.Size = new System.Drawing.Size(57, 13);
            numTypeLabel.TabIndex = 0;
            numTypeLabel.Text = "num Type:";
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
            // idAuteurSuperLabel
            // 
            idAuteurSuperLabel.AutoSize = true;
            idAuteurSuperLabel.Location = new System.Drawing.Point(3, 0);
            idAuteurSuperLabel.Name = "idAuteurSuperLabel";
            idAuteurSuperLabel.Size = new System.Drawing.Size(83, 13);
            idAuteurSuperLabel.TabIndex = 0;
            idAuteurSuperLabel.Text = "id Auteur Super:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(3, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(30, 13);
            nomLabel.TabIndex = 0;
            nomLabel.Text = "nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(3, 0);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(45, 13);
            prenomLabel.TabIndex = 0;
            prenomLabel.Text = "prenom:";
            // 
            // statutLabel
            // 
            statutLabel.AutoSize = true;
            statutLabel.Location = new System.Drawing.Point(3, 0);
            statutLabel.Name = "statutLabel";
            statutLabel.Size = new System.Drawing.Size(36, 13);
            statutLabel.TabIndex = 0;
            statutLabel.Text = "statut:";
            // 
            // idMembreLabel
            // 
            idMembreLabel.AutoSize = true;
            idMembreLabel.Location = new System.Drawing.Point(3, 0);
            idMembreLabel.Name = "idMembreLabel";
            idMembreLabel.Size = new System.Drawing.Size(59, 13);
            idMembreLabel.TabIndex = 0;
            idMembreLabel.Text = "id Membre:";
            // 
            // nomLabel1
            // 
            nomLabel1.AutoSize = true;
            nomLabel1.Location = new System.Drawing.Point(3, 0);
            nomLabel1.Name = "nomLabel1";
            nomLabel1.Size = new System.Drawing.Size(30, 13);
            nomLabel1.TabIndex = 0;
            nomLabel1.Text = "nom:";
            // 
            // prenomLabel1
            // 
            prenomLabel1.AutoSize = true;
            prenomLabel1.Location = new System.Drawing.Point(3, 0);
            prenomLabel1.Name = "prenomLabel1";
            prenomLabel1.Size = new System.Drawing.Size(45, 13);
            prenomLabel1.TabIndex = 0;
            prenomLabel1.Text = "prenom:";
            // 
            // adresseRueLabel
            // 
            adresseRueLabel.AutoSize = true;
            adresseRueLabel.Location = new System.Drawing.Point(3, 0);
            adresseRueLabel.Name = "adresseRueLabel";
            adresseRueLabel.Size = new System.Drawing.Size(70, 13);
            adresseRueLabel.TabIndex = 0;
            adresseRueLabel.Text = "adresse Rue:";
            // 
            // adresseNumLabel
            // 
            adresseNumLabel.AutoSize = true;
            adresseNumLabel.Location = new System.Drawing.Point(3, 0);
            adresseNumLabel.Name = "adresseNumLabel";
            adresseNumLabel.Size = new System.Drawing.Size(72, 13);
            adresseNumLabel.TabIndex = 0;
            adresseNumLabel.Text = "adresse Num:";
            // 
            // adresseCPLabel
            // 
            adresseCPLabel.AutoSize = true;
            adresseCPLabel.Location = new System.Drawing.Point(3, 0);
            adresseCPLabel.Name = "adresseCPLabel";
            adresseCPLabel.Size = new System.Drawing.Size(64, 13);
            adresseCPLabel.TabIndex = 0;
            adresseCPLabel.Text = "adresse CP:";
            // 
            // adresseVilleLabel
            // 
            adresseVilleLabel.AutoSize = true;
            adresseVilleLabel.Location = new System.Drawing.Point(3, 0);
            adresseVilleLabel.Name = "adresseVilleLabel";
            adresseVilleLabel.Size = new System.Drawing.Size(69, 13);
            adresseVilleLabel.TabIndex = 0;
            adresseVilleLabel.Text = "adresse Ville:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(3, 0);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(21, 13);
            telLabel.TabIndex = 0;
            telLabel.Text = "tel:";
            // 
            // idTypeLabel
            // 
            idTypeLabel.AutoSize = true;
            idTypeLabel.Location = new System.Drawing.Point(3, 0);
            idTypeLabel.Name = "idTypeLabel";
            idTypeLabel.Size = new System.Drawing.Size(45, 13);
            idTypeLabel.TabIndex = 0;
            idTypeLabel.Text = "id Type:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(3, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "description:";
            // 
            // sigleLabel
            // 
            sigleLabel.AutoSize = true;
            sigleLabel.Location = new System.Drawing.Point(3, 0);
            sigleLabel.Name = "sigleLabel";
            sigleLabel.Size = new System.Drawing.Size(33, 13);
            sigleLabel.TabIndex = 0;
            sigleLabel.Text = "Sigle:";
            // 
            // splitContainerForm
            // 
            this.splitContainerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerForm.Location = new System.Drawing.Point(0, 0);
            this.splitContainerForm.Name = "splitContainerForm";
            // 
            // splitContainerForm.Panel1
            // 
            this.splitContainerForm.Panel1.Controls.Add(this.splitContainerColG);
            // 
            // splitContainerForm.Panel2
            // 
            this.splitContainerForm.Panel2.Controls.Add(this.tabController);
            this.splitContainerForm.Size = new System.Drawing.Size(1058, 816);
            this.splitContainerForm.SplitterDistance = 352;
            this.splitContainerForm.TabIndex = 0;
            // 
            // splitContainerColG
            // 
            this.splitContainerColG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerColG.Location = new System.Drawing.Point(0, 0);
            this.splitContainerColG.Name = "splitContainerColG";
            this.splitContainerColG.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerColG.Panel1
            // 
            this.splitContainerColG.Panel1.Controls.Add(this.splitContainerChpRecherche);
            // 
            // splitContainerColG.Panel2
            // 
            this.splitContainerColG.Panel2.AutoScroll = true;
            this.splitContainerColG.Panel2.Controls.Add(this.auteurSuperviseurDataGridView);
            this.splitContainerColG.Panel2.Controls.Add(this.typeDataGridView);
            this.splitContainerColG.Panel2.Controls.Add(this.membreDataGridView);
            this.splitContainerColG.Panel2.Controls.Add(this.ouvrageDataGridView);
            this.splitContainerColG.Size = new System.Drawing.Size(352, 816);
            this.splitContainerColG.SplitterDistance = 182;
            this.splitContainerColG.TabIndex = 0;
            // 
            // splitContainerChpRecherche
            // 
            this.splitContainerChpRecherche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerChpRecherche.Location = new System.Drawing.Point(0, 0);
            this.splitContainerChpRecherche.Name = "splitContainerChpRecherche";
            this.splitContainerChpRecherche.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerChpRecherche.Panel1
            // 
            this.splitContainerChpRecherche.Panel1.Controls.Add(this.textBoxRecherche);
            // 
            // splitContainerChpRecherche.Panel2
            // 
            this.splitContainerChpRecherche.Panel2.Controls.Add(this.radioButtonType);
            this.splitContainerChpRecherche.Panel2.Controls.Add(this.radioButtonMembre);
            this.splitContainerChpRecherche.Panel2.Controls.Add(this.radioButtonAuteurSuperviseur);
            this.splitContainerChpRecherche.Panel2.Controls.Add(this.radioButtonOuvrage);
            this.splitContainerChpRecherche.Size = new System.Drawing.Size(352, 182);
            this.splitContainerChpRecherche.SplitterDistance = 36;
            this.splitContainerChpRecherche.TabIndex = 0;
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxRecherche.Location = new System.Drawing.Point(0, 16);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(352, 20);
            this.textBoxRecherche.TabIndex = 0;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textBoxRecherche_TextChanged);
            // 
            // radioButtonType
            // 
            this.radioButtonType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonType.AutoSize = true;
            this.radioButtonType.Location = new System.Drawing.Point(12, 72);
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
            this.radioButtonMembre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMembre.AutoSize = true;
            this.radioButtonMembre.Location = new System.Drawing.Point(12, 49);
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
            this.radioButtonAuteurSuperviseur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAuteurSuperviseur.AutoSize = true;
            this.radioButtonAuteurSuperviseur.Location = new System.Drawing.Point(12, 26);
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
            this.radioButtonOuvrage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonOuvrage.AutoSize = true;
            this.radioButtonOuvrage.Location = new System.Drawing.Point(12, 3);
            this.radioButtonOuvrage.Name = "radioButtonOuvrage";
            this.radioButtonOuvrage.Size = new System.Drawing.Size(66, 17);
            this.radioButtonOuvrage.TabIndex = 0;
            this.radioButtonOuvrage.TabStop = true;
            this.radioButtonOuvrage.Text = "Ouvrage";
            this.radioButtonOuvrage.UseVisualStyleBackColor = true;
            this.radioButtonOuvrage.CheckedChanged += new System.EventHandler(this.radioButtonOuvrage_CheckedChanged);
            // 
            // auteurSuperviseurDataGridView
            // 
            this.auteurSuperviseurDataGridView.AutoGenerateColumns = false;
            this.auteurSuperviseurDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.auteurSuperviseurDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auteurSuperviseurDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.auteurSuperviseurDataGridView.DataSource = this.auteurSuperviseurBindingSource;
            this.auteurSuperviseurDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteurSuperviseurDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.auteurSuperviseurDataGridView.Location = new System.Drawing.Point(0, 0);
            this.auteurSuperviseurDataGridView.Name = "auteurSuperviseurDataGridView";
            this.auteurSuperviseurDataGridView.ReadOnly = true;
            this.auteurSuperviseurDataGridView.RowHeadersVisible = false;
            this.auteurSuperviseurDataGridView.Size = new System.Drawing.Size(352, 630);
            this.auteurSuperviseurDataGridView.TabIndex = 0;
            this.auteurSuperviseurDataGridView.Visible = false;
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "statut";
            this.dataGridViewTextBoxColumn4.HeaderText = "statut";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // auteurSuperviseurBindingSource
            // 
            this.auteurSuperviseurBindingSource.DataMember = "AuteurSuperviseur";
            this.auteurSuperviseurBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // biblioEPFCDataSet
            // 
            this.biblioEPFCDataSet.DataSetName = "BiblioEPFCDataSet";
            this.biblioEPFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeDataGridView
            // 
            this.typeDataGridView.AutoGenerateColumns = false;
            this.typeDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.typeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.typeDataGridView.DataSource = this.typeBindingSource;
            this.typeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.typeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.typeDataGridView.Name = "typeDataGridView";
            this.typeDataGridView.ReadOnly = true;
            this.typeDataGridView.RowHeadersVisible = false;
            this.typeDataGridView.Size = new System.Drawing.Size(352, 630);
            this.typeDataGridView.TabIndex = 3;
            this.typeDataGridView.Visible = false;
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
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // membreDataGridView
            // 
            this.membreDataGridView.AutoGenerateColumns = false;
            this.membreDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.membreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.membreDataGridView.DataSource = this.membreBindingSource;
            this.membreDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membreDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.membreDataGridView.Location = new System.Drawing.Point(0, 0);
            this.membreDataGridView.Name = "membreDataGridView";
            this.membreDataGridView.ReadOnly = true;
            this.membreDataGridView.RowHeadersVisible = false;
            this.membreDataGridView.Size = new System.Drawing.Size(352, 630);
            this.membreDataGridView.TabIndex = 2;
            this.membreDataGridView.Visible = false;
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
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "prenom";
            this.dataGridViewTextBoxColumn18.HeaderText = "prenom";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // membreBindingSource
            // 
            this.membreBindingSource.DataMember = "Membre";
            this.membreBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // ouvrageDataGridView
            // 
            this.ouvrageDataGridView.AutoGenerateColumns = false;
            this.ouvrageDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ouvrageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ouvrageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ouvrageDataGridView.DataSource = this.ouvrageBindingSource;
            this.ouvrageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ouvrageDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ouvrageDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ouvrageDataGridView.Name = "ouvrageDataGridView";
            this.ouvrageDataGridView.ReadOnly = true;
            this.ouvrageDataGridView.RowHeadersVisible = false;
            this.ouvrageDataGridView.Size = new System.Drawing.Size(352, 630);
            this.ouvrageDataGridView.TabIndex = 1;
            this.ouvrageDataGridView.Visible = false;
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
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ouvrageBindingSource
            // 
            this.ouvrageBindingSource.DataMember = "Ouvrage";
            this.ouvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabOuvrage);
            this.tabController.Controls.Add(this.tabAuteurSuperviseur);
            this.tabController.Controls.Add(this.tabMembre);
            this.tabController.Controls.Add(this.tabType);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 0);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(702, 816);
            this.tabController.TabIndex = 0;
            // 
            // tabOuvrage
            // 
            this.tabOuvrage.Controls.Add(this.splitContainerOuvrage);
            this.tabOuvrage.Location = new System.Drawing.Point(4, 22);
            this.tabOuvrage.Name = "tabOuvrage";
            this.tabOuvrage.Padding = new System.Windows.Forms.Padding(3);
            this.tabOuvrage.Size = new System.Drawing.Size(694, 790);
            this.tabOuvrage.TabIndex = 0;
            this.tabOuvrage.Text = "Ouvrage";
            this.tabOuvrage.UseVisualStyleBackColor = true;
            // 
            // splitContainerOuvrage
            // 
            this.splitContainerOuvrage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOuvrage.Location = new System.Drawing.Point(3, 3);
            this.splitContainerOuvrage.Name = "splitContainerOuvrage";
            this.splitContainerOuvrage.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerOuvrage.Panel1
            // 
            this.splitContainerOuvrage.Panel1.Controls.Add(this.flowLayoutPanelTabOuvrage);
            this.splitContainerOuvrage.Size = new System.Drawing.Size(688, 784);
            this.splitContainerOuvrage.SplitterDistance = 705;
            this.splitContainerOuvrage.TabIndex = 0;
            // 
            // flowLayoutPanelTabOuvrage
            // 
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanelTabOuvrage.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanelTabOuvrage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTabOuvrage.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTabOuvrage.Name = "flowLayoutPanelTabOuvrage";
            this.flowLayoutPanelTabOuvrage.Size = new System.Drawing.Size(688, 705);
            this.flowLayoutPanelTabOuvrage.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(idOuvrageLabel);
            this.flowLayoutPanel2.Controls.Add(this.idOuvrageTextBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // idOuvrageTextBox
            // 
            this.idOuvrageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "idOuvrage", true));
            this.idOuvrageTextBox.Location = new System.Drawing.Point(71, 3);
            this.idOuvrageTextBox.Name = "idOuvrageTextBox";
            this.idOuvrageTextBox.ReadOnly = true;
            this.idOuvrageTextBox.Size = new System.Drawing.Size(100, 20);
            this.idOuvrageTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(titreLabel);
            this.flowLayoutPanel3.Controls.Add(this.titreTextBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(209, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // titreTextBox
            // 
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(36, 3);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.ReadOnly = true;
            this.titreTextBox.Size = new System.Drawing.Size(100, 20);
            this.titreTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(localisationLabel);
            this.flowLayoutPanel4.Controls.Add(this.localisationTextBox);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(415, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // localisationTextBox
            // 
            this.localisationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "localisation", true));
            this.localisationTextBox.Location = new System.Drawing.Point(71, 3);
            this.localisationTextBox.Name = "localisationTextBox";
            this.localisationTextBox.ReadOnly = true;
            this.localisationTextBox.Size = new System.Drawing.Size(100, 20);
            this.localisationTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(dateCreationLabel);
            this.flowLayoutPanel5.Controls.Add(this.dateCreationTextBox);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 109);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(223, 100);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // dateCreationTextBox
            // 
            this.dateCreationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "dateCreation", true));
            this.dateCreationTextBox.Location = new System.Drawing.Point(82, 3);
            this.dateCreationTextBox.Name = "dateCreationTextBox";
            this.dateCreationTextBox.ReadOnly = true;
            this.dateCreationTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateCreationTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(sectionLabel);
            this.flowLayoutPanel6.Controls.Add(this.sectionTextBox);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(232, 109);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel6.TabIndex = 4;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "section", true));
            this.sectionTextBox.Location = new System.Drawing.Point(53, 3);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.ReadOnly = true;
            this.sectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(dateEmpruntLabel);
            this.flowLayoutPanel7.Controls.Add(this.dateEmpruntTextBox);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(438, 109);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(202, 100);
            this.flowLayoutPanel7.TabIndex = 5;
            // 
            // dateEmpruntTextBox
            // 
            this.dateEmpruntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "dateEmprunt", true));
            this.dateEmpruntTextBox.Location = new System.Drawing.Point(82, 3);
            this.dateEmpruntTextBox.Name = "dateEmpruntTextBox";
            this.dateEmpruntTextBox.ReadOnly = true;
            this.dateEmpruntTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateEmpruntTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(dureeEmpruntLabel);
            this.flowLayoutPanel8.Controls.Add(this.dureeEmpruntTextBox);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 215);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(208, 100);
            this.flowLayoutPanel8.TabIndex = 6;
            // 
            // dureeEmpruntTextBox
            // 
            this.dureeEmpruntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "dureeEmprunt", true));
            this.dureeEmpruntTextBox.Location = new System.Drawing.Point(88, 3);
            this.dureeEmpruntTextBox.Name = "dureeEmpruntTextBox";
            this.dureeEmpruntTextBox.ReadOnly = true;
            this.dureeEmpruntTextBox.Size = new System.Drawing.Size(100, 20);
            this.dureeEmpruntTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(numTypeLabel);
            this.flowLayoutPanel9.Controls.Add(this.numTypeTextBox);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(217, 215);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel9.TabIndex = 7;
            // 
            // numTypeTextBox
            // 
            this.numTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "numType", true));
            this.numTypeTextBox.Location = new System.Drawing.Point(66, 3);
            this.numTypeTextBox.Name = "numTypeTextBox";
            this.numTypeTextBox.ReadOnly = true;
            this.numTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.numTypeTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(numMembreLabel);
            this.flowLayoutPanel10.Controls.Add(this.numMembreTextBox);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(423, 215);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel10.TabIndex = 8;
            // 
            // numMembreTextBox
            // 
            this.numMembreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "numMembre", true));
            this.numMembreTextBox.Location = new System.Drawing.Point(80, 3);
            this.numMembreTextBox.Name = "numMembreTextBox";
            this.numMembreTextBox.ReadOnly = true;
            this.numMembreTextBox.Size = new System.Drawing.Size(100, 20);
            this.numMembreTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(nomEntrepriseLabel);
            this.flowLayoutPanel11.Controls.Add(this.nomEntrepriseTextBox);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(3, 321);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(209, 100);
            this.flowLayoutPanel11.TabIndex = 9;
            // 
            // nomEntrepriseTextBox
            // 
            this.nomEntrepriseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "nomEntreprise", true));
            this.nomEntrepriseTextBox.Location = new System.Drawing.Point(89, 3);
            this.nomEntrepriseTextBox.Name = "nomEntrepriseTextBox";
            this.nomEntrepriseTextBox.ReadOnly = true;
            this.nomEntrepriseTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomEntrepriseTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(numSuperLabel);
            this.flowLayoutPanel12.Controls.Add(this.numSuperTextBox);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(218, 321);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel12.TabIndex = 10;
            // 
            // numSuperTextBox
            // 
            this.numSuperTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "numSuper", true));
            this.numSuperTextBox.Location = new System.Drawing.Point(70, 3);
            this.numSuperTextBox.Name = "numSuperTextBox";
            this.numSuperTextBox.ReadOnly = true;
            this.numSuperTextBox.Size = new System.Drawing.Size(100, 20);
            this.numSuperTextBox.TabIndex = 1;
            // 
            // tabAuteurSuperviseur
            // 
            this.tabAuteurSuperviseur.Controls.Add(this.splitContainerAuteurSuperviseur);
            this.tabAuteurSuperviseur.Location = new System.Drawing.Point(4, 22);
            this.tabAuteurSuperviseur.Name = "tabAuteurSuperviseur";
            this.tabAuteurSuperviseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuteurSuperviseur.Size = new System.Drawing.Size(694, 790);
            this.tabAuteurSuperviseur.TabIndex = 1;
            this.tabAuteurSuperviseur.Text = "Auteur/Superviseur";
            this.tabAuteurSuperviseur.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(idAuteurSuperLabel);
            this.flowLayoutPanel1.Controls.Add(this.idAuteurSuperTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 105);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // idAuteurSuperTextBox
            // 
            this.idAuteurSuperTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auteurSuperviseurBindingSource, "idAuteurSuper", true));
            this.idAuteurSuperTextBox.Location = new System.Drawing.Point(92, 3);
            this.idAuteurSuperTextBox.Name = "idAuteurSuperTextBox";
            this.idAuteurSuperTextBox.ReadOnly = true;
            this.idAuteurSuperTextBox.Size = new System.Drawing.Size(100, 20);
            this.idAuteurSuperTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.Controls.Add(nomLabel);
            this.flowLayoutPanel13.Controls.Add(this.nomTextBox);
            this.flowLayoutPanel13.Location = new System.Drawing.Point(235, 3);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel13.TabIndex = 1;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auteurSuperviseurBindingSource, "nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(39, 3);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.ReadOnly = true;
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(prenomLabel);
            this.flowLayoutPanel14.Controls.Add(this.prenomTextBox);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(441, 3);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel14.TabIndex = 2;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auteurSuperviseurBindingSource, "prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(54, 3);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.ReadOnly = true;
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel15
            // 
            this.flowLayoutPanel15.Controls.Add(statutLabel);
            this.flowLayoutPanel15.Controls.Add(this.statutTextBox);
            this.flowLayoutPanel15.Location = new System.Drawing.Point(3, 114);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel15.TabIndex = 3;
            // 
            // statutTextBox
            // 
            this.statutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auteurSuperviseurBindingSource, "statut", true));
            this.statutTextBox.Location = new System.Drawing.Point(45, 3);
            this.statutTextBox.Name = "statutTextBox";
            this.statutTextBox.ReadOnly = true;
            this.statutTextBox.Size = new System.Drawing.Size(100, 20);
            this.statutTextBox.TabIndex = 1;
            // 
            // tabMembre
            // 
            this.tabMembre.Controls.Add(this.splitContainerMembre);
            this.tabMembre.Location = new System.Drawing.Point(4, 22);
            this.tabMembre.Name = "tabMembre";
            this.tabMembre.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembre.Size = new System.Drawing.Size(694, 790);
            this.tabMembre.TabIndex = 2;
            this.tabMembre.Text = "Membre";
            this.tabMembre.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelTabMembre
            // 
            this.flowLayoutPanelTabMembre.Controls.Add(this.flowLayoutPanel16);
            this.flowLayoutPanelTabMembre.Controls.Add(this.flowLayoutPanel17);
            this.flowLayoutPanelTabMembre.Controls.Add(this.flowLayoutPanel18);
            this.flowLayoutPanelTabMembre.Controls.Add(this.flowLayoutPanel19);
            this.flowLayoutPanelTabMembre.Controls.Add(this.flowLayoutPanel20);
            this.flowLayoutPanelTabMembre.Controls.Add(this.flowLayoutPanel21);
            this.flowLayoutPanelTabMembre.Controls.Add(this.flowLayoutPanel22);
            this.flowLayoutPanelTabMembre.Controls.Add(this.flowLayoutPanel23);
            this.flowLayoutPanelTabMembre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTabMembre.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTabMembre.Name = "flowLayoutPanelTabMembre";
            this.flowLayoutPanelTabMembre.Size = new System.Drawing.Size(688, 685);
            this.flowLayoutPanelTabMembre.TabIndex = 0;
            // 
            // flowLayoutPanel16
            // 
            this.flowLayoutPanel16.Controls.Add(idMembreLabel);
            this.flowLayoutPanel16.Controls.Add(this.idMembreTextBox);
            this.flowLayoutPanel16.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel16.Name = "flowLayoutPanel16";
            this.flowLayoutPanel16.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel16.TabIndex = 0;
            // 
            // idMembreTextBox
            // 
            this.idMembreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membreBindingSource, "idMembre", true));
            this.idMembreTextBox.Location = new System.Drawing.Point(68, 3);
            this.idMembreTextBox.Name = "idMembreTextBox";
            this.idMembreTextBox.ReadOnly = true;
            this.idMembreTextBox.Size = new System.Drawing.Size(100, 20);
            this.idMembreTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel17
            // 
            this.flowLayoutPanel17.Controls.Add(nomLabel1);
            this.flowLayoutPanel17.Controls.Add(this.nomTextBox1);
            this.flowLayoutPanel17.Location = new System.Drawing.Point(209, 3);
            this.flowLayoutPanel17.Name = "flowLayoutPanel17";
            this.flowLayoutPanel17.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel17.TabIndex = 1;
            // 
            // nomTextBox1
            // 
            this.nomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membreBindingSource, "nom", true));
            this.nomTextBox1.Location = new System.Drawing.Point(39, 3);
            this.nomTextBox1.Name = "nomTextBox1";
            this.nomTextBox1.ReadOnly = true;
            this.nomTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox1.TabIndex = 1;
            // 
            // flowLayoutPanel18
            // 
            this.flowLayoutPanel18.Controls.Add(prenomLabel1);
            this.flowLayoutPanel18.Controls.Add(this.prenomTextBox1);
            this.flowLayoutPanel18.Location = new System.Drawing.Point(415, 3);
            this.flowLayoutPanel18.Name = "flowLayoutPanel18";
            this.flowLayoutPanel18.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel18.TabIndex = 2;
            // 
            // prenomTextBox1
            // 
            this.prenomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membreBindingSource, "prenom", true));
            this.prenomTextBox1.Location = new System.Drawing.Point(54, 3);
            this.prenomTextBox1.Name = "prenomTextBox1";
            this.prenomTextBox1.ReadOnly = true;
            this.prenomTextBox1.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox1.TabIndex = 1;
            // 
            // flowLayoutPanel19
            // 
            this.flowLayoutPanel19.Controls.Add(adresseRueLabel);
            this.flowLayoutPanel19.Controls.Add(this.adresseRueTextBox);
            this.flowLayoutPanel19.Location = new System.Drawing.Point(3, 109);
            this.flowLayoutPanel19.Name = "flowLayoutPanel19";
            this.flowLayoutPanel19.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel19.TabIndex = 3;
            // 
            // adresseRueTextBox
            // 
            this.adresseRueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membreBindingSource, "adresseRue", true));
            this.adresseRueTextBox.Location = new System.Drawing.Point(79, 3);
            this.adresseRueTextBox.Name = "adresseRueTextBox";
            this.adresseRueTextBox.ReadOnly = true;
            this.adresseRueTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresseRueTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel20
            // 
            this.flowLayoutPanel20.Controls.Add(adresseNumLabel);
            this.flowLayoutPanel20.Controls.Add(this.adresseNumTextBox);
            this.flowLayoutPanel20.Location = new System.Drawing.Point(209, 109);
            this.flowLayoutPanel20.Name = "flowLayoutPanel20";
            this.flowLayoutPanel20.Size = new System.Drawing.Size(201, 100);
            this.flowLayoutPanel20.TabIndex = 4;
            // 
            // adresseNumTextBox
            // 
            this.adresseNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membreBindingSource, "adresseNum", true));
            this.adresseNumTextBox.Location = new System.Drawing.Point(81, 3);
            this.adresseNumTextBox.Name = "adresseNumTextBox";
            this.adresseNumTextBox.ReadOnly = true;
            this.adresseNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresseNumTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel21
            // 
            this.flowLayoutPanel21.Controls.Add(adresseCPLabel);
            this.flowLayoutPanel21.Controls.Add(this.adresseCPTextBox);
            this.flowLayoutPanel21.Location = new System.Drawing.Point(416, 109);
            this.flowLayoutPanel21.Name = "flowLayoutPanel21";
            this.flowLayoutPanel21.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel21.TabIndex = 5;
            // 
            // adresseCPTextBox
            // 
            this.adresseCPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membreBindingSource, "adresseCP", true));
            this.adresseCPTextBox.Location = new System.Drawing.Point(73, 3);
            this.adresseCPTextBox.Name = "adresseCPTextBox";
            this.adresseCPTextBox.ReadOnly = true;
            this.adresseCPTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresseCPTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel22
            // 
            this.flowLayoutPanel22.Controls.Add(adresseVilleLabel);
            this.flowLayoutPanel22.Controls.Add(this.adresseVilleTextBox);
            this.flowLayoutPanel22.Location = new System.Drawing.Point(3, 215);
            this.flowLayoutPanel22.Name = "flowLayoutPanel22";
            this.flowLayoutPanel22.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel22.TabIndex = 6;
            // 
            // adresseVilleTextBox
            // 
            this.adresseVilleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membreBindingSource, "adresseVille", true));
            this.adresseVilleTextBox.Location = new System.Drawing.Point(78, 3);
            this.adresseVilleTextBox.Name = "adresseVilleTextBox";
            this.adresseVilleTextBox.ReadOnly = true;
            this.adresseVilleTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresseVilleTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel23
            // 
            this.flowLayoutPanel23.Controls.Add(telLabel);
            this.flowLayoutPanel23.Controls.Add(this.telTextBox);
            this.flowLayoutPanel23.Location = new System.Drawing.Point(209, 215);
            this.flowLayoutPanel23.Name = "flowLayoutPanel23";
            this.flowLayoutPanel23.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel23.TabIndex = 7;
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membreBindingSource, "tel", true));
            this.telTextBox.Location = new System.Drawing.Point(30, 3);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.ReadOnly = true;
            this.telTextBox.Size = new System.Drawing.Size(100, 20);
            this.telTextBox.TabIndex = 1;
            // 
            // tabType
            // 
            this.tabType.Controls.Add(this.splitContainerTabType);
            this.tabType.Location = new System.Drawing.Point(4, 22);
            this.tabType.Name = "tabType";
            this.tabType.Padding = new System.Windows.Forms.Padding(3);
            this.tabType.Size = new System.Drawing.Size(694, 790);
            this.tabType.TabIndex = 3;
            this.tabType.Text = "Type";
            this.tabType.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelTabType
            // 
            this.flowLayoutPanelTabType.Controls.Add(this.flowLayoutPanel24);
            this.flowLayoutPanelTabType.Controls.Add(this.flowLayoutPanel25);
            this.flowLayoutPanelTabType.Controls.Add(this.flowLayoutPanel26);
            this.flowLayoutPanelTabType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTabType.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTabType.Name = "flowLayoutPanelTabType";
            this.flowLayoutPanelTabType.Size = new System.Drawing.Size(688, 668);
            this.flowLayoutPanelTabType.TabIndex = 0;
            // 
            // flowLayoutPanel24
            // 
            this.flowLayoutPanel24.Controls.Add(idTypeLabel);
            this.flowLayoutPanel24.Controls.Add(this.idTypeTextBox);
            this.flowLayoutPanel24.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel24.Name = "flowLayoutPanel24";
            this.flowLayoutPanel24.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel24.TabIndex = 0;
            // 
            // idTypeTextBox
            // 
            this.idTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeBindingSource, "idType", true));
            this.idTypeTextBox.Location = new System.Drawing.Point(54, 3);
            this.idTypeTextBox.Name = "idTypeTextBox";
            this.idTypeTextBox.ReadOnly = true;
            this.idTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTypeTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel25
            // 
            this.flowLayoutPanel25.Controls.Add(descriptionLabel);
            this.flowLayoutPanel25.Controls.Add(this.descriptionTextBox);
            this.flowLayoutPanel25.Location = new System.Drawing.Point(209, 3);
            this.flowLayoutPanel25.Name = "flowLayoutPanel25";
            this.flowLayoutPanel25.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel25.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(70, 3);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel26
            // 
            this.flowLayoutPanel26.Controls.Add(sigleLabel);
            this.flowLayoutPanel26.Controls.Add(this.sigleTextBox);
            this.flowLayoutPanel26.Location = new System.Drawing.Point(415, 3);
            this.flowLayoutPanel26.Name = "flowLayoutPanel26";
            this.flowLayoutPanel26.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel26.TabIndex = 2;
            // 
            // sigleTextBox
            // 
            this.sigleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeBindingSource, "Sigle", true));
            this.sigleTextBox.Location = new System.Drawing.Point(42, 3);
            this.sigleTextBox.Name = "sigleTextBox";
            this.sigleTextBox.ReadOnly = true;
            this.sigleTextBox.Size = new System.Drawing.Size(100, 20);
            this.sigleTextBox.TabIndex = 1;
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
            this.tableAdapterManager.MembreTableAdapter = this.membreTableAdapter;
            this.tableAdapterManager.OuvrageTableAdapter = this.ouvrageTableAdapter;
            this.tableAdapterManager.reserverTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = this.typeTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membreTableAdapter
            // 
            this.membreTableAdapter.ClearBeforeFill = true;
            // 
            // ouvrageTableAdapter
            // 
            this.ouvrageTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainerAuteurSuperviseur
            // 
            this.splitContainerAuteurSuperviseur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAuteurSuperviseur.Location = new System.Drawing.Point(3, 3);
            this.splitContainerAuteurSuperviseur.Name = "splitContainerAuteurSuperviseur";
            this.splitContainerAuteurSuperviseur.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAuteurSuperviseur.Panel1
            // 
            this.splitContainerAuteurSuperviseur.Panel1.Controls.Add(this.flowLayoutPanelTabAuteurSuperviseur);
            this.splitContainerAuteurSuperviseur.Size = new System.Drawing.Size(688, 784);
            this.splitContainerAuteurSuperviseur.SplitterDistance = 646;
            this.splitContainerAuteurSuperviseur.TabIndex = 4;
            // 
            // flowLayoutPanelTabAuteurSuperviseur
            // 
            this.flowLayoutPanelTabAuteurSuperviseur.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanelTabAuteurSuperviseur.Controls.Add(this.flowLayoutPanel13);
            this.flowLayoutPanelTabAuteurSuperviseur.Controls.Add(this.flowLayoutPanel14);
            this.flowLayoutPanelTabAuteurSuperviseur.Controls.Add(this.flowLayoutPanel15);
            this.flowLayoutPanelTabAuteurSuperviseur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTabAuteurSuperviseur.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTabAuteurSuperviseur.Name = "flowLayoutPanelTabAuteurSuperviseur";
            this.flowLayoutPanelTabAuteurSuperviseur.Size = new System.Drawing.Size(688, 646);
            this.flowLayoutPanelTabAuteurSuperviseur.TabIndex = 0;
            // 
            // splitContainerMembre
            // 
            this.splitContainerMembre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMembre.Location = new System.Drawing.Point(3, 3);
            this.splitContainerMembre.Name = "splitContainerMembre";
            this.splitContainerMembre.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMembre.Panel1
            // 
            this.splitContainerMembre.Panel1.Controls.Add(this.flowLayoutPanelTabMembre);
            this.splitContainerMembre.Size = new System.Drawing.Size(688, 784);
            this.splitContainerMembre.SplitterDistance = 685;
            this.splitContainerMembre.TabIndex = 1;
            // 
            // splitContainerTabType
            // 
            this.splitContainerTabType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTabType.Location = new System.Drawing.Point(3, 3);
            this.splitContainerTabType.Name = "splitContainerTabType";
            this.splitContainerTabType.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTabType.Panel1
            // 
            this.splitContainerTabType.Panel1.Controls.Add(this.flowLayoutPanelTabType);
            this.splitContainerTabType.Size = new System.Drawing.Size(688, 784);
            this.splitContainerTabType.SplitterDistance = 668;
            this.splitContainerTabType.TabIndex = 1;
            // 
            // FormBiblioPcx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1058, 816);
            this.Controls.Add(this.splitContainerForm);
            this.Name = "FormBiblioPcx";
            this.Text = "Recherche";
            this.Load += new System.EventHandler(this.FormBiblioPcx_Load);
            this.splitContainerForm.Panel1.ResumeLayout(false);
            this.splitContainerForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerForm)).EndInit();
            this.splitContainerForm.ResumeLayout(false);
            this.splitContainerColG.Panel1.ResumeLayout(false);
            this.splitContainerColG.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerColG)).EndInit();
            this.splitContainerColG.ResumeLayout(false);
            this.splitContainerChpRecherche.Panel1.ResumeLayout(false);
            this.splitContainerChpRecherche.Panel1.PerformLayout();
            this.splitContainerChpRecherche.Panel2.ResumeLayout(false);
            this.splitContainerChpRecherche.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerChpRecherche)).EndInit();
            this.splitContainerChpRecherche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).EndInit();
            this.tabController.ResumeLayout(false);
            this.tabOuvrage.ResumeLayout(false);
            this.splitContainerOuvrage.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOuvrage)).EndInit();
            this.splitContainerOuvrage.ResumeLayout(false);
            this.flowLayoutPanelTabOuvrage.ResumeLayout(false);
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
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.tabAuteurSuperviseur.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.flowLayoutPanel15.ResumeLayout(false);
            this.flowLayoutPanel15.PerformLayout();
            this.tabMembre.ResumeLayout(false);
            this.flowLayoutPanelTabMembre.ResumeLayout(false);
            this.flowLayoutPanel16.ResumeLayout(false);
            this.flowLayoutPanel16.PerformLayout();
            this.flowLayoutPanel17.ResumeLayout(false);
            this.flowLayoutPanel17.PerformLayout();
            this.flowLayoutPanel18.ResumeLayout(false);
            this.flowLayoutPanel18.PerformLayout();
            this.flowLayoutPanel19.ResumeLayout(false);
            this.flowLayoutPanel19.PerformLayout();
            this.flowLayoutPanel20.ResumeLayout(false);
            this.flowLayoutPanel20.PerformLayout();
            this.flowLayoutPanel21.ResumeLayout(false);
            this.flowLayoutPanel21.PerformLayout();
            this.flowLayoutPanel22.ResumeLayout(false);
            this.flowLayoutPanel22.PerformLayout();
            this.flowLayoutPanel23.ResumeLayout(false);
            this.flowLayoutPanel23.PerformLayout();
            this.tabType.ResumeLayout(false);
            this.flowLayoutPanelTabType.ResumeLayout(false);
            this.flowLayoutPanel24.ResumeLayout(false);
            this.flowLayoutPanel24.PerformLayout();
            this.flowLayoutPanel25.ResumeLayout(false);
            this.flowLayoutPanel25.PerformLayout();
            this.flowLayoutPanel26.ResumeLayout(false);
            this.flowLayoutPanel26.PerformLayout();
            this.splitContainerAuteurSuperviseur.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAuteurSuperviseur)).EndInit();
            this.splitContainerAuteurSuperviseur.ResumeLayout(false);
            this.flowLayoutPanelTabAuteurSuperviseur.ResumeLayout(false);
            this.splitContainerMembre.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMembre)).EndInit();
            this.splitContainerMembre.ResumeLayout(false);
            this.splitContainerTabType.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTabType)).EndInit();
            this.splitContainerTabType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerForm;
        private System.Windows.Forms.SplitContainer splitContainerColG;
        private System.Windows.Forms.SplitContainer splitContainerChpRecherche;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.RadioButton radioButtonType;
        private System.Windows.Forms.RadioButton radioButtonMembre;
        private System.Windows.Forms.RadioButton radioButtonAuteurSuperviseur;
        private System.Windows.Forms.RadioButton radioButtonOuvrage;
        private BiblioEPFCDataSet biblioEPFCDataSet;
        private System.Windows.Forms.BindingSource auteurSuperviseurBindingSource;
        private BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter auteurSuperviseurTableAdapter;
        private BiblioEPFCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView auteurSuperviseurDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter ouvrageTableAdapter;
        private System.Windows.Forms.BindingSource ouvrageBindingSource;
        private System.Windows.Forms.DataGridView ouvrageDataGridView;
        private BiblioEPFCDataSetTableAdapters.MembreTableAdapter membreTableAdapter;
        private System.Windows.Forms.BindingSource membreBindingSource;
        private System.Windows.Forms.DataGridView membreDataGridView;
        private BiblioEPFCDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private System.Windows.Forms.DataGridView typeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabOuvrage;
        private System.Windows.Forms.SplitContainer splitContainerOuvrage;
        private System.Windows.Forms.TabPage tabAuteurSuperviseur;
        private System.Windows.Forms.TabPage tabMembre;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTabOuvrage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox idOuvrageTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox localisationTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox dateCreationTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.TextBox dateEmpruntTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.TextBox dureeEmpruntTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.TextBox numTypeTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.TextBox numMembreTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.TextBox nomEntrepriseTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.TextBox numSuperTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox idAuteurSuperTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel15;
        private System.Windows.Forms.TextBox statutTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTabMembre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel16;
        private System.Windows.Forms.TextBox idMembreTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel17;
        private System.Windows.Forms.TextBox nomTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel18;
        private System.Windows.Forms.TextBox prenomTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel19;
        private System.Windows.Forms.TextBox adresseRueTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel20;
        private System.Windows.Forms.TextBox adresseNumTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel21;
        private System.Windows.Forms.TextBox adresseCPTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel22;
        private System.Windows.Forms.TextBox adresseVilleTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel23;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTabType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel24;
        private System.Windows.Forms.TextBox idTypeTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel25;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel26;
        private System.Windows.Forms.TextBox sigleTextBox;
        private System.Windows.Forms.SplitContainer splitContainerAuteurSuperviseur;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTabAuteurSuperviseur;
        private System.Windows.Forms.SplitContainer splitContainerMembre;
        private System.Windows.Forms.SplitContainer splitContainerTabType;
    }
}

