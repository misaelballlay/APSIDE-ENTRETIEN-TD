using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdVeloMagg
{
    class Station
    {
        //Attribut
        private int id;
        private string nom;
        private string latitude;
        private string longitude;
        private int nbPlacesOccupees;
        private int nbPlacesLibres;
        private int nbPlacesTotales;

        //Constructeur
        public Station(int id, string nom, string latitude, string longitude, int nbPlacesOccupees, int nbPlacesLibres, int nbPlacesTotales)
        {
            this.id = id;
            this.nom = nom;
            this.latitude = latitude;
            this.longitude = longitude;
            this.nbPlacesOccupees = nbPlacesOccupees;
            this.nbPlacesLibres = nbPlacesLibres;
            this.nbPlacesTotales = nbPlacesTotales;
        }

        //Accesseurs
        public int Id { get => id; }
        public string Nom { get => nom; }

        //Méthodes publiques
        public string toString()
        {
            string res = "";

            res += "Latitude :\t" + this.latitude;
            res += "\nLongitude :\t" + this.longitude;
            res += "\nNombre de places occuppées :\t" + this.nbPlacesOccupees;
            res += "\nNombre de places libres :\t" + this.nbPlacesLibres;
            res += "\nNombre de places totales :\t" + this.nbPlacesTotales;

            return res;
        }
    }
}
