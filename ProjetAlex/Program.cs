
// on demande la saisie d'un nombre à l'utilisateur et on corrige éventuellement le point en virgule
Console.WriteLine("Ecrire un nombre de votre choix ?");
string nbsaisi01 = Console.ReadLine();
nbsaisi01 = nbsaisi01.Replace('.', ',');


// on transforme la saisie string en nombre décimal et on l'affecte à nb01
bool succes01 = decimal.TryParse(nbsaisi01, out decimal nb01);


if (succes01 == true)
{
    if (nb01 < 0)
    {
        Console.WriteLine("Le nombre est négatif");
    }


    else if (nb01 == 0)
    {
        Console.WriteLine("Le nombre est nul");
    }



    else if (nb01 > 0)
    {
        Console.WriteLine("Le nombre est positif");
    }
}
else
{
    Console.WriteLine("Je ne sais pas déterminer le signe de votre saisie !");
}


