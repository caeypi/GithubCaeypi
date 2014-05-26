using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormAjoutOuvrage : Form
    {
        public FormAjoutOuvrage()
        {
            InitializeComponent();
        }

        private void ouvrageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ouvrageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biblioEPFCDataSet);

        }

        private void FormAjoutOuvrage_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.AuteurSuperviseurAll'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.auteurSuperviseurAllTableAdapter.Fill(this.biblioEPFCDataSet.AuteurSuperviseurAll);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet1.SuperviseurAjoutOuvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.superviseurAjoutOuvrageTableAdapter.Fill(this.biblioEPFCDataSet.SuperviseurAjoutOuvrage);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.TypeAjoutOuvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeAjoutOuvrageTableAdapter.Fill(this.biblioEPFCDataSet.TypeAjoutOuvrage);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.EntrepriseOuvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.entrepriseOuvrageTableAdapter.Fill(this.biblioEPFCDataSet.EntrepriseOuvrage);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.SectionOuvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.sectionOuvrageTableAdapter.Fill(this.biblioEPFCDataSet.SectionOuvrage);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.LocalisationOuvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.localisationOuvrageTableAdapter.Fill(this.biblioEPFCDataSet.LocalisationOuvrage);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Ouvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ouvrageTableAdapter.Fill(this.biblioEPFCDataSet.Ouvrage);
            
            comboBoxLocalisation.Text = "";
            comboBoxSection.Text = "";
            comboBoxEntreprise.Text = "";
            comboBoxType.Text = "";
            comboBoxSuperviseur.Text = "";
            
            
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // si la localisation existe déjà, on sélectionne la ligne où elle était déjà écrite
            if (comboBoxLocalisation.FindStringExact(comboBoxLocalisation.Text) != -1)
            {
                comboBoxLocalisation.DroppedDown = true;
                comboBoxLocalisation.DroppedDown = false;
            }
            // TODO: updateOuvrage(...), l'ouvrage est ajouté à Ouvrage
        }

        private void checkBoxSuper_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxSuperviseur.Enabled = !comboBoxSuperviseur.Enabled;
        }

        private void textBoxTitre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTitre.Text != "")
                buttonAjouter.Enabled = true;
            else
                buttonAjouter.Enabled = false;
        }

    }
}
