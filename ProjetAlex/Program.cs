

// on demande la saisie d'un premier nombre à l'utilisateur et on corrige éventuellement le point en virgule
Console.WriteLine("Ecrire un nombre de votre choix qui est compris entre 1 et 3.");
string nbsaisi01 = Console.ReadLine();
nbsaisi01 = nbsaisi01.Replace('.', ',');



// on transforme la saisie string en nombre décimal et on l'affecte à nb01
bool succes01 = decimal.TryParse(nbsaisi01, out decimal nb01);

if succes01 = true

while (nb01 < 1 && nb01 > 3)
{
    nbsaisi01 = Console.ReadLine();
}

  

else
{
    Console.WriteLine("Bravo, votre nombre est bien compris entre 1 et 3");
}



