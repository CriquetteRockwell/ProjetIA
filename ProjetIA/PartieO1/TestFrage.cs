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

        public TestFrage(string question, List<string> reponses, int bonneReponse)
        {
            Question = question;
            Reponses = reponses;
            BonneReponse = bonneReponse;
        }
    }
}
