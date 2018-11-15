using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parti02
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Parti02.Point("A");
            Point B = new Parti02.Point("B");
            Point C = new Parti02.Point("C");
            Point D = new Parti02.Point("D");
            Point E = new Parti02.Point("E");
            Point F = new Parti02.Point("F");
            Point G = new Parti02.Point("G");
            // Construction point A
            List<Point> paA = new List<Point>();
            paA.Add(B); paA.Add(C);
            List<int> dpaA = new List<int>();
            dpaA.Add(5); dpaA.Add(4);
            A.AjouterPA(paA,dpaA);

            //Construction point B
            List<Point> paB = new List<Point>();
            paB.Add(A); paB.Add(D); paB.Add(E);
            List<int> dpaB = new List<int>();
            dpaB.Add(5); dpaB.Add(1); dpaB.Add(2);
            B.AjouterPA(paB, dpaB);

            //Construction point C
            List<Point> paC = new List<Point>();
            paC.Add(A); paC.Add(F); paC.Add(G);
            List<int> dpaC = new List<int>();
            dpaC.Add(4); dpaC.Add(5); dpaC.Add(7);
            C.AjouterPA(paC, dpaC);

            //Construction point D
            List<Point> paD = new List<Point>();
            paD.Add(B); 
            List<int> dpaD = new List<int>();
            dpaD.Add(1); 
            D.AjouterPA(paD, dpaD);

            //Construction point E
            List<Point> paE = new List<Point>();
            paE.Add(B); paE.Add(F);
            List<int> dpaE = new List<int>();
            dpaE.Add(2); dpaE.Add(3);
            E.AjouterPA(paE, dpaE);

            //Construction point F
            List<Point> paF = new List<Point>();
            paF.Add(C); paF.Add(E);
            List<int> dpaF = new List<int>();
            dpaF.Add(5); dpaF.Add(3);
            F.AjouterPA(paF, dpaF);

            //Construction point G
            List<Point> paG = new List<Point>();
            paG.Add(C); 
            List<int> dpaG = new List<int>();
            dpaG.Add(7); 
            G.AjouterPA(paG, dpaG);
            List<Point> Points = new List<Point>();
            Points.Add(A); Points.Add(B); Points.Add(C); Points.Add(D); Points.Add(E); Points.Add(F); Points.Add(G);

            Dijkstra d = new Dijkstra(Points,A,F);
            d.Rechercher();

        }
    }
}
