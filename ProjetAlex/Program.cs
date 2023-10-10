
// on demande la saisie d'un nombre à l'utilisateur et on corrige éventuellement le point en virgule
Console.WriteLine("Merci de m'indiquer ton âge afin que je te donne ta catégorie.");
string nbsaisi01 = Console.ReadLine();
nbsaisi01 = nbsaisi01.Replace('.', ',');


// on transforme la saisie string en nombre décimal et on l'affecte à nb01
bool succes01 = decimal.TryParse(nbsaisi01, out decimal nb01);


if (succes01 == true)
{

    if (nb01<0)
    {
        Console.WriteLine($"Tu m'as donné un âge négatif, ne penses-tu pas plutôt avoir {-nb01} ans");
    }

    if (nb01 >= 0 && nb01 < 6)
    {
        Console.WriteLine("Tu es encore trop jeune pour être inscrit dans une catégorie !");
    }

    else if (nb01 == 6 || nb01 == 7)
    {
        Console.WriteLine("Tu es dans la catégorie Poussin");
    }

    else if (nb01 == 8 || nb01 == 9)
    {
        Console.WriteLine("Tu es dans la catégorie Pupille");
    }

    else if (nb01 == 10 || nb01 == 11)
    {
        Console.WriteLine("Tu es dans la catégorie Minime");
    }

    else if (nb01 == 12 || nb01 > 12)
    {
        Console.WriteLine("Tu es dans la catégorie Cadet");
    }

}
else
{
    Console.WriteLine("Je ne sais pas déterminer votre catégorie !");
}

