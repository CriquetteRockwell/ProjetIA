using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartieO1
{
    public partial class qcm : Form
    {
        public static Random r = new Random();

        public int Index { get; set; }
        public List<int> Indexs { get; set; }
        public int CptPoints { get; set; }
        public int CptProgression { get; set; }
        List<TestFrage> Questions { get; set; }

        public qcm()
        {
            InitializeComponent();
            Index = 0;
            Indexs = new List<int>();
            InitListeIndex();

            CptPoints = 0;
            CptProgression = 0;
            Questions = new List<TestFrage>();

            List<string> reponses1 = new List<string>();
            reponses1.Add("Ta mère"); reponses1.Add("L'univers"); reponses1.Add("L'ego de Claverie"); reponses1.Add("D : la répiinse D");

            List<string> reponses2 = new List<string>();
            reponses2.Add("Les pd"); reponses2.Add("Les roux"); reponses2.Add("Les femmes"); reponses2.Add("Les noirs");

            Questions.Add(new TestFrage("Qu'est-ce qui est le plus gros ?", reponses1, 0));
            Questions.Add(new TestFrage("Qu'est-ce qui mérite le plus de brûler en enfer ?", reponses2, 1));
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {

            ChangerQuestion();
            panel1.Visible = true;
        }

        private void NextBttn_Click(object sender, EventArgs e)
        {
            VerifierRep();
            ChangerQuestion();
            if (Index == -1)
            {
                panel2.Visible = true;
            }
        }

        public void ChangerQuestion()
        {
            rbA.Checked = true;
            if (Indexs.Count != 0)
            {
                Index = Indexs[r.Next(Indexs.Count)];
                Indexs.Remove(Index);

                TestFrage question = Questions[Index];
                rbA.Text = question.Reponses[0];
                rbB.Text = question.Reponses[1];
                rbC.Text = question.Reponses[2];
                rbD.Text = question.Reponses[3];
                questionLabel.Text = question.Question;

            }
            else
            {
                Index = -1;
                scoreLabel.Text = "" + CptPoints + " / 20";
            }
        }

        private void homeBttn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false; panel2.Visible = false;
            CptPoints = 0;
            InitListeIndex();
            Index = 0;
        }

        private void InitListeIndex()
        {
            for (int i = 0; i < 2; i++)
            {
                Indexs.Add(i);
            }
        }

        public void VerifierRep()
        {
            switch (Questions[Index].BonneReponse)
            {
                case 0:
                    if (rbA.Checked)
                        CptPoints++;
                    break;
                case 1:
                    if (rbB.Checked)
                        CptPoints++;
                    break;
                case 2:
                    if (rbC.Checked)
                        CptPoints++;
                    break;
                case 3:
                    if (rbD.Checked)
                        CptPoints++;
                    break;
                default:
                    break;
            }
        }
    }
}