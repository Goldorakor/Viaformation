// See https://aka.ms/new-console-template for more information
using System;
// See https://aka.ms/new-console-template for more information
using System;


// on demande la saisie d'un premier nombre à l'utilisateur et on corrige éventuellement le point en virgule
Console.WriteLine("Ecrire un nombre de votre choix ?");
string nbsaisi01 = Console.ReadLine();
nbsaisi01 = nbsaisi01.Replace('.', ',');


// on demande la saisie d'un second nombre à l'utilisateur et on corrige éventuellement le point en virgule
Console.WriteLine("Ecrire un autre nombre de votre choix ?");
string nbsaisi02 = Console.ReadLine();
nbsaisi02 = nbsaisi02.Replace('.', ',');


// on transforme la saisie string en nombre décimal et on l'affecte à nb01 et nb02
bool succes01 = decimal.TryParse(nbsaisi01, out decimal nb01);
bool succes02 = decimal.TryParse(nbsaisi02, out decimal nb02);


if (succes01 == true && succes02 == true)
{
    if ((nb01 < 0 && nb02 < 0) || (nb01 > 0 && nb02 > 0))
    {
        Console.WriteLine("Le produit des nombres est positif");
    }


    else if ((nb01 < 0 && nb02 > 0) || (nb01 > 0 && nb02 < 0))
    {
        Console.WriteLine("Le produit des nombres est négatif");
    }

  

    else if (nb01 == 0 || nb02 == 0)
    {
        Console.WriteLine("Le produit des nombres vaut zéro");
    }
}
else
{
    Console.WriteLine("Je ne sais pas déterminer le signe du produit!");
}



