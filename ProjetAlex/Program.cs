// on demande la saisie d'un nombre à l'utilisateur
Console.WriteLine("Merci de m'indiquer un nombre pour définir la taille du tableau.");
string nbsaisi01 = Console.ReadLine();

// on transforme la saisie string en nombre entier et on l'affecte à nb01
bool succes01 = int.TryParse(nbsaisi01, out decimal nb01);



// Solution plus évolutive avec boucle for :
if (succes01 == true)
{
    int[] tableau2 = new int[nb01];

for (int i=0; i<nb01; i++)
{
    tableau2[i] = i;
}
}
else
{
    Console.WriteLine("Je ne sais pas déterminer votre tableau !");
}


