//Matriz aleatoria
static int[] RandomArray()
{

    int[] numeros = new int[10];
    Random random = new Random();
    for (int i = 0; i < numeros.Length; i++)
    {
        numeros[i] = random.Next(5, 25);
    }
    return numeros;
}
int[] nuevoArray = RandomArray();

int max = 0;
int min = 26;
int sum = 0;
foreach (var item in nuevoArray)
{
    sum += item;
    if (item > max)
    {
        max = item;
    }
    if (item < min)
    {
        min = item;
    }

    /* Console.WriteLine(item); */

}
Console.WriteLine($"valor max:{max}");
Console.WriteLine($"valor min:{min}");
Console.WriteLine($"valor suma total:{sum}");

//Lanzar Moneda
static string TossCoin()
{

    Console.WriteLine("¡Tirando una moneda!");
    Random random = new Random();
    int moneda = random.Next(1, 3);
    string resultado = "";
    if (moneda == 1)
    {
        resultado = "Ha salido cara";
    }
    else
    {
        resultado = "Ha salido sello";
    }

    return resultado;

}
Console.WriteLine(TossCoin());


//Nombres
List<string> listNombres = new List<string>() { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };

static List<string> Nombres( List<string> nombres)
{
    List<string> nuevosNombres = new List<string>();
    for (int i = 0; i < nombres.Count; i++)
    {
        if (nombres[i].Length >5)
        {
            nuevosNombres.Add(nombres[i]);
        }
    }
    return nuevosNombres;
}

List<string> listaNombresMayores = Nombres(listNombres);

foreach (var item in listaNombresMayores)
{
    Console.WriteLine(item);
}