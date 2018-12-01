using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parti02;

namespace arbres
{
    public partial class QDijkstra : Form
    {
        List<Parti02.Point> pointsOuverts = new List<Parti02.Point>();
        List<Parti02.Point> pointsFermes = new List<Parti02.Point>();
        List<Parti02.Point> Points = new List<Parti02.Point>();
        List<Parti02.Point> userOuverts = new List<Parti02.Point>();
        List<Parti02.Point> userFermes = new List<Parti02.Point>();
        List<TreeNode> noeuds1 = new List<TreeNode>();
        List<TreeNode> noeuds2 = new List<TreeNode>();
        int nbrDijkstra;
        int nbrPassage = 0;
        Parti02.Dijkstra dij;
        public QDijkstra()
        {
            
            InitializeComponent();
            Parti02.Point A = new Parti02.Point("A");
            Parti02.Point B = new Parti02.Point("B");
            Parti02.Point C = new Parti02.Point("C");
            Parti02.Point D = new Parti02.Point("D");
            Parti02.Point E = new Parti02.Point("E");
            Parti02.Point F = new Parti02.Point("F");
            Parti02.Point G = new Parti02.Point("G");
            dij = new Dijkstra("A", "E");
            nbrDijkstra = dij.Nombre;
            foreach (Parti02.Point p in dij.Graphe )
            {
                checkedListBoxO.Items.Add(p.Nom);
                checkedListBoxF.Items.Add(p.Nom);
            }

            userOuverts.Add(A);
            listBoxUpdate();
            ajoutArbre();
            InitArbreJuste();
        }

        private void InitArbreJuste()
        {
            arbreJuste.Nodes.Add("A");

            arbreJuste.Nodes[0].Nodes.Add("B");
            arbreJuste.Nodes[0].Nodes.Add("C");

            arbreJuste.Nodes[0].Nodes[0].Nodes.Add("D");
            arbreJuste.Nodes[0].Nodes[0].Nodes.Add("E");

            arbreJuste.Nodes[0].Nodes[1].Nodes.Add("F");
            arbreJuste.Nodes[0].Nodes[1].Nodes.Add("G");
        }
        private void btn_verif_arbre_Click(object sender, EventArgs e)
        {
            lbl_verif_arbre.Text = VerifArbre(treeView1.Nodes, arbreJuste.Nodes).ToString();
        }
        private void ParcoursArbre(TreeNodeCollection nodes,List<TreeNode> noeuds)
        {
            foreach (TreeNode node in nodes)
            {
                noeuds.Add(node);
                ParcoursArbre(node.Nodes,noeuds); 
            }
        }


        private bool VerifArbre(TreeNodeCollection nodes1, TreeNodeCollection nodes2)
        {
            ParcoursArbre(nodes1,noeuds1);
            ParcoursArbre(nodes2, noeuds2);

            for( int i = 0; i<noeuds1.Count; i++)
            {
                if (noeuds1[i].Text != noeuds2[i].Text) { return false; }
            }
            return true;
        }

        private void listBoxUpdate()
        {
            string str1 = "";
            foreach (Parti02.Point p in userOuverts)
            {
                str1 += p.Nom;
            }
            listBoxO.Items.Add(str1);
            
            string str2 = "";
            foreach (Parti02.Point p in userFermes)
            {
                str2 +=p.Nom;
            }
            listBoxF.Items.Add(str2);
            if (str1 == dij.ListeO[nbrPassage] && str2 == dij.ListeF[nbrPassage]) { lbl_verif_suivant.Text = "vrai"; }
            else { lbl_verif_suivant.Text = "faux"; }
            

        }
        private void btn_suivant_Click(object sender, EventArgs e)
        {
            userOuverts.Clear();
            userFermes.Clear();
            foreach (Parti02.Point p in dij.Graphe)
            {
                if (checkedListBoxO.CheckedItems.Count != 0)
                {
                    for (int x = 0; x < checkedListBoxO.CheckedItems.Count; x++)
                    {
                        if (checkedListBoxO.CheckedItems[x].ToString() == p.Nom && (!userOuverts.Contains(p))) { userOuverts.Add(p); }
                    }
                    for (int x = 0; x < checkedListBoxF.CheckedItems.Count; x++)
                    {
                        if (checkedListBoxF.CheckedItems[x].ToString() == p.Nom && (!userFermes.Contains(p))) { userFermes.Add(p); }
                    }
                }
            }
            nbrPassage++;
            if (nbrPassage == nbrDijkstra) { lbl_verif_suivant.Text = "bravo"; }
            else{ listBoxUpdate(); }
            

        }
        private void ajoutArbre()
        {
            treeView1.Nodes.Add("A");

            treeView1.Nodes[0].Nodes.Add("B");
            treeView1.Nodes[0].Nodes.Add("C");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("D");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("E");

            treeView1.Nodes[0].Nodes[1].Nodes.Add("F");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("G");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* private  Dijkstra Djikstra(Point A, Point B, Point C, Point D, Point E, Point F, Point G)
        {
            // Construction point A
           List<Point> paA = new List<Point>();
            paA.Add(B); paA.Add(C);
            List<int> dpaA = new List<int>();
            dpaA.Add(5); dpaA.Add(4);
            A.AjouterPA(paA, dpaA);

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

            Points.Add(A); Points.Add(B); Points.Add(C); Points.Add(D); Points.Add(E); Points.Add(F); Points.Add(G);

        Dijkstra d = new Dijkstra( "A", "E");
            return d;
        }*/

        
    }
}
