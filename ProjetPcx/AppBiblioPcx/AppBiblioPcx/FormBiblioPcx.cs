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

        private void idOuvrageTextBox_TextChanged(object sender, EventArgs e)
        {
            typeTextBox.Text = "";
            MembreTextBox.Text = "";
            MembreTextBox.Text = "";
            listBoxAuteursOuvrage.Hide();
            if (idOuvrageTextBox.Text != "")
            {
                int idOuvrage = Convert.ToInt32(idOuvrageTextBox.Text);
                // affiche le type d'ouvrage en français
                DataTable description = this.typeOuvrageTableAdapter1.GetDescriptionByOuvrage(idOuvrage);
                if (description.Rows.Count != 0)
                    typeTextBox.Text = description.Rows[0].ItemArray[0].ToString();
                // affiche le nom et prenom du membre qui a emprunter l'ouvrage
                DataTable membre = this.membreOuvrageTableAdapter1.GetNomPrenomMembreByIDOuvrage(idOuvrage);
                if (membre.Rows.Count != 0)
                    MembreTextBox.Text = membre.Rows[0].ItemArray[0].ToString();
                // affiche le nom et prenom du superviseur de l'ouvrage
                DataTable superviseur = this.superviseurOuvrageTableAdapter1.GetSuperviseurByIDOuvrage(idOuvrage);
                if (superviseur.Rows.Count != 0)
                    SuperTextBox.Text = superviseur.Rows[0].ItemArray[0].ToString();
                // affiche les nom et prénoms des auteurs de l'ouvrage
                listBoxAuteursOuvrage.Show();
                this.auteursOuvrageTableAdapter.FillAuteursByOuvrage(this.biblioEPFCDataSet.AuteursOuvrage, idOuvrage);
            }
        }

        private void idAuteurSuperTextBox_TextChanged(object sender, EventArgs e)
        {
            listBoxOuvragesAuteur.Hide();
            if (idAuteurSuperTextBox.Text != "")
            {
                int idAuteurSuper = Convert.ToInt32(idAuteurSuperTextBox.Text);
                //affiche les titres des ouvrages écrits par l'auteur
                listBoxOuvragesAuteur.Show();
                this.ouvragesAuteurTableAdapter.FillOuvragesByNumAuteur(this.biblioEPFCDataSet.OuvragesAuteur, idAuteurSuper);
            }
        }

        private void idMembreTextBox_TextChanged(object sender, EventArgs e)
        {
            listBoxOuvragesEmpruntes.Hide();
            listBoxReservationsMembre.Hide();
            if (idMembreTextBox.Text != "")
            {
                int idMembre = Convert.ToInt32(idMembreTextBox.Text);
                //affiche les titres des ouvrages empruntés par le membre
                listBoxOuvragesEmpruntes.Show() ;
                this.empruntsMembreTableAdapter.FillEmpruntsByIDMembre(this.biblioEPFCDataSet.EmpruntsMembre, idMembre);
                // affiche les titres des ouvrages réservés par le membre
                listBoxReservationsMembre.Show();
                this.reservationsMembreTableAdapter.FillReservationsMembreByIDMembre(this.biblioEPFCDataSet.ReservationsMembre, idMembre);
            }
        }

        private void idTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            listBoxOuvragesType.Hide();
            if (idTypeTextBox.Text != "")
            {
                int idType = Convert.ToInt32(idTypeTextBox.Text);
                // affiche les ouvrages du type
                listBoxOuvragesType.Show();
                this.ouvragesTypeTableAdapter.FillOuvragesByType(this.biblioEPFCDataSet.OuvragesType, idType);
            }
        }
    }
}
