
int muestra = 0;

/*
//Ejercicio 1: por favor tome 5 muestras de temperatura
for (int i = 1; i <  6 ; i++)
{
    
    Console.WriteLine($"Ingrese la muestra:{i}");
    muestra = int.Parse(Console.ReadLine());
    Console.WriteLine($"La muestra {i} :" + muestra.ToString());

}
*/


//Ejercicio 2: por favor tome 10 muestras, y determine el promedio
/*
muestra = 0;

int total = 0;
int cant_muestras = 0;

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"Ingrese la muestra:{i}");
    muestra = int.Parse(Console.ReadLine());
    total += muestra;
    cant_muestras = cant_muestras+1;
    
    Console.WriteLine($"La muestra {i} :" + muestra.ToString());

}

Console.WriteLine("....................................");
Console.WriteLine($"el total es: {total} ");
Console.WriteLine($"la cantidad de muestras es:{cant_muestras} ");
Console.WriteLine("El promedio es: ");
Console.WriteLine(total / cant_muestras);

*/

//Ejercicio 3: por favor indique la cantidad de muestras a tomar, y luego tome 
// las temperaturas y haga el promedio
/*


muestra = 0;

int total = 0;
int cant_muestras = 0;
int cant_solicitada;

Console.WriteLine($"¿Cúantas muestras quiere tomar?");
cant_solicitada= int.Parse(Console.ReadLine());



for (int i = 1; i <  cant_solicitada+1   ; i++)
{
    Console.WriteLine($"Ingrese la muestra:{i}");
    muestra = int.Parse(Console.ReadLine());
    total += muestra;
    cant_muestras = cant_muestras + 1;

    Console.WriteLine($"La muestra {i} :" + muestra.ToString());

}

Console.WriteLine("....................................");
Console.WriteLine($"el total es: {total} ");
Console.WriteLine($"la cantidad de muestras es:{cant_muestras} ");
Console.WriteLine("El promedio es: ");
Console.WriteLine(total / cant_muestras);
*/


// While 

int indice = 5;
while (indice < 10)
{
    Console.WriteLine($"Indice vale:{indice}");
  

}