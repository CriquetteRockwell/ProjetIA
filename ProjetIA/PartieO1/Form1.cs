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
        private lecteurXML Acces = new lecteurXML();
        public int sommePoids { get; set; }

        public qcm()
        {
            InitializeComponent();
            Index = 0;
            Indexs = new List<int>();
            InitListeIndex();

            CptPoints = 0;
            CptProgression = 0;
            sommePoids = 0;

            Questions = new List<TestFrage>();

            List<int> numQuestions = new List<int>();

            for (int k = 0; k < 19; k++)
            {
                int num = r.Next(1, 30);
                while(numQuestions.Contains(num))
                { num = r.Next(1, 30); }
                numQuestions.Add(num);
            }

            foreach(int q in numQuestions)
            { AjouterQ(q, "questions.xml"); }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {

            ChangerQuestion();
            panel1.Visible = true;
        }

        private void NextBttn_Click(object sender, EventArgs e)
        {
            ChangerQuestion();
            if (Index == -1){
                QuestionD form2 = new QuestionD();
                form2.ShowDialog();
                CptPoints += form2.nbrPoints;
                panel2.Visible = true;
            }
            else {VerifierRep(); }
        }

        public void ChangerQuestion()
        {
            rbA.Checked = true;
            if (Indexs.Count != 0)
            {
                Index = Indexs[r.Next(Indexs.Count)];
                Indexs.Remove(Index);

                numQuestion.Text = (19 - Indexs.Count()).ToString();

                TestFrage question = Questions[Index];
                rbA.Text = question.Reponses[0];
                rbB.Text = question.Reponses[1];
                rbC.Text = question.Reponses[2];
                rbD.Text = question.Reponses[3];
                questionLabel.Text = question.Question;
                pictureBox1.ImageLocation = question.Image;

            }
            else
            {
                Index = -1;
                double score = CptPoints*20 / sommePoids;
                scoreLabel.Text = "" + score + " / 20";
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
            for (int i = 0; i <19; i++)
            {
                Indexs.Add(i);
            }
        }

        public void VerifierRep()
        {
            int points = Questions[Index].Poids;
            switch (Questions[Index].BonneReponse)
            {
                case 1:
                    if (rbA.Checked)
                        CptPoints+=points;
                    break;
                case 2:
                    if (rbB.Checked)
                        CptPoints += points;
                    break;
                case 3:
                    if (rbC.Checked)
                        CptPoints += points;
                    break;
                case 4:
                    if (rbD.Checked)
                        CptPoints += points;
                    break;
                default:
                    break;
            }
            sommePoids += Questions[Index].Poids;
        }
        public void AjouterQ(int numQ, string fichier)
        {
            List<string> reponses = new List<string>();
            reponses.Add(Acces.retournerReponse(numQ, 1, "questions.xml")); reponses.Add(Acces.retournerReponse(numQ, 2, "questions.xml")); reponses.Add(Acces.retournerReponse(numQ, 3, "questions.xml")); reponses.Add(Acces.retournerReponse(numQ, 4, "questions.xml"));
            Questions.Add(new TestFrage(Acces.retournerQuestion(numQ, "questions.xml"), reponses, Acces.retournerReponseJusteInt(numQ, "questions.xml"), Acces.retournerPoids(numQ, "questions.xml"),Acces.Image(numQ,"questions.xml")));
        }

    }
}