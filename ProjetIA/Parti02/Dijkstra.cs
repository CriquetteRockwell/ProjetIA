using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Parti02
{
    public class Dijkstra
    {
        public List<Point> Graphe { get; set; }
        public List<Point> Ouvert { get; set; }
        public List<Point> Ferme { get; set; }
        public Point Premier { get; set; }
        public Point Dernier { get; set; }
        public List<Point> CheminPlusCourt { get; set; }
        public int Nombre { get; set; }
        public List<string> ListeO { get; set; }
        public List<string> ListeF { get; set; }

        public Dijkstra(string nomPremier, string nomDernier)
        {
            Premier = new Parti02.Point(nomPremier);
            Dernier = new Parti02.Point(nomDernier);
            Graphe = new List<Point>();
            Ouvert = new List<Point>();
            Ferme = new List<Point>();
            CheminPlusCourt = new List<Point>();
            ListeO = new List<string>();
            ListeF = new List<string>();
            LectureTxt();
            Nombre = Rechercher();
        }

        public void CreerPoint(string nom)
        {
            Graphe.Add(new Parti02.Point(nom));
        }

        public bool EstPresent(string nom)
        {
            foreach(Point p in Graphe)
            {
                if(p.Nom == nom)
                {
                    return true;
                }
            }
            return false;
        }

        public void LectureTxt()
        {
            StreamReader monStreamReader = new StreamReader("graphe1.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            

            // Ensuite on a ls tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string N1 = "";
                while (ligne[i] != ' ')
                {
                    N1 = N1 + ligne[i];
                    i++;
                }
                if(!EstPresent(N1))
                {
                    CreerPoint(N1);
                }
                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string N2 = "";
                while (ligne[i] != ' ')
                {
                    N2 = N2 + ligne[i];
                    i++;
                }
                if (!EstPresent(N2))
                {
                    CreerPoint(N2);
                }
                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                int val = int.Parse(strVal);
                Point n1= new Parti02.Point("");
                Point n2 = new Parti02.Point("");
                foreach(Point p in Graphe)
                {
                    if(p.Nom==N1)
                    {
                        n1 = p;
                    }
                    else if (p.Nom == N2)
                    {
                        n2 = p;
                    }
                }
                n1.AjouterPoint(n2,val);
                n2.AjouterPoint(n1, val);
                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
            foreach (Point p in Graphe)
            {
                if (p.Nom == Premier.Nom)
                {
                    Premier = p;
                }
                else if (p.Nom == Dernier.Nom)
                {
                    Dernier = p;
                }
                p.EstCulDeSac();
            }
        }

        public int Rechercher()
        {
            int dist = 0;
            Ouvert.Add(Premier);
            Premier.DistParcourue = 0;

            while (!EstPresentDansListe(Dernier,Ferme))
            {
                Console.WriteLine("O = ["+Afficher(Ouvert)+"]");
                Console.WriteLine("F = ["+Afficher(Ferme)+"]");

                ListeO.Add(Afficher(Ouvert));
                ListeF.Add(Afficher(Ferme));

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
                // On verifie que le point n'est pas en double
                Point pointDouble=new Point("");
                int d = 0;


                foreach(Point pt in Ouvert)
                {
                    if(ptChoisi==pt)
                    {
                        pointDouble = pt;
                        d++;
                    }
                }
                if(pointDouble.Nom!="")
                {
                    for (int k = 0; k < d; k++)
                    {
                        Ouvert.Remove(pointDouble);
                    }
                }
                
                CheminPlusCourt.Add(ptChoisi);
                //Console.WriteLine("===>Point choisi : "+ptChoisi.Nom+" ---- Points fils :  " + Afficher(ptChoisi.PA) );
                //On compare les points fermés et des points fils de ptChoisi pour les retirer des possibilités.

                foreach (Point pt in ptChoisi.PA)
                {
                    
                    
                   // Console.WriteLine("Point fils : " + pt.Nom);
                    pt.APourOrigine(ptChoisi);
                    Ouvert.Add(pt);

                    //Console.WriteLine("Point Père : " + pt.Origine.Nom + " -- Distance : " + pt.DistParcourue);
                    //Console.WriteLine("Points fils du points fils : " + Afficher(pt.PA));
                    
                }
                dist++;   
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
            lp.Sort(Point.CompareNom);
            List<Point> doublons = new List<Point>();
            for (int i = 0; i < lp.Count(); i++)
            {
                if (i != lp.Count() - 1 && lp[i] == lp[i + 1]) { doublons.Add(lp[i]); }
            }
            foreach (Point p in doublons)
            {
                lp.Remove(p);
            }
            for (int i = 0; i < lp.Count(); i++)
            {
                affichage += lp[i].Nom;
            }
            return affichage;

        }
    }
}
