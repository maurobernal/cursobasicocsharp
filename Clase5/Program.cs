DateTime FechayHora;
DateOnly Fecha;
TimeOnly Hora;




FechayHora = new DateTime(2022,05,29,17,27,25);
Fecha = new DateOnly(2022, 05, 29);
Hora = new TimeOnly(17, 27, 25);

/*
Console.WriteLine("Fecha y Hora:");
Console.WriteLine(FechayHora);

Console.WriteLine("Hora:");
Console.WriteLine(Fecha);


Console.WriteLine("Fecha:");
Console.WriteLine(Hora);

*/
//01 Determinar la fecha y hora actual del equipo
/*
FechayHora = DateTime.Now;
Console.WriteLine("Fecha y Hora:");
Console.WriteLine(FechayHora);
*/
//02- Determina la fecha y hora por separado del equipo actual

/*
Fecha = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine("Hora:");
Console.WriteLine(Fecha);

Hora = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine("Fecha:");
Console.WriteLine(Hora);


*/

// Obtener el primer dia del mes y el ultimo día del mes
/*
DateOnly PrimerDia = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, 1);
DateOnly UltimoDia = PrimerDia.AddMonths(1).AddDays(-1);


Console.WriteLine($"Primer dia:{PrimerDia}" );
Console.WriteLine($"Último dia:{UltimoDia}");

*/
//1 - Definir un datetime con el siguiente valor: 16 / 03 / 2021 12:25hs
//2 - Ingresado una fecha calcular la edad
//3-¿Cuantos segundos existen a hoy?
//4-¿Que día de la semana nació?


//Ejercicio1
//DateTime Fecha1 = new DateTime(2021, 03, 16, 12, 25,0);
/*
//Ejercicio2
int año, mes, dia;
Console.WriteLine("Ingrese el año de nacimiento");
año = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el mes de nacimiento");
mes = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el dia de nacimiento");
dia = int.Parse(Console.ReadLine());

DateTime FechaNac = new DateTime(año, mes, dia);

int edad = DateTime.Now.Year - FechaNac.Year;
if(DateTime.Now.Month<FechaNac.Month)  edad--;
Console.WriteLine($"La edad es {edad}");



Console.WriteLine(DateTime.Now.);


Console.WriteLine(FechaNac.DayOfWeek);
*/



DateTime Fecha1 = new DateTime(2021, 03, 16, 12, 25, 0);

Console.WriteLine(Fecha1.ToShortDateString());
Console.WriteLine(Fecha1.ToLongDateString());
Console.WriteLine(Fecha1.ToShortTimeString());
Console.WriteLine(Fecha1.ToLongTimeString());



Console.WriteLine(Fecha1.ToString());

Console.WriteLine(Fecha1.ToString("yyyy MM MMM  dd dddd HH:mm:ss"));