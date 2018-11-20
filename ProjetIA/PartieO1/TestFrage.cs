using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartieO1
{
    class TestFrage
    {
        public string Question { get; set; }
        public List<string> Reponses { get; set; }
        public int BonneReponse { get; set; }
        public int Poids { get; set; }
        public string Image { get; set; }

        public TestFrage(string question, List<string> reponses, int bonneReponse, int poids, string image)
        {
            Question = question;
            Reponses = reponses;
            BonneReponse = bonneReponse;
            Poids = poids;
            Image = image;
        }
    }
}
