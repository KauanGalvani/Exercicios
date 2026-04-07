namespace Ecercicios.ConsoleApp
{
    class Calculadora
    {
        public decimal temperaturaFahrenheit;
        public decimal c;
        public void ParaFahrenheit()
        {

            Console.Write("Digite qual a temperatura para converter?:");
            c = Convert.ToDecimal(Console.ReadLine());

            temperaturaFahrenheit = (c * 9 / 5) + 32;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Converter = new Calculadora();

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Conversor de temperatura Ceusius para Fahrenheit");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");

            Converter.ParaFahrenheit();
            Console.WriteLine($"o valor de Ceusius para Fahrenheit é {Converter.temperaturaFahrenheit}°");

        }
    }
}