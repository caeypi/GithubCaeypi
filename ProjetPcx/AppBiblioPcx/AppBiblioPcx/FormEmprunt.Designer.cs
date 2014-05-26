namespace WindowsFormsApplication1
{
    partial class FormEmprunt
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
            System.Windows.Forms.Label dureeEmpruntLabel;
            System.Windows.Forms.Label dateEmpruntLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelEmprunt = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.idOuvrageTextBox = new System.Windows.Forms.TextBox();
            this.ouvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioEPFCDataSet = new WindowsFormsApplication1.BiblioEPFCDataSet();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateEmpruntTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.dureeEmpruntTextBox = new System.Windows.Forms.TextBox();
            this.ouvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.TableAdapterManager();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelIdMembre = new System.Windows.Forms.Label();
            this.textBoxIdMembre = new System.Windows.Forms.TextBox();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            idOuvrageLabel = new System.Windows.Forms.Label();
            titreLabel = new System.Windows.Forms.Label();
            dureeEmpruntLabel = new System.Windows.Forms.Label();
            dateEmpruntLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanelEmprunt.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // idOuvrageLabel
            // 
            idOuvrageLabel.AutoSize = true;
            idOuvrageLabel.Location = new System.Drawing.Point(33, 0);
            idOuvrageLabel.Name = "idOuvrageLabel";
            idOuvrageLabel.Size = new System.Drawing.Size(62, 13);
            idOuvrageLabel.TabIndex = 0;
            idOuvrageLabel.Text = "id Ouvrage:";
            // 
            // titreLabel
            // 
            titreLabel.AutoSize = true;
            titreLabel.Location = new System.Drawing.Point(68, 0);
            titreLabel.Name = "titreLabel";
            titreLabel.Size = new System.Drawing.Size(27, 13);
            titreLabel.TabIndex = 0;
            titreLabel.Text = "titre:";
            // 
            // dureeEmpruntLabel
            // 
            dureeEmpruntLabel.AutoSize = true;
            dureeEmpruntLabel.Location = new System.Drawing.Point(16, 0);
            dureeEmpruntLabel.Name = "dureeEmpruntLabel";
            dureeEmpruntLabel.Size = new System.Drawing.Size(79, 13);
            dureeEmpruntLabel.TabIndex = 0;
            dureeEmpruntLabel.Text = "duree Emprunt:";
            // 
            // dateEmpruntLabel
            // 
            dateEmpruntLabel.AutoSize = true;
            dateEmpruntLabel.Location = new System.Drawing.Point(22, 0);
            dateEmpruntLabel.Name = "dateEmpruntLabel";
            dateEmpruntLabel.Size = new System.Drawing.Size(73, 13);
            dateEmpruntLabel.TabIndex = 0;
            dateEmpruntLabel.Text = "date Emprunt:";
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
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanelEmprunt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonConfirmer);
            this.splitContainer1.Size = new System.Drawing.Size(256, 293);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanelEmprunt
            // 
            this.flowLayoutPanelEmprunt.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanelEmprunt.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanelEmprunt.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanelEmprunt.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanelEmprunt.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanelEmprunt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEmprunt.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelEmprunt.Name = "flowLayoutPanelEmprunt";
            this.flowLayoutPanelEmprunt.Size = new System.Drawing.Size(256, 239);
            this.flowLayoutPanelEmprunt.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.idOuvrageTextBox);
            this.flowLayoutPanel1.Controls.Add(idOuvrageLabel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // idOuvrageTextBox
            // 
            this.idOuvrageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "idOuvrage", true));
            this.idOuvrageTextBox.Location = new System.Drawing.Point(101, 3);
            this.idOuvrageTextBox.Name = "idOuvrageTextBox";
            this.idOuvrageTextBox.ReadOnly = true;
            this.idOuvrageTextBox.Size = new System.Drawing.Size(100, 20);
            this.idOuvrageTextBox.TabIndex = 1;
            // 
            // ouvrageBindingSource
            // 
            this.ouvrageBindingSource.DataMember = "Ouvrage";
            this.ouvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // biblioEPFCDataSet
            // 
            this.biblioEPFCDataSet.DataSetName = "BiblioEPFCDataSet";
            this.biblioEPFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.titreTextBox);
            this.flowLayoutPanel2.Controls.Add(titreLabel);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 42);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(204, 32);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // titreTextBox
            // 
            this.titreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "titre", true));
            this.titreTextBox.Location = new System.Drawing.Point(101, 3);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.ReadOnly = true;
            this.titreTextBox.Size = new System.Drawing.Size(100, 20);
            this.titreTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.dateEmpruntTextBox);
            this.flowLayoutPanel3.Controls.Add(dateEmpruntLabel);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 80);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(204, 32);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // dateEmpruntTextBox
            // 
            this.dateEmpruntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "dateEmprunt", true));
            this.dateEmpruntTextBox.Location = new System.Drawing.Point(101, 3);
            this.dateEmpruntTextBox.Name = "dateEmpruntTextBox";
            this.dateEmpruntTextBox.ReadOnly = true;
            this.dateEmpruntTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateEmpruntTextBox.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.dureeEmpruntTextBox);
            this.flowLayoutPanel4.Controls.Add(dureeEmpruntLabel);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 118);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(204, 30);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // dureeEmpruntTextBox
            // 
            this.dureeEmpruntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ouvrageBindingSource, "dureeEmprunt", true));
            this.dureeEmpruntTextBox.Location = new System.Drawing.Point(101, 3);
            this.dureeEmpruntTextBox.Name = "dureeEmpruntTextBox";
            this.dureeEmpruntTextBox.ReadOnly = true;
            this.dureeEmpruntTextBox.Size = new System.Drawing.Size(100, 20);
            this.dureeEmpruntTextBox.TabIndex = 1;
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
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.textBoxIdMembre);
            this.flowLayoutPanel5.Controls.Add(this.labelIdMembre);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 154);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel5.Size = new System.Drawing.Size(204, 30);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // labelIdMembre
            // 
            this.labelIdMembre.AutoSize = true;
            this.labelIdMembre.Location = new System.Drawing.Point(38, 0);
            this.labelIdMembre.Name = "labelIdMembre";
            this.labelIdMembre.Size = new System.Drawing.Size(57, 13);
            this.labelIdMembre.TabIndex = 0;
            this.labelIdMembre.Text = "IdMembre:";
            // 
            // textBoxIdMembre
            // 
            this.textBoxIdMembre.Location = new System.Drawing.Point(101, 3);
            this.textBoxIdMembre.Name = "textBoxIdMembre";
            this.textBoxIdMembre.ReadOnly = true;
            this.textBoxIdMembre.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdMembre.TabIndex = 1;
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.Location = new System.Drawing.Point(85, 15);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmer.TabIndex = 0;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = true;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // FormEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 293);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormEmprunt";
            this.Text = "Emprunt";
            this.Load += new System.EventHandler(this.FormEmprunt_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanelEmprunt.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEmprunt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private BiblioEPFCDataSet biblioEPFCDataSet;
        private System.Windows.Forms.BindingSource ouvrageBindingSource;
        private BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter ouvrageTableAdapter;
        private BiblioEPFCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idOuvrageTextBox;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.TextBox dureeEmpruntTextBox;
        private System.Windows.Forms.TextBox dateEmpruntTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TextBox textBoxIdMembre;
        private System.Windows.Forms.Label labelIdMembre;
        private System.Windows.Forms.Button buttonConfirmer;

    }
}