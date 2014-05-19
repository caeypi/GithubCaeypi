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
    public partial class Form1 : Form
    {

        private int ouvrageCourant = 0 ;
        
        public Form1()
        {
            InitializeComponent();
            ouvrageDataGridView.Visible = false;
            auteurSuperviseurDataGridView.Visible = false;
            membreDataGridView.Visible = false;
            typeDataGridView.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Type'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.typeTableAdapter.Fill(this.biblioEPFCDataSet.Type);
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Membre'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.membreTableAdapter.Fill(this.biblioEPFCDataSet.Membre);
            this.ouvrageTableAdapter.Fill(this.biblioEPFCDataSet.Ouvrage);
            this.auteurSuperviseurTableAdapter.Fill(this.biblioEPFCDataSet.AuteurSuperviseur);
            this.auteurSuperviseurOuvrageTableAdapter.FillNomsAuteurs(this.biblioEPFCDataSet.AuteurSuperviseurOuvrage, ouvrageCourant);
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
                        String filtreAuteurSuperviseur = "" ;
                        for (int i = 0; i < listOfWords.Length; ++i)
                        {
                            if(filtreAuteurSuperviseur != "")
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

            ouvrageDataGridView.Visible = true;
            auteurSuperviseurDataGridView.Visible = false;
            membreDataGridView.Visible = false;
            typeDataGridView.Visible = false;
        }

        private void radioButtonAuteurSuperviseur_CheckedChanged(object sender, EventArgs e)
        {

            ouvrageDataGridView.Visible = false;
            auteurSuperviseurDataGridView.Visible = true;
            membreDataGridView.Visible = false;
            typeDataGridView.Visible = false;
        }

        private void radioButtonMembre_CheckedChanged(object sender, EventArgs e)
        {

            ouvrageDataGridView.Visible = false;
            auteurSuperviseurDataGridView.Visible = false;
            membreDataGridView.Visible = true;
            typeDataGridView.Visible = false;
        }

        private void radioButtonType_CheckedChanged(object sender, EventArgs e)
        {
            ouvrageDataGridView.Visible = false;
            auteurSuperviseurDataGridView.Visible = false;
            membreDataGridView.Visible = false;
            typeDataGridView.Visible = true;
        }

        private void idOuvrageTextBox_TextChanged(object sender, EventArgs e)
        {
            ouvrageCourant = Convert.ToInt32(idOuvrageTextBox.Text);
            MessageBox.Show(ouvrageCourant.ToString());
            this.auteurSuperviseurOuvrageTableAdapter.FillNomsAuteurs(this.biblioEPFCDataSet.AuteurSuperviseurOuvrage, ouvrageCourant);
        }

    }
}
    