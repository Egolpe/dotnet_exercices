//WHILE

int i = 0;
while (i < 10)
{ 
    i++;
    Console.WriteLine($"1 x {i} = " + i);
}



// DO...WHILE
Console.WriteLine("Introduce un numero entre el 10 y el -10: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num !=0 && num > 0)
{
    do
    {
        Console.WriteLine(num);
        num++;

    } while (num < 10);
}else if(num != 0 && num < 0) {
    do
    {
        Console.WriteLine(num);
        num--;
    } while (num > -10);
}else if(num == 0)
{
        Console.WriteLine("El número introducido es un cero y no pienso hacer nada con él");

}



//FOR



        String simbolo = "*";
Console.WriteLine("Introduce el número de ancura que quieres: ");
        int ancho = Convert.ToInt32(Console.ReadLine());

        for (int j = 0; j < ancho; j++)
        {
            Console.Write(simbolo);
        }

        Console.WriteLine();

        for (int j = 0; j < ancho - 2; j++)
        {
            Console.Write(simbolo);

            for (int k = 0; k < ancho - 2; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine(simbolo);
        }

        for (int j = 0; j < ancho; j++)
        {
            Console.Write(simbolo);
        }

        Console.WriteLine();