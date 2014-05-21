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
    public partial class FormBiblioPcx : Form
    {
        public FormBiblioPcx()
        {
            InitializeComponent();
        }

        private void FormBiblioPcx_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Type'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeTableAdapter.Fill(this.biblioEPFCDataSet.Type);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Membre'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.membreTableAdapter.Fill(this.biblioEPFCDataSet.Membre);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Ouvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ouvrageTableAdapter.Fill(this.biblioEPFCDataSet.Ouvrage);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.AuteurSuperviseur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.auteurSuperviseurTableAdapter.Fill(this.biblioEPFCDataSet.AuteurSuperviseur);

        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRecherche.Text.Equals(""))
            {
                String[] listOfWords = textBoxRecherche.Text.Split(' ');
                if (radioButtonOuvrage.Checked)
                {
                    ouvrageBindingSource.Filter = "titre like '%" + textBoxRecherche.Text + "%'";
                }
                else if (radioButtonAuteurSuperviseur.Checked)
                {
                    String filtreAuteurSuperviseur = "";
                    for (int i = 0; i < listOfWords.Length; ++i)
                    {
                        if (filtreAuteurSuperviseur != "")
                            filtreAuteurSuperviseur += " AND ";
                        filtreAuteurSuperviseur += "(nom like '%" + listOfWords[i] + "%' OR prenom like '%" + listOfWords[i] + "%')";
                    }
                    auteurSuperviseurBindingSource.Filter = filtreAuteurSuperviseur;
                }
                else if (radioButtonMembre.Checked)
                {
                    String filtreMembre = "";
                    for (int i = 0; i < listOfWords.Length; ++i)
                    {
                        if (filtreMembre != "")
                            filtreMembre += " AND ";
                        filtreMembre += "(nom like '%" + listOfWords[i] + "%' OR prenom like '%" + listOfWords[i] + "%')";
                    }
                    membreBindingSource.Filter = filtreMembre;
                }
                else if (radioButtonType.Checked)
                {
                    typeBindingSource.Filter = "description like '%" + textBoxRecherche.Text + "%'";
                }
            }
        }

        private void radioButtonOuvrage_CheckedChanged(object sender, EventArgs e)
        {
            tabController.SelectedTab = tabOuvrage;
            ouvrageDataGridView.Visible = true;
            auteurSuperviseurDataGridView.Visible = false;
            membreDataGridView.Visible = false;
            typeDataGridView.Visible = false;
        }

        private void radioButtonAuteurSuperviseur_CheckedChanged(object sender, EventArgs e)
        {
            tabController.SelectedTab = tabAuteurSuperviseur;
            ouvrageDataGridView.Visible = false;
            auteurSuperviseurDataGridView.Visible = true;
            membreDataGridView.Visible = false;
            typeDataGridView.Visible = false;
        }

        private void radioButtonMembre_CheckedChanged(object sender, EventArgs e)
        {
            tabController.SelectedTab = tabMembre;
            ouvrageDataGridView.Visible = false;
            auteurSuperviseurDataGridView.Visible = false;
            membreDataGridView.Visible = true;
            typeDataGridView.Visible = false;
        }

        private void radioButtonType_CheckedChanged(object sender, EventArgs e)
        {
            tabController.SelectedTab = tabType;
            ouvrageDataGridView.Visible = false;
            auteurSuperviseurDataGridView.Visible = false;
            membreDataGridView.Visible = false;
            typeDataGridView.Visible = true;
        }
    }
}
