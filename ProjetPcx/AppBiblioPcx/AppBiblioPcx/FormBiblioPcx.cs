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
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.reserver'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.reserverTableAdapter.Fill(this.biblioEPFCDataSet.reserver);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Type'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeTableAdapter.Fill(this.biblioEPFCDataSet.Type);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Membre'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.membreTableAdapter.Fill(this.biblioEPFCDataSet.Membre);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Ouvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ouvrageTableAdapter.Fill(this.biblioEPFCDataSet.Ouvrage);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.AuteurSuperviseur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.auteurSuperviseurTableAdapter.Fill(this.biblioEPFCDataSet.AuteurSuperviseur);
            //emptyBoxes();
            checkEmprunt();
        }

        private void emptyBoxes()
        {
            textBoxRecherche.Text = "";
            idOuvrageTextBox.Text = "";
            titreTextBox.Text = "";
            localisationTextBox.Text = "";
            dateCreationTextBox.Text = "";
            sectionTextBox.Text = "";
            dateEmpruntTextBox.Text = "";
            dureeEmpruntTextBox.Text = "";
            MembreTextBox.Text = "";
            nomEntrepriseTextBox.Text = "";
            SuperTextBox.Text = "";
            typeTextBox.Text = "";
            //listBoxAuteursOuvrage.Text = "";
            idAuteurSuperTextBox.Text = "";
            nomTextBox.Text = "";
            prenomTextBox.Text = "";
            statutTextBox.Text = "";
            //listBoxOuvragesAuteur.Text = "";
            
            idMembreTextBox.Text = "";
            nomTextBox1.Text = "";
            prenomTextBox1.Text = "";
            adresseRueTextBox.Text = "";
            adresseNumTextBox.Text = "";
            adresseCPTextBox.Text = "";
            adresseVilleTextBox.Text = "";
            telTextBox.Text = "";

            idTypeTextBox.Text = "";
            descriptionTextBox.Text = "";
            sigleTextBox.Text = "";
        }

        private void checkEmprunt()
        {
            if (MembreTextBox.Text == "")
                buttonEmprunter.Enabled = true;
            else
                buttonEmprunter.Enabled = false;
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
            //emptyBoxes(); 
            tabController.SelectedTab = tabOuvrage;
            ouvrageDataGridView.Visible = true;
            auteurSuperviseurDataGridView.Visible = false;
            membreDataGridView.Visible = false;
            typeDataGridView.Visible = false;
        }

        private void radioButtonAuteurSuperviseur_CheckedChanged(object sender, EventArgs e)
        {
            //emptyBoxes(); 
            tabController.SelectedTab = tabAuteurSuperviseur;
            ouvrageDataGridView.Visible = false;
            auteurSuperviseurDataGridView.Visible = true;
            membreDataGridView.Visible = false;
            typeDataGridView.Visible = false;
        }

        private void radioButtonMembre_CheckedChanged(object sender, EventArgs e)
        {
            //emptyBoxes(); 
            tabController.SelectedTab = tabMembre;
            ouvrageDataGridView.Visible = false;
            auteurSuperviseurDataGridView.Visible = false;
            membreDataGridView.Visible = true;
            typeDataGridView.Visible = false;
        }

        private void radioButtonType_CheckedChanged(object sender, EventArgs e)
        {
            //emptyBoxes(); 
            tabController.SelectedTab = tabType;
            ouvrageDataGridView.Visible = false;
            auteurSuperviseurDataGridView.Visible = false;
            membreDataGridView.Visible = false;
            typeDataGridView.Visible = true;
        }

        private void idOuvrageTextBox_TextChanged(object sender, EventArgs e)
        {
            /*typeTextBox.Text = "";
            MembreTextBox.Text = "";
            MembreTextBox.Text = "";*/
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
                if (reserverTableAdapter.ScalarQueryOuvrageReserve(idOuvrage) != 0) // si ouvrage réservé
                    textBoxReserve.Text = "Oui";
                else
                    textBoxReserve.Text = "Non";
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

        private void buttonAjoutOuvrage_Click(object sender, EventArgs e)
        {
            FormAjoutOuvrage myForm = new FormAjoutOuvrage();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void tabController_SelectedIndexChanged(object sender, EventArgs e)
        {
            //emptyBoxes();
        }

        private void MembreTextBox_TextChanged(object sender, EventArgs e)
        {
            checkEmprunt();
        }

        private void buttonEmprunter_Click(object sender, EventArgs e)
        {
            //comboBoxIdMembre.DroppedDown = true;
            //comboBoxIdMembre.DroppedDown = false; 
            if (isANumber(comboBoxIdMembre.Text))
            {
                int idOuvrage = Convert.ToInt32(idOuvrageTextBox.Text);
                int idMembre = Convert.ToInt32(comboBoxIdMembre.Text);
                if (textBoxReserve.Text == "Non") // ouvrage pas réservé
                    fenetreEmprunt(idOuvrage,idMembre);
                else if (reserverTableAdapter.ScalarQueryOuvrageReserveParMembre(idOuvrage, idMembre) != 0) // ouvrage réservé par le membre qui veut l'emprunter
                    fenetreEmprunt(idOuvrage,idMembre);
                else
                    MessageBox.Show("Ouvrage Réservé par un autre membre");
            }
        }

        private bool isANumber(String str)
        {
            int Num;
            bool isNum = int.TryParse(str, out Num);
            if (!isNum)
                MessageBox.Show("Invalid number");
            return isNum;
        }


        private void fenetreEmprunt(int idO, int idM)
        {
            FormEmprunt myForm = new FormEmprunt(idO,idM);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void textBoxReserve_TextChanged(object sender, EventArgs e)
        {
            if (textBoxReserve.Text == "Oui")
                buttonReserver.Enabled = false;
            else
                buttonReserver.Enabled = true;
        }

        private void buttonReserver_Click(object sender, EventArgs e)
        {
            // TODO: updateReserver(idOuvrage,idMembre),rajoute la ligne pour l'ouvrage courant
            if (MembreTextBox.Text == "") // si ouvrage pas emprunté
                ;// TODO: updateReserver(idOuvrage,dateTime.Today.add(14))

        }

        private void updateReservations()
        {
            // TODO: updateReserver(dateTime.Today), si une date de réservation set supérieure la date du jour, la ligne est supprimée
        }

        private void buttonRetourOuvrage_Click(object sender, EventArgs e)
        {
            // TODO: updateOuvrage; numMembre, dateEmprunt,dureeEmprunt sont mis à ""
            if (textBoxReserve.Text == "Oui") ;
                // TODO: updateReserver(idOuvrage,dateTime.Today.add(14)), la date de fin de réservation est actualisée à  la date du jour+14 jours
        }


    }
}
