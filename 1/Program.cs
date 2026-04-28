int VeFila()
{
    int filas;
    bool VFila;

    while (true)
    {
        Console.Write("Ingrese la cantidad de zonas: ");
        VFila=int.TryParse(Console.ReadLine(), out filas);  
        if (VFila == true && filas > 0)
        {
            return filas;
        }
        else
        {
            Console.WriteLine("Zona Ivalida, Presione una tecla para volver a intentar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
int resultadoFila=VeFila();

int VColumna()
{
    int columnas;
    bool VColumnas;

    while (true)
    {
        Console.Write("Ingrese la cantidad de dias: ");
        VColumnas = int.TryParse(Console.ReadLine(), out columnas);
        if (VColumnas== true && columnas > 0)
        {
            return columnas;
        }
        else
        {
            Console.WriteLine("Dias Ivalida, Presione una tecla para volver a intentar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
int resultadoColumnas = VColumna();

int[,] matriz = new int[resultadoFila, resultadoColumnas];

for (int i = 0; i < resultadoFila; i++)
{
    for (int j = 0; j < resultadoColumnas; j++)
    {
        Console.Write($"Ingrese Valor para [{i},{j}]: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0;i < resultadoFila; i++)
{
    for (int j = 0;j < resultadoColumnas; j++)
    {
        Console.Write(matriz[i,j]+" ");
    }
    Console.WriteLine();
}