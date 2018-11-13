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
                int plusPetitChemin = Ouvert[0].DistParcourue + Ouvert[0].DistMin;
                int ptChoisi = 0;

                for(int i=0;i<Ouvert.Count();i++)
                {
                    if(Ouvert[i].DistMin==-1)
                        //On enlève les points cul de sac
                    {
                        Ferme.Add(Ouvert[i]);
                        Ouvert.RemoveAt(i);
                    }
                    else
                    // On cherche le point avec le poids le moins fort
                    {
                        if(Ouvert[i].DistParcourue + Ouvert[i].DistMin < plusPetitChemin)
                        {
                            plusPetitChemin = Ouvert[i].DistParcourue + Ouvert[i].DistMin;
                            ptChoisi = i;
                        }
                    }
                }
            }
            return dist;
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
    }
}
