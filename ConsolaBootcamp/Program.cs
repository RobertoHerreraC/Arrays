// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Funciones Genericas

int obtenerEntradaInt()
{
    int entrada = Convert.ToInt32(Console.ReadLine());
    return entrada;
}

string obtenerEntradaString()
{
    string entrada = Console.ReadLine();
    return entrada;
}


/********Ejercicios************************/

//Recibir un arreglo de enteros y lo rote N veces hacia la derecha
void rotarHaciaDerecha()
{
    int longitudArreglo = 0;
    int[] arrayEnteros;
    int [] arrayResultado;
    int rotacion = 0;
    Console.WriteLine("Ingresar la cantidad de valores del arreglo:");
    longitudArreglo = obtenerEntradaInt();
    arrayEnteros = new int[longitudArreglo];
    arrayResultado = new int[longitudArreglo];
    for (int i = 0; i < longitudArreglo; i++)
    {
        Console.WriteLine($"Ingresar el valor {i+1}:");
        arrayEnteros[i] = obtenerEntradaInt();
    }

    do
    {
        Console.WriteLine("Ingresar el numero de rotación:");
        rotacion = obtenerEntradaInt();
        if (rotacion > longitudArreglo)
        {
            Console.WriteLine("El numero de rotación no debe ser mayor a la cantidad de arreglo. Intente de nuevo.");
        }
    } while (rotacion > longitudArreglo);

    for (int i = 0;i < longitudArreglo; i++)
    {
        arrayResultado[(i+rotacion)%longitudArreglo] = arrayEnteros[i];
    }
    Console.WriteLine("Resultado:");
    foreach (var item in arrayResultado)
    {
        Console.WriteLine($"{item}");
    }

}

//Recibir una lista de string y eliminar todos los elementos duplicados y mostrar todos los elementos unicos
void elimnarDuplicadoList()
{
    List<string> listaString = new List<string> ();
    List<string> resultado = new List<string>();
    string entrada = string.Empty;

    while (!entrada.ToUpper().Equals("SALIR")){
        Console.WriteLine("Ingresar los valores o presion [salir] para dejar de ingresar:");
        entrada = obtenerEntradaString();
        if (!entrada.ToUpper().Equals("SALIR"))
        {
            listaString.Add (entrada); 
        }
    }

    foreach (string item in listaString)
    {
        if (!resultado.Contains(item))
        {
            resultado.Add(item);
        }
    }
    Console.WriteLine("Resultado");
    foreach (var item in resultado)
    {
        Console.WriteLine(item);
    }


}

/****Ejecuciones***/
string numeroEjercicio = string.Empty ;
do
{
    Console.WriteLine("Ingrese el ejercicio:");
    Console.WriteLine("[1] Rotar hacia la derecha.");
    Console.WriteLine("[2] Eliminar duplicados.");
    Console.WriteLine("[s] Salir");
    numeroEjercicio = obtenerEntradaString();
    switch (numeroEjercicio)
    {
        case "1":
            rotarHaciaDerecha();
            break;
        case "2":
            elimnarDuplicadoList();
            break;
        default:
            break;
    }

} while (!numeroEjercicio.ToUpper().Equals("S"));
