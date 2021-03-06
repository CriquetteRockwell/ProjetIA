﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parti02
{
    public class Point
    {
        //Pb : Il faut pouvoir créer les points sans avoir besoin d'autres points. A tester next time
        public string Nom { get; set; }
        public List<Point> PA { get; set; } //Points Adjacents
        public List<int> DistPA { get; set; }
        public int DistParcourue { get; set; }
        public bool CulDeSac;
        public Point Origine;
        public Point(string n)
        {
            Nom = n;
            DistParcourue = 0;
            CulDeSac = false;
            PA = new List<Point>();
            DistPA = new List<int>();
        }

        public void AjouterPA(List<Point> pa, List<int> dpa)
        {
            PA = pa;
            DistPA = dpa;
            this.EstCulDeSac();
        }
        public void CalculeDistanceParcourue()
        {
            
        }

        public void RetirerPoint(Point pt)
        {
            int index = PA.IndexOf(pt);
            PA.Remove(pt);
            DistPA.RemoveAt(index);
        }
        public void AjouterPoint(Point pt, int dist)
        {
            PA.Add(pt);
            DistPA.Add(dist);
        }
        public void APourOrigine(Point origine)
        {
            Origine = origine;
            DistParcourue = Origine.DistParcourue + DistPA[PA.IndexOf(Origine)];
            RetirerPoint(Origine);
            EstCulDeSac();
        }

        public void EstCulDeSac()
        {
            if(PA.Count==0)
            {
                CulDeSac = true;
            }
        }

        public void AfficherPointsAdjacents()
        {
            string affichage = "Liens de "+Nom+": \n";
            foreach (Point pt in PA)
            {
                affichage += pt.Nom;
            }
            Console.WriteLine(affichage);
        }

        public static int CompareNom(Point p1, Point p2)
        {
            return p1.Nom.CompareTo(p2.Nom);
        }
    }
    //Il faudra retirer les point fermés
    //public void PointPlusProche()
    //{
    //    if(PA.Count()!=0)
    //    {
    //        int indexmin = 0;
    //        for (int i = 1; i < PA.Count(); i++)
    //        {
    //            if (DistPA.ElementAt(i) < DistMin)
    //            {
    //                indexmin = i;
    //            }
    //        }
    //        PtMin = PA.ElementAt(indexmin);
    //        DistMin = DistPA.ElementAt(indexmin);
    //    }
    //    else
    //    {
    //        DistMin = -1;
    //    }
    //}
}
