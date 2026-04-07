namespace Ecercicios.ConsoleApp
{
    class Calculadora
    {
        public decimal temperaturaCesius;
        public decimal f;
        public void ParaCesius()
        {

            Console.Write("Digite qual a temperatura para converter?:");
            f = Convert.ToDecimal(Console.ReadLine());

            temperaturaCesius = (f - 32) * 5 / 9;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Converter = new Calculadora();

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Conversor de temperatura Fahrenheit para Ceusius");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");

            Converter.ParaCesius();
            Console.WriteLine($"o valor de Fahrenheit para Ceusius é {Converter.temperaturaCesius}°");

        }
    }
}