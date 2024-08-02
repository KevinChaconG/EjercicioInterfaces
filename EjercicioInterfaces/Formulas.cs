
namespace EjercicioInterfaces
{
    public class Formulas : IOperaciones 
    {
        public double s { get; set; }
        public double L { get; set; }
        public double W { get; set; }
        public double H { get; set; }
        public double AreaBase { get; set; }
        public double r { get; set; }

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
            return (AreaBase * H);
        }

        public double PiramideCono()
        {
            return (AreaBase * H) / 3;
        }

        public double Esfera()
        {
            return (Math.PI * (r * r * r) / 3);
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
