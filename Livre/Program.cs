const int nbLivres = 5;
Livre[] lvs = new Livre[nbLivres];

for (int i = 0; i < nbLivres; ++i)
{
    lvs[i] = new Livre("Bibi", "Les " + (11 - i) + " cavaliers du courage", "Pierre Laroche", i + 1, 1985 + i);
    Console.WriteLine(lvs[i]);
}

Array.Sort(lvs);

for (int i = 0; i < nbLivres; ++i)
{
    Console.WriteLine(lvs[i]);
}