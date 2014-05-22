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
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet1.SuperviseurAjoutOuvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.superviseurAjoutOuvrageTableAdapter.Fill(this.biblioEPFCDataSet1.SuperviseurAjoutOuvrage);
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

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {

            if (comboBoxLocalisation.Items.Contains(comboBoxLocalisation.Text))
            {
                comboBoxLocalisation.DroppedDown = true;
                comboBoxLocalisation.DroppedDown = false;
            }
            MessageBox.Show("" + comboBoxLocalisation.SelectedValue);
        }

        private void comboBoxLocalisation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
