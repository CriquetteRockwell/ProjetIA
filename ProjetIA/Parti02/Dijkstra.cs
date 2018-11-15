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
        public List<Point> CheminPlusCourt { get; set; }
        public Dijkstra(List<Point> graphe, Point p,Point d)
        {
            Graphe = graphe;
            Premier = p;
            Dernier = d;
            Ouvert = new List<Point>();
            Ferme = new List<Point>();
            CheminPlusCourt = new List<Point>();
        }

        public int Rechercher()
        {
            int dist = 0;
            Ouvert.Add(Premier);
            Premier.DistParcourue = 0;
            //Console.WriteLine("O = [" + Afficher(Ouvert) + "]");
            //Console.WriteLine("F = [" + Afficher(Ferme) + "]");
            //
            //Console.WriteLine("Points fils de A : " +Afficher(Premier.PA));
            //foreach (Point pt in Premier.PA)
            //{
            //    Console.WriteLine("Point fils : "+pt.Nom + "  -  Point Père : " + Premier.Nom);
            //    Console.WriteLine("Points fils du points fils : "+Afficher(pt.PA));
            //    pt.APourOrigine(Premier);
            //    Ouvert.Add(pt);
            //}
            //FermerPoint(Premier);
            //CheminPlusCourt.Add(Premier);

            //Ajouter points suivant dans ouverts

            while (!EstPresentDansListe(Dernier,Ferme))
            {
                Console.WriteLine("O = ["+Afficher(Ouvert)+"]");
                Console.WriteLine("F = ["+Afficher(Ferme)+"]");
                Point ptChoisi=Ouvert[0];

                int plusPetitChemin = ptChoisi.DistParcourue;
                //Selection du point avec la plus petite distance par rapport au début
                if (ptChoisi!=Premier)
                {
                    for (int i = 0; i < Ouvert.Count(); i++)
                    {
                        if (Ouvert[i].CulDeSac)
                        //On enlève les points cul de sac
                        {
                            FermerPoint(Ouvert[i]);
                        }
                        else
                        // On cherche le point avec le poids le moins fort
                        {
                            if (Ouvert[i].DistParcourue < plusPetitChemin)
                            {
                                plusPetitChemin = Ouvert[i].DistParcourue;
                                ptChoisi = Ouvert[i];
                            }
                        }
                    }
                }
                
                FermerPoint(ptChoisi);
                CheminPlusCourt.Add(ptChoisi);
                Console.WriteLine("===>Point choisi : "+ptChoisi.Nom+" ---- Points fils :  " + Afficher(ptChoisi.PA) );
                //On compare les points fermés et des points fils de ptChoisi pour les retirer des possibilités.
                //Faire une fonction qui tej de PA les points déjà dans Fermé.

                foreach (Point pt in ptChoisi.PA)
                {
                    
                    
                    Console.WriteLine("Point fils : " + pt.Nom);
                    pt.APourOrigine(ptChoisi);
                    Ouvert.Add(pt);
                    Console.WriteLine("Point Père : " + pt.Origine.Nom + " -- Distance : " + pt.DistParcourue);
                    Console.WriteLine("Points fils du points fils : " + Afficher(pt.PA));
                    
                }
                
            }
            Console.WriteLine("O = [" + Afficher(Ouvert) + "]");
            Console.WriteLine("F = [" + Afficher(Ferme) + "]");
            Console.WriteLine("Chemin le plus court : " + Afficher(CheminPlusCourt));
            return dist;
        }
        public void RetirerFerme(Point pt)
        {
            foreach(Point ptf in Ferme)
            {
                foreach(Point p in pt.PA)
                {
                    if(ptf==p)
                    {
                        pt.RetirerPoint(p);
                    }
                }
            }
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
                affichage += lp[i].Nom + " ";
            }
            return affichage;
        }
    }
}
