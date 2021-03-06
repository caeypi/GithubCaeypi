﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormEmprunt : Form
    {
        
        private int idOuvrage,idMembre ;

        public FormEmprunt(int idO, int idM)
        {
            InitializeComponent();
            idOuvrage = idO;
            idMembre = idM;
            
        }

        private void ouvrageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ouvrageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biblioEPFCDataSet);

        }

        private void FormEmprunt_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Ouvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ouvrageTableAdapter.FillByIdOuvrage(this.biblioEPFCDataSet.Ouvrage,idOuvrage);
            dateEmpruntTextBox.Text = DateTime.Today.ToString("dd-MM -yyyy");
            dureeEmpruntTextBox.Text = "14 jours";
            textBoxIdMembre.Text = idMembre.ToString();
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            this.ouvrageTableAdapter.UpdateNouvelEmprunt(DateTime.Today.ToString(), 14, idMembre, idOuvrage);// updateOuvrage(dateTime.Today,dureeEmprunt,idMembre), les 3 cases de l'ouvrage sont mise à jour avec les valeurs envoyées
            this.reserverTableAdapter1.DeleteReservationMembreOuvrage(idMembre, idOuvrage);
            FormBiblioPcx myForm = new FormBiblioPcx();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
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
