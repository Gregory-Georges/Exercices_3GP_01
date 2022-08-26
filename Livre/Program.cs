const int nbLivres = 5;
Livre[] lvs = new Livre[nbLivres];

for (int i = 0; i < nbLivres; ++i)
{
    lvs[i] = new Livre("Les " + (i + 1) + " cavaliers du courage", "Bibi", "Pierre Laroche", i + 1, 1985 + i);
    Console.WriteLine(lvs[i]);
}