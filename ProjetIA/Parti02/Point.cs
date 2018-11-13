using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parti02
{
    class Point
    {
        public string Nom { get; set; }
        public List<Point> PA { get; set; } //Points Adjacents
        public List<int> DistPA { get; set; }
        public int DistParcourue { get; set; }
        public Point PtMin;
        public int DistMin;
        public Point(){}
        public Point(string n, List<Point> pa, List<int> dpa)
        {
            Nom = n;
            PA = pa;
            DistPA = dpa;
            DistParcourue = 100000;
            this.PointPlusProche();
        }
        //Il faudra retirer les point fermés
        public void PointPlusProche()
        {
            if(PA.Count()!=0)
            {
                int indexmin = 0;
                for (int i = 1; i < PA.Count(); i++)
                {
                    if (DistPA.ElementAt(i) < DistMin)
                    {
                        indexmin = i;
                    }
                }
                PtMin = PA.ElementAt(indexmin);
                DistMin = DistPA.ElementAt(indexmin);
            }
            else
            {
                DistMin = -1;
            }
            
            
        }

        public void RetirerPoint(Point pt)
        {
            int index = PA.IndexOf(pt);
            PA.Remove(pt);
            DistPA.RemoveAt(index);
        }

    }
}
