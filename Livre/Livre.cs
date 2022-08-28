using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Livre : IComparable<Livre>
{
    //Attributs
    public String Editeur { get; }

    public String Titre { get; }

    public String Auteur { get; }

    private int _NbPages;
    public int NbPages
    {
        get { return _NbPages; }
        set { if (value >= 1) _NbPages = value; else throw new ArgumentException("Nombre de pages inférieur à 1"); }
    }

    public int Annee { get; }



    //Constructeur
    public Livre(string editeur, string titre, string auteur, int nbPages, int annee)
    {
        Editeur = editeur;
        Titre = titre;
        Auteur = auteur;
        NbPages = nbPages;
        Annee = annee;
    }



    //ToString
    public override String ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Editeur:");
        sb.Append(Editeur);

        sb.Append(" Titre:");
        sb.Append(Titre);

        sb.Append(" Auteur:");
        sb.Append(Auteur);

        sb.Append(" Nombre de pages:");
        sb.Append(NbPages);

        sb.Append(" Annee:");
        sb.Append(Annee);

        return sb.ToString();
    }



    //Comparer
    public int CompareTo(Livre other)
    {
        for(int i = 0; i < other.Titre.Length || i < Titre.Length; ++i)
        {
            if (Titre.ElementAt(i) < other.Titre.ElementAt(i))
                return -1;
            else if (Titre.ElementAt(i) > other.Titre.ElementAt(i))
                return 1;
        }

        if (Titre.Length < other.Titre.Length)
            return -1;
        if (Titre.Length < other.Titre.Length)
            return 1;

        return 0;
    }
}
