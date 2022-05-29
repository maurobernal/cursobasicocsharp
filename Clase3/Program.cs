//Comparación (operador binario), que devuelve un true o false 
/*
< menor
> mayor
== igual  (= asignacion)
*/
/*
if( 5==5 )
{
    Console.WriteLine("Se ejecutó la primera vez");
    Console.WriteLine("Se ejecutó la primera vez");
    Console.WriteLine("Se ejecutó la primera vez");
    Console.WriteLine("Se ejecutó la primera vez");

}


if (5>2)
{
    Console.WriteLine("Se ejecutó la segunda vez");
    Console.WriteLine("Se ejecutó la segunda vez");
    Console.WriteLine("Se ejecutó la segunda vez");
    Console.WriteLine("Se ejecutó la segunda vez");
    Console.WriteLine("Se ejecutó la segunda vez");
}
*/
//Ejercicio número 1:
/*
 *  1-Pedir un color al usuario
 *  2- Si el color es Rojo, avisarle que no hay stock
 *  3- Si el color es Verde, avisarle que hay demora en la entrega
 *  4- Si el color es Azul, indicarle que tenemos stock
 * 
 * 
 * */
/*
Console.WriteLine("Bienvenido. Por favor ingrese su color a pedir:");
string color=Console.ReadLine();

if (color=="rojo")
{
    Console.WriteLine("No hay stock");
}
if (color == "verde")
{
    Console.WriteLine("Hay demora en la entrega");
}
if (color == "azul")
{
    Console.WriteLine("Tenemos stock");
}
*/
//Ejercicio número 2:

/*  1-Pedir un color al usuario
 *  2- Si el color es Rojo, avisarle que no hay stock
 *  3- Si el color es Verde, avisarle que hay demora en la entrega
 *  4- Si el color es Azul, indicarle que tenemos stock
 *  5- Si es otro color indicarle que tenemos stock

*/
/*
Console.WriteLine("Bienvenido. Por favor ingrese su color a pedir:");
string color = Console.ReadLine();

if (color == "rojo")
{
    Console.WriteLine("No hay stock");
}

if (color == "verde")
{
    Console.WriteLine("Hay demora en la entrega");
}
if (color == "azul")
{
    Console.WriteLine("Tenemos stock");
} else
{
    Console.WriteLine("Tenemos stock");
}
*/

/*
Console.WriteLine("Bienvenido. Por favor ingrese su color a pedir:");
string color = Console.ReadLine();

if (color == "rojo")
{
    Console.WriteLine("No hay stock");
} else if (color == "verde")
{
    Console.WriteLine("Hay demora en la entrega");
} else if (color == "azul")
{
    Console.WriteLine("Tenemos stock en azul");
}
else
{
    Console.WriteLine("Tenemos stock en el resto");
}
*/

//Ejercicio número 3 :
// Repetir el ejercicio con la estructura switch
/*  1-Pedir un color al usuario
 *  2- Si el color es Rojo, avisarle que no hay stock
 *  3- Si el color es Verde, avisarle que hay demora en la entrega
 *  4- Si el color es Azul, indicarle que tenemos stock
 *  5- Si es otro color indicarle que tenemos stock
*/
/*
Console.WriteLine("Bienvenido. Por favor ingrese su color a pedir:");
string color = Console.ReadLine();

switch (color)
{
    case "Rojo":
        Console.WriteLine("No hay stock");
    break;

    case "Verde":
        Console.WriteLine("Hay demora");
        break;

    case "Azul":
        Console.WriteLine("Hay stock azul");
        break;

    default:
        Console.WriteLine("Hay stock");
        break;
}

*/

/*
 * Ejercicio 3 determinar si un numero es par 
 * e indicarle al usuario mediante la estructura
 * de control selectiva switch
 * */

Console.WriteLine("Ingrese su número");
int num = 0;
int.TryParse( Console.ReadLine(), out num);
Console.WriteLine("El nro ingresado es:"+ num );

int resto = num - (num / 2 *2);
Console.WriteLine("El resto es:"+ resto );
switch (resto)
{
    case 0:
        Console.WriteLine("El número es par");
        break;

    case 1:
        Console.WriteLine("El número es impar");
        break;
    default:
        Console.WriteLine("La operación falló");
        break;
}