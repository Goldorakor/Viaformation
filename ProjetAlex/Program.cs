

// on demande la saisie d'un premier nombre à l'utilisateur et on corrige éventuellement le point en virgule
Console.WriteLine("Ecrire un nombre de votre choix qui est compris entre 1 et 3.");
string nbsaisi01 = Console.ReadLine();
nbsaisi01 = nbsaisi01.Replace('.', ',');

int nb01 = int.Parse(nbsaisi01);

bool saisievalide = nb01 >= 1 && nb01 <= 3;

// controle de la saisie

while (saisievalide == false)
{
    Console.WriteLine("ce nombre n'est pas compris entre 1 et 3.");
    Console.WriteLine("Ecrire un nombre de votre choix qui est compris entre 1 et 3.");
    nbsaisi01 = Console.ReadLine();
    nb01 = int.Parse(nbsaisi01);
    saisievalide = nb01 >= 1 && nb01 <= 3;
}


// message si réponse ok
Console.WriteLine("Bravo, le nombre saisi est compris entre 1 et 3.");

