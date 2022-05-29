// See https://aka.ms/new-console-template for more information

//Console.Write() -> escribe en la posición siguiente en donde quedo el cursor
/*
Console.Write("1");
Console.Write("2");
Console.Write("3");
Console.Write("4");
Console.Write("5");
*/
//Console.WriteLine() -> escribe una nueva línea
Console.WriteLine("A");
Console.WriteLine("B");
Console.WriteLine("C");
Console.WriteLine("D");
Console.WriteLine("E");

//Console.Read();
string ingreso=  Console.ReadLine();
Console.WriteLine(ingreso);


//Console.ReadLine()
/*
Console.WriteLine("Ingrese su texto");
string ingreso2 = Console.ReadLine();
Console.WriteLine("Su texto fue:");
Console.WriteLine(ingreso2);

*/




/*  Ejercicio numero 1 Sumar dos numeros ingresados por el usuario         */
// 1- Le vamos a pedir al usuario que ingrese dos números
// 2- Vamos a sumar los dos números
// 3- Vamos a mostrar el resultado de la suma
// Console.WriteLine & Console.ReadLine() & Uso de Variables

int num1;
int num2;
int res;

//1
Console.WriteLine("Ingrese el primer número");
//int.Parse() vs int.TryParse()
int.TryParse(Console.ReadLine(),out num1 );
Console.WriteLine("Ingrese el segundo número");
int.TryParse(Console.ReadLine(), out num2);

Console.WriteLine("Sus dos números son:" + num1 + " y " + num2);
Console.WriteLine(".....sumando......");
res = num1 + num2;
Console.WriteLine("El resultado es:" + res);




/*
// Ejercicio numero 2 - Determinar si un numero es par
// 1- Le vamos a pedir al usuario que ingrese un número
// 2- Vamos a determinar si es par o impar
// 3- Vamos a mostrar el resultado de la operacion
// Console.WriteLine & Console.ReadLine() & Uso de Variables
// int.TryParse()
Console.WriteLine("ingrese su número");
int dividendo;
int resto;
int cociente;
// dividimos por 2: si el resto es 0 es par, si es 1 es impar


int.TryParse(  Console.ReadLine(), out dividendo);
Console.WriteLine("Su número es..."+ dividendo);
cociente = dividendo / 2;
resto = dividendo - (cociente * 2);
Console.WriteLine("cociente es:");
Console.WriteLine(cociente);
Console.WriteLine("resto es:");
Console.WriteLine(resto); //0: par ó 1:impar

// Estructura de control llamada IF ... ELSE (SÍ - SINO)
if(resto==0)
{
    Console.WriteLine("Es par");
} else
{
    Console.WriteLine("Es impar");
}
*/

/* Ejecicio 2b usando el operador resto*/
Console.WriteLine("ingrese su número");
int dividendo;
int resto;
// dividimos por 2: si el resto es 0 es par, si es 1 es impar
int.TryParse(Console.ReadLine(), out dividendo);
Console.WriteLine("Su número es..." + dividendo);

resto = dividendo % 2;
Console.WriteLine("resto es:");
Console.WriteLine(resto); //0: par ó 1:impar

// Estructura de control llamada IF ... ELSE (SÍ - SINO)
if (resto == 0)
{
    Console.WriteLine("Es par");
}
else
{
    Console.WriteLine("Es impar");
}

// Ejercicio 3
// Solicitar el año de nacimiento de un usuario
// Y calcular la edad que tiene (sin diferenciar
// mes el cumpleaños
Console.WriteLine("Bienvenido. Por favor ingrese");
Console.WriteLine("su año de nacimiento");
int año;
int.TryParse(Console.ReadLine(), out año);
int añoactual = 2021;
int edad = añoactual - año;
Console.WriteLine("Su edad es:" + edad+ " años.");

