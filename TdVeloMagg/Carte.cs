using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdVeloMagg
{
    class Carte
    {
        //Attribut (collection)
        private List<Station> lesStations;

        //Constructeur
        public Carte()
        {
            this.lesStations = new List<Station>();
        }

        //Méthodes publiques
        public void ajouterStation(int id, string nom, string latitude, string longitude, int nbPlacesOccupees, int nbPlacesLibres, int nbPlacesTotales)
        {
            Station newStation = new Station(id, nom, latitude, longitude, nbPlacesOccupees, nbPlacesLibres, nbPlacesTotales);
            lesStations.Add(newStation);
        }

        public Station getLaStation(int index)
        {
            Station laStation;

            laStation = lesStations[index];

            return laStation;
        }

        public int nbStations()
        {
            return lesStations.Count;
        }
    }
}
