/*Ejercicio 1 - If
Escribe un programa que:

Pida datos a un cliente: Nombre, email, cupón
Determine si un cliente tiene un cupon descuento
Muestre un precio rebajado en función del descuento
Muestre el precio de un producto sin descuento si no hay cupón
Nota: puedes poner un precio fijo de un producto o uno variable.
*/
string nombre, email, cupon ="no";
const float productoA= 12.4f;
const float productoB = 10.5f;
const int valorCupon = 25;
Console.Write("Ingrese nombre cliente: ");
nombre=Console.ReadLine();
Console.Write("Ingrese email cliente: ");
email = Console.ReadLine();
Console.Write("Ingrese cupon cliente, de no tener ingrese NO: ");
cupon = Console.ReadLine();
cupon = cupon.ToUpper();
if (cupon != "NO")
{
   
    Console.Write("el precio con descuento por cupon para "+ nombre);
    Console.WriteLine(" es de "+ (productoA - ((productoA * valorCupon) / 100)));
}
else
{
   
    Console.Write("el cliente " + nombre);
    Console.WriteLine(" no posee cupon de descuento, el precio es de "+productoA);
}

/*Ejercicio 2 - Switch

Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. 
Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. 
Presenta el resultado en consola.*/
List <string> lenguajes = new List<string>() {"c#","java","c++" };
string valor ="";
Console.WriteLine("ingrese valor a buscar");
valor= Console.ReadLine();
valor = valor.ToUpper();
switch (valor)
{
    case "1" or "a":
        Console.WriteLine(lenguajes[0]);
        break;
    case "2" or "b":
        Console.WriteLine(lenguajes[1]);
        break;
    case "3" or "b":
        Console.WriteLine(lenguajes[2]);
        break;
    default:
        Console.WriteLine("ingrese valores de 1 a 3 ó A a B");
        break;
}

