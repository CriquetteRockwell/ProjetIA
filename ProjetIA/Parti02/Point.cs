using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parti02
{
    class Point
    {
        //Pb : Il faut pouvoir créer les points sans avoir besoin d'autres points. A tester next time
        public string Nom { get; set; }
        public List<Point> PA { get; set; } //Points Adjacents
        public List<int> DistPA { get; set; }
        public int DistParcourue { get; set; }
        public bool CulDeSac;
        public Point Origine;
        public Point(string n, List<Point> pa, List<int> dpa)
        {
            Nom = n;
            PA = pa;
            DistPA = dpa;
            DistParcourue = 100000;
            CulDeSac = false;
            this.EstCulDeSac();
        }

        public void CalculeDistanceParcourue()
        {
            DistParcourue = Origine.DistParcourue + DistPA[PA.IndexOf(Origine)];
        }

        public void RetirerPoint(Point pt)
        {
            int index = PA.IndexOf(pt);
            PA.Remove(pt);
            DistPA.RemoveAt(index);
        }
        public void APourOrigine(Point origine)
        {
            Origine = origine;
            this.RetirerPoint(Origine);
        }

        public void EstCulDeSac()
        {
            if(PA.Count==0)
            {
                CulDeSac = true;
            }
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
