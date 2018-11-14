using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parti02
{
    class Dijkstra
    {
        public List<Point> Graphe { get; set; }
        public List<Point> Ouvert { get; set; }
        public List<Point> Ferme { get; set; }
        public Point Premier { get; set; }
        public Point Dernier { get; set; }

        public Dijkstra(List<Point> graphe, Point p,Point d)
        {
            Graphe = graphe;
            Premier = p;
            Dernier = d;
        }

        public int Rechercher()
        {
            int dist = 0;
            Ouvert.Add(Premier);
            Ouvert[0].DistParcourue = 0;
            //Ajouter points suivant dans ouverts
            while (!EstPresentDansListe(Dernier,Ferme))
            {
                Console.WriteLine(this.Afficher(Ouvert));
                /* TO DO : 
                 * Initialisation : Premier va dans fermé. Ses fils vont dans Ouvert. On modifie leur DistParcourue à ce moment là
                 * Boucle : On affiche l'état d'Ouvert et Fermé
                 *          On tej les culs de sac
                 *          On cherche dans Ouvert le point avec DistParcourue la moins grande
                 *          On lui retire ses points adjacents étant déjà dans Fermé
                 *          On le met dans Fermé
                 *          On met ses points adjacents restant dans Ouvert
                */
                int plusPetitChemin = 100000;
                Point ptChoisi=Ouvert[0];
                //Selection du point avec la plus petite distance par rapport au début
                for(int i=0;i<Ouvert.Count();i++)
                {
                    Ouvert[i].CalculeDistanceParcourue();                    
                    if(Ouvert[i].CulDeSac)
                        //On enlève les points cul de sac
                    {
                        FermerPoint(Ouvert[i]);
                    }
                    else
                    // On cherche le point avec le poids le moins fort
                    {
                        if(Ouvert[i].DistParcourue  < plusPetitChemin)
                        {
                            plusPetitChemin = Ouvert[i].DistParcourue;
                            ptChoisi = Ouvert[i];
                        }
                    }
                }
                FermerPoint(ptChoisi);
                //On compare les points fermés et des points fils de ptChoisi pour les retirer des possibilités.
                foreach(Point ptf in Ferme)
                {
                    foreach(Point pt in ptChoisi.PA)
                    {
                        if(ptf==pt)
                        {
                            ptChoisi.RetirerPoint(pt);
                        }
                        else
                        {
                            pt.APourOrigine(ptChoisi);
                            Ouvert.Add(pt);
                        }
                    }
                }
            }
            return dist;
        }

        public void FermerPoint(Point pt)
        {
            Ferme.Add(pt);
            Ouvert.Remove(pt);
        }
        public bool EstPresentDansListe(Point P, List<Point> Points)
        {
            bool test = false;
            for (int i = 0; (i < Points.Count) && (!test); i++)
            {
                if (P.Nom == Points[i].Nom)
                    test = true;
            }
            return test;
        }
        public string Afficher (List<Point> lp)
        {
            string affichage = "";
            for(int i =0;i<lp.Count();i++)
            {
                affichage += lp[i].Nom + ", ";
            }
            return affichage;
        }
    }
}
