
using EjercicioInterfaces;

Formulas formulas = new Formulas();
Console.WriteLine("Bienvenido(a) a la calculadora de Volumenes");
Console.WriteLine("Ingrese el valor de la longitud de los lados del Cubo");
formulas.s = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor de la longitud del Prisma Rectangular Recto");
formulas.L = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del ancho del Prisma Rectangular Recto");
formulas.W = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor de la altura del Prisma Rectangular Recto/Prisma/Cilindro/Piramide/Cono");
formulas.H = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del area de base del Prisma/Cilindro/Piramide/Cono");
formulas.AreaBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el valor del radio del circulo");
formulas.r = Convert.ToDouble(Console.ReadLine());

formulas.Imprimir();
Console.ReadLine();
