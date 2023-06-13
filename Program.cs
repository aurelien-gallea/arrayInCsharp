// See https://aka.ms/new-console-template for more information

int[] myIntArray = new int[5] {1,2,3,4,5};

Console.WriteLine("avec la boucle for");
for (int i = 0; i < myIntArray.Length; i++)
{
    Console.WriteLine($"index {i} : {myIntArray[i]}");
} 

Console.WriteLine("avec la boucle foreach");
foreach (int number in myIntArray){
    Console.WriteLine(number);
}

Console.WriteLine("avec la boucle while");
int count = 0;

while (count < myIntArray.Length)
{
    Console.WriteLine(myIntArray[count]);
    count++;

}

Console.WriteLine("avec la boucle do while"); // utile uniquement si le code doit s'effectuer au minimum une fois
int count2 = 0;

do
{
  Console.WriteLine(myIntArray[count2]);
    count2++;  
} while (count2 < myIntArray.Length);

// faire une table de multiplication avec boucles for imbriqués
Console.WriteLine();
Console.WriteLine("les tables de multiplications");
for (int i = 1; i<=10; i++) {

    // utilisation de ternaire pour l'affichage
    Console.Write("   |  ");
    Console.Write(i<10 ? i + "  |  " : i + " |  ");

    for (int j = 2; j <= 10; j++)
    {
        
        if (i*j == 100) {
            Console.Write( i*j + "|");
        
        } else {

            Console.Write(i*j<10 ?  i*j + "  |  " : i*j + " |  ");
        }
    }
    Console.WriteLine();
}