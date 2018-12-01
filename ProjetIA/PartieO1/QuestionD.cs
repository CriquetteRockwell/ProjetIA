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

namespace PartieO1
{
    public partial class QuestionD : Form
    {
        static System.Windows.Forms.Timer myTimer = new Timer();

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
        qcm form1= new qcm();
        public int nbrPoints = 0;

        public QuestionD()
        {
            InitializeComponent();
            Parti02.Point A = new Parti02.Point("A");
            Parti02.Point B = new Parti02.Point("B");
            Parti02.Point C = new Parti02.Point("C");
            Parti02.Point D = new Parti02.Point("D");
            Parti02.Point E = new Parti02.Point("E");
            Parti02.Point F = new Parti02.Point("F");
            Parti02.Point G = new Parti02.Point("G");
            dij = new Dijkstra("A", "F");
            nbrDijkstra = dij.Nombre;
            foreach (Parti02.Point p in dij.Graphe)
            {
                checkedListBoxO.Items.Add(p.Nom);
                checkedListBoxF.Items.Add(p.Nom);
            }

            userOuverts.Add(A);
            listBoxUpdate();
            ajoutArbre();
            InitArbreJuste();

        }

        private void ajoutArbre()
        {
            treeView1.Nodes.Add("");
            AjouterChildNodeEleve(treeView1.Nodes[0].Nodes, dij.Premier);
        }

        private void AjouterChildNodeEleve(TreeNodeCollection arbre, Parti02.Point O)
        {
            int i = 0;
            foreach (Parti02.Point p in dij.Ferme)
            {
                if (p != dij.Premier)
                {
                    if (p.Origine == O)
                    {
                        arbre.Add("");
                        AjouterChildNodeEleve(arbre[i].Nodes, p);
                        i++;
                    }
                }

            }
        }

        private void InitArbreJuste()
        {
            arbreJuste.Nodes.Add(dij.Premier.Nom + ":" + dij.Premier.DistParcourue);
            AjouterChildNode(arbreJuste.Nodes[0].Nodes, dij.Premier);
        }

        private void AjouterChildNode(TreeNodeCollection arbre, Parti02.Point O)
        {
            int i = 0;
            foreach (Parti02.Point p in dij.Ferme)
            {
                if (p != dij.Premier)
                {
                    if (p.Origine == O)
                    {
                        arbre.Add(p.Nom + ":" + p.DistParcourue);
                        AjouterChildNode(arbre[i].Nodes, p);
                        i++;
                    }
                }

            }
        }
        
        private void ParcoursArbre(TreeNodeCollection nodes, List<TreeNode> noeuds)
        {
            foreach (TreeNode node in nodes)
            {
                noeuds.Add(node);
                ParcoursArbre(node.Nodes, noeuds);
            }
        }


        private bool VerifArbre(TreeNodeCollection nodes1, TreeNodeCollection nodes2)
        {
            ParcoursArbre(nodes1, noeuds1);
            ParcoursArbre(nodes2, noeuds2);

            for (int i = 0; i < noeuds1.Count; i++)
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
                str2 += p.Nom;
            }
            listBoxF.Items.Add(str2);
            if (str1 == dij.ListeO[nbrPassage] && str2 == dij.ListeF[nbrPassage]) { lbl_verif_suivant.Text = "vrai"; }
            else
            {
                lbl_verif_suivant.Text = "faux";
            }


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
            if (nbrPassage == nbrDijkstra) { lbl_verif_suivant.Text = "bravo";nbrPoints += 2; }
            else { listBoxUpdate(); }
        }

        private void btn_verif_arbre_Click(object sender, EventArgs e)
        {
            if (VerifArbre(treeView1.Nodes, arbreJuste.Nodes)) { lbl_verif_arbre.Text = "bravo, plus 1 point !"; nbrPoints += 1; }
            else { lbl_verif_arbre.Text = "Dommage !"; }
            
        }

        private void btn_validation_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
