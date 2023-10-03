// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Ecrire un nombre de votre choix ?");
string nbsaisi = Console.ReadLine();
nbsaisi = nbsaisi.Replace('.' , ',');


// decimal nb = decimal.Parse(nbsaisi);

bool succes = decimal.TryParse(nbsaisi, out decimal nb);

if (succes == true)
{
    if (nb < 0)
    {
        Console.WriteLine("Le nombre écrit est négatif");
    }

    else if (nb > 0)
    {
        Console.WriteLine("Le nombre écrit est positif");
    }

    else if (nb == 0)
    {
        Console.WriteLine("Le nombre écrit vaut zéro");
    }

  
}
else
{
    Console.WriteLine("Je ne sais pas déterminer le signe de ce nombre!");
}



