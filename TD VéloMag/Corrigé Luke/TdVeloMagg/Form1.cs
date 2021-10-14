using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TdVeloMagg
{
    public partial class Form1 : Form
    {
        //On charge la carte des stations
        Carte laCarte;

        public Form1()
        {
            InitializeComponent();
            laCarte = Passerelle.getCarte();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //****Code à compléter****

            Carte laCarte = Passerelle.getCarte();
            //On récupère toutes les stations et on ajoute leur nom à la dataGridView
            int nbStations = laCarte.nbStations();
            for(int i = 0; i <= (nbStations-1); i++)
            {
                dgvStations_CellContentClick.Rows.Add(laCarte.getLaStation(i).Nom);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //****Code à compléter****

            //On récupère l'index de la ligne de la dataGridView sélectionnée
            int index = dgvStations_CellContentClick.CurrentCell.RowIndex;

            //On affiche les infos de la station grâce au toString() de la classe station
            MessageBox.Show(laCarte.getLaStation(index).toString(), laCarte.getLaStation(index).Nom);
        }
    }
}
