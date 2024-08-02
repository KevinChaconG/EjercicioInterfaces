
namespace EjercicioInterfaces
{
    public class Formulas : IOperaciones 
    {
        public double s;
        public double L;
        public double W;
        public double H;
        public double AB;
        public double h;
        public double r;

        double IOperaciones.Cubo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IOperaciones.PrismaRectangularRecto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IOperaciones.PrismaCilindro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IOperaciones.PiramideCono { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IOperaciones.Esfera { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Cubo()
        {
            return s * s * s;
        }

        public double PrismaRectangularRecto()
        {
            return L * W * H;
        }

        public double PrismaCilindro()
        {
            return AB * h;
        }

        public double PiramideCono()
        {
            return (AB * h) / 3;
        }

        public double Esfera()
        {
            return (4 * 3.1415926535897931 * (r * r * r) / 3);
        }

        public void Imprimir()
        {
            Console.WriteLine("---Resultados---");
            Console.WriteLine($"El Volumen del Cubo es: {Cubo()}");
            Console.WriteLine($"El Volumen del Prisma Rectangular Recto es: {PrismaRectangularRecto()}");
            Console.WriteLine($"El volumen del Prisma / Cilindro es: {PrismaCilindro()}");
            Console.WriteLine($"El volumen de la Piramide / Cono es: {PiramideCono()}");
            Console.WriteLine($"El volumen de la Esfera es: {Esfera()}");
            Console.WriteLine();
        }
            
    }
}
