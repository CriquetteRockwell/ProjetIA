using System.Xml;
//
namespace PartieO1
{
    class lecteurXML
    {

        public string Image(int num, string fichier)
        {
            //lis le fichier xml "fichier"
            //renvoie le chemin local de l'image de la question de l'indice demandé
            string x = num.ToString();
            XmlTextReader reader = new XmlTextReader(fichier);
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (reader.Name.Equals("question") && reader.GetAttribute("indice").Equals(x))
                {
                    return reader.GetAttribute("image");
                }
            }
            return "oupsy doopsy";
        }
        public string retournerQuestion(int num, string fichier)
        {
            //lis le fichier xml "fichier"
            //renvoie l'énoncé de la question de l'indice demandé
            string x = num.ToString();
            XmlTextReader reader = new XmlTextReader(fichier);
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (reader.Name.Equals("question") && reader.GetAttribute("indice").Equals(x))
                {
                    return reader.GetAttribute("nom");
                }
            }
            return "oupsy doopsy";
        }
        public string retournerReponse(int numQ, int numR, string fichier)
        {
            //lis le fichier xml "fichier"
            // renvoie l'énoncé de la réponse d'indice numR de la question d'indice numQ 
            string question = numQ.ToString();
            string reponse = numR.ToString();
            XmlTextReader reader = new XmlTextReader(fichier);
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (reader.Name.Equals("question") && reader.GetAttribute("indice").Equals(question))
                {
                    switch (numR)
                    {
                        case 1:
                            return reader.GetAttribute("rep1");
                        case 2:
                            return reader.GetAttribute("rep2");
                        case 3:
                            return reader.GetAttribute("rep3");
                        case 4:
                            return reader.GetAttribute("rep4");
                    }
                }
            }
            return "oupsy doopsy";
        }
        public string retournerReponseJusteString(int numQ, string fichier)
        {
            //lis le fichier xml "fichier"
            // renvoie l'énoncé de la réponse juste de la question d'indice numQ
            return retournerReponse(numQ, retournerReponseJusteInt(numQ, fichier), fichier);
        }

        public int retournerReponseJusteInt(int numQ, string fichier)
        {
            //lis le fichier xml "fichier"
            // renvoie l'indice de la réponse juste de la question d'indice numQ
            string question = numQ.ToString();
            XmlTextReader reader = new XmlTextReader(fichier);
            int rep = 5;
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (reader.Name.Equals("question") && reader.GetAttribute("indice").Equals(question))
                {
                    rep = int.Parse(reader.GetAttribute("bonneR"));
                    return rep;
                }
            }
            return rep;
        }


        public bool verificationReponse(int rep, int numQ, string fichier)
        {
            //lis le fichier xml "fichier"
            // compare la reponse entrée et la réponse juste de la question d'indice numQ
            if (rep == retournerReponseJusteInt(numQ, fichier)) { return true; }
            else { return false; }
        }

        public int retournerPoids(int numQ, string fichier)
        {
            //lis le fichier xml "fichier"
            // retourner le poids de la question d'indice numQ
            string question = numQ.ToString();
            XmlTextReader reader = new XmlTextReader(fichier);
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (reader.Name.Equals("question") && reader.GetAttribute("indice").Equals(question))
                {
                    return int.Parse(reader.GetAttribute("poids"));
                }
            }
            return 0;
        }
    }
}
