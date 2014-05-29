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
            this.ecrireTableAdapter1.Fill(this.biblioEPFCDataSet.ecrire);
            
            comboBoxLocalisation.Text = "";
            comboBoxSection.Text = "";
            comboBoxEntreprise.Text = "";
            comboBoxType.Text = "";
            comboBoxSuperviseur.Text = "";
            
            
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            String titre = textBoxTitre.Text, section = comboBoxSection.Text,localisation = comboBoxLocalisation.Text, entreprise = comboBoxEntreprise.Text;
            DateTime date = dateTimePicker1.Value;
            int type = Convert.ToInt32(comboBoxType.SelectedValue), superviseur = Convert.ToInt32(comboBoxSuperviseur.SelectedValue);
            int idOuvrage=0;
            // si la localisation existe déjà, on sélectionne la ligne où elle était déjà écrite
            if (comboBoxLocalisation.FindStringExact(comboBoxLocalisation.Text) != -1)
            {
                comboBoxLocalisation.DroppedDown = true;
                comboBoxLocalisation.DroppedDown = false;
            }
            this.ouvrageTableAdapter.InsertOuvrage(titre,localisation,date,section,type,entreprise,superviseur,out idOuvrage);// TODO: updateOuvrage(...), l'ouvrage est ajouté à Ouvrage
            foreach (DataRowView objDataRowView in listBoxAuteurs.SelectedItems) // ajoute le lien ouvrage - auteur(s) dans ecrire
                this.ecrireTableAdapter1.InsertEcriture(Convert.ToInt32(objDataRowView["idAuteurSuper"]),idOuvrage);
            this.ecrireTableAdapter1.Fill(this.biblioEPFCDataSet.ecrire);
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

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            FormBiblioPcx myForm = new FormBiblioPcx();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

    }
}
