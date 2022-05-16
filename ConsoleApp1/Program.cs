// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Utils;
using ConsoleApp1.DAL;
using ConsoleApp1.DTO;
/*Ejemplo metodos de extension para tipo de datos y variable s
String nombre = "Tulio";
Console.WriteLine(nombre.ToLower());
Ejemplo basico de colecciones y variables sin definir tipo hasta iniciacion
var names = new[] { "", "Felipe", "Emilia" };
foreach (var nombre in nombres){
    Console.WriteLine($"Hello {nombre.ToUpper()}!");
}

ejemplo operadores ternarios
int edad = 18;

string mensaje = (edad >= 18 ? "Es mayor de edad" : "Es menor de edad");
Console.WriteLine(mensaje);

clase estatica  no contiene new
*/
/*
 * EJEMPLO CLASE ESTATICA:
using ConsoleApp1.Utils;

Console.WriteLine(ConsoleUtils.Saludar("Catalina"));
*/
/*
 * Impresion de lineas
Console.WriteLine("Hola");
Console.Write("Mundo");

Console.Write("Hola");
Console.WriteLine("Mundo");
*/
/*
 * CAMBIO DE COLORES
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Blue;

EJEMPLO ENTRADA Y SALIDA DE CONSOLA
Console.Write("Escribe Un Nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Ha escrito {nombre}");
*/


while (Menu())
{
    Console.ReadKey(); //Pausa, solicitar la entrada de tecla
}

static bool Menu()
{
    bool continuar = true;

    Console.Clear(); //limpia la pantalla
    Console.Title = "Ejercicio Menu + Clases";

    Console.WriteLine("Menu opciones");
    Console.WriteLine("=============");
    Console.WriteLine("1) Listar Datos");
    Console.WriteLine("2) Agregar Datos");
    Console.WriteLine("");
    Console.WriteLine("0) Salir");

    string opcion = Console.ReadLine().Trim();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Escogio la opcion 1");
            break;
        case "2":
            Console.WriteLine("Escogio la opcion 2");
            break;
        case "0":
            Console.WriteLine("Saliendo del programa");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }

    return continuar;
}

static void OpcionInsertar()
{

    try 
	{	        
        Console.WriteLine("Ingresar el ID");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese valor de la Temperatura");
        float temperatura = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese valor del flujo:");
        float flujo = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese valor del nivel");
        float nivel = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese valor del voltaje");
        float voltaje = float.Parse(Console.ReadLine());
        
        DatoDTO 
	    }
	    catch (Exception)
	    {
		    Console.WriteLine("Ingrese correctamente los datos e intente otra vez");
        }
	}
}