/* ejemplo switck */
Console.WriteLine("ingresá el primer número: ");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("ingresá el segundo número: ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("1 = Suma");
Console.WriteLine("2 = Resta");
Console.WriteLine("3 = Multiplicación");
Console.WriteLine("4 = División");

Console.WriteLine("Ingresá la operación a realizar");
string operacion = Console.ReadLine();
double resultado = 0;
switch (operacion)
{
    case "1":
        resultado = numero1 + numero2;
        break;
    case "2":
        resultado = numero1 - numero2;
        break;
    case "3":
        resultado = numero1 * numero2;
        break;
    case "4" when numero2 != 0: //cuando
        resultado = numero1 / numero2;
        break; // siempre break para que el programa no contine
    default:
        Console.WriteLine("ingresaste una opción no valida");
        break;
}
Console.WriteLine("El resultado es: " + resultado);