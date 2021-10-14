using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TdVeloMagg
{
    class Passerelle
    {
        //Attributs statiques privés
        private static string urlCarte =
       "http://data.montpellier3m.fr/sites/default/files/ressources/TAM_MMM_VELOMAG.xml";
        public static Carte getCarte()
        {
            try
            {
                //Créer une requête HTML
                HttpWebRequest requete = (HttpWebRequest)WebRequest.Create(urlCarte);
                requete.Method = WebRequestMethods.Http.Get;
                WebResponse rep = requete.GetResponse();

                //Déclarer un flux de données de type fichier
                StreamReader sr = new StreamReader(rep.GetResponseStream());

                //Préciser qu'il s'agit d'un document XML
                XmlTextReader xml = new XmlTextReader(sr);
                //Instanciation d'une carte
                Carte c = new Carte();
                //Tq il y a des lignes à lire
                while (xml.Read())
                {
                    //Si la ligne est une balise
                    if (xml.NodeType.Equals(XmlNodeType.Element))
                    {
                        //Si la balise est <si>
                        if (xml.LocalName.Equals("si"))
                        {
                            //on récupère les valeurs des différents attributs
                            string nom = xml.GetAttribute("na");
                            string id = xml.GetAttribute("id");
                            string latitude = xml.GetAttribute("la");
                            string longitude = xml.GetAttribute("lg");
                            string nbPlacesOccupees = xml.GetAttribute("av");
                            string nbPlacesLibres = xml.GetAttribute("fr");
                            string nbTotalPlaces = xml.GetAttribute("to");
                            //****** code à compléter ici *******
                            c.ajouterStation(int.Parse(id), nom, latitude, longitude,
                            int.Parse(nbPlacesLibres), int.Parse(nbPlacesOccupees),
                            int.Parse(nbTotalPlaces));
                        }
                    }
                }
                return c;
            }
            catch (Exception ex)
            {
                Console.Write("Attention !! " + ex.Message);
                return null;
            }
        }

    }
}
