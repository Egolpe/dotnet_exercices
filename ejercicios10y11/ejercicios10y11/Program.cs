//Ejercicio 10

Console.WriteLine("Escribe tu nombre: ");
String nombre = Console.ReadLine();

Console.WriteLine("Escribe tu email: ");
String email = Console.ReadLine();

Console.WriteLine("¿Tienes descuento? si o no: ");
String descuento = Console.ReadLine();

float precio = 55f;

if(descuento == "no")
{
    Console.WriteLine($"El pedido de {nombre}, con {email} asciende a: {precio}€");
}else if(descuento == "si")
{
    Console.WriteLine($"El pedido de {nombre}, con {email} asciende a: {precio - precio * 0.20}€");

}
else {
    Console.WriteLine($"El pedido de {nombre}, con {email} asciende a: {precio}€");

}


//Ejercicio11


Console.WriteLine("Por favor escriva un número del 1 al 3: ");
int lenguajes = Convert.ToInt32(Console.ReadLine());

switch (lenguajes)
{
    case 1:
        Console.WriteLine("java");
        break;
    case 2:
        Console.WriteLine("C++");
        break;
    case 3:
        Console.WriteLine("Hola Mundo, C#");
        break;
    default:
        Console.WriteLine("Este no es un nnúmero válido.");
        break;
}